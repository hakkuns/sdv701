using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace CustomerApp
{
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            this.InitializeComponent();
        }
        
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lstPlace.ItemsSource = await ServiceClient.GetPlaceNamesAsync();
        }
        
        private async void Select_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Please select a place");
            if (lstPlace.SelectedItem != null)
                Frame.Navigate(typeof(pgPlace), lstPlace.SelectedItem);
            else
               await md.ShowAsync();
        }
    }
}
