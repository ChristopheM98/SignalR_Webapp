using System;
using System.Windows;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Connectie naar Blazerserver hub
        HubConnection connection;

        public MainWindow()
        {
            InitializeComponent();

            //Path naar de server -> BlazorServerSignalRApp -> Properties -> launchSettings.json -> https connectieurl
            //We gebruiken https omdat in Program.cs app.UseHttpsRedirection staat
            //Zelfde string als in Index.razor pagina
            connection = new HubConnectionBuilder().WithUrl(url: "https://localhost:7283/chathub").WithAutomaticReconnect().Build();

            //Bij reconnecting wordt er bericht getoond
            connection.Reconnecting += (sender) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    var newMessage = "Attempting to reconnect...";
                    messages.Items.Add(newMessage);
                });

                return Task.CompletedTask;
            };

            connection.Reconnected += (sender) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    var newMessage = "Reconnected to the server!";
                    messages.Items.Clear();
                    messages.Items.Add(newMessage);
                });

                //Wachten op Dispatcher, dan pas Task completen
                return Task.CompletedTask;
            };

            connection.Closed += (sender) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    var newMessage = "Connection closed!";
                    messages.Items.Add(newMessage);
                    openConnection.IsEnabled = true;
                    sendMessage.IsEnabled = false;
                });

                return Task.CompletedTask;
            };
        }

        private async void openConnection_Click(object sender, RoutedEventArgs e)
        {
            connection.On<string, string>(methodName: "ReceiveMessage", (user, message) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    var newMessage = $"{user}: {message}";
                    messages.Items.Add(newMessage);
                });
            });

            try
            {
                await connection.StartAsync();
                messages.Items.Add(newItem: "Connection Started");
                openConnection.IsEnabled = false;
                sendMessage.IsEnabled = true;
            }
            catch (Exception ex)
            {
                messages.Items.Add(ex.Message);
            }
        }

        private async void sendMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await connection.InvokeAsync("SendMessage", "WPF Client", messageInput.Text);
            }
            catch (Exception ex)
            {
                messages.Items.Add(ex.Message);
            }
        }
    }
}
