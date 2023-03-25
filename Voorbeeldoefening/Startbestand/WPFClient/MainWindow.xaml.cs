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
        HubConnection connection;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private async void openConnection_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private async void sendMessage_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
