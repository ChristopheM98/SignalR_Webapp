   M S B A M L   `   `   `  ����D  @WPFClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFClient	WPFClient  5   	       WPFClient.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFClient     5   	   $��18(�5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��openConnection��5      $��0��6'   $��Center=�64   $��20 10q�6Q   $��20q�6a   .��6�   Open Connectie6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5      �� -   5        $��messageInput��5      $	��300��6*   $��20q�69   �� 5      -   5        $��sendMessage��5      {�.  $��20 10q�6:   $��20q�6J   .��6p   Verstuur bericht6�   5      �� 5   
   $��2��6   $��20q�6$   $	��200��60   $
��auto=�6@   .��5      �� -   5        $��messages��5      $��Stretch=�6&   $��20 10q�6D   $��0q�6T   5      5      5      