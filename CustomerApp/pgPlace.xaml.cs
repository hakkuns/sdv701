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
    public sealed partial class pgPlace : Page
    {
        private clsAllProduct _Product;
        private clsPlace _Place;

        public pgPlace()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcPlaceName = e.Parameter.ToString();
                _Place = await ServiceClient.GetPlaceInstockAsync(lcPlaceName);
                UpdateDisplay();
            }
            else 
                _Place = new clsPlace();
        }

        private void UpdateDisplay()
        {
            lstProduct.ItemsSource = null;
            if (_Place.ProductsList != null)
                lstProduct.ItemsSource = _Place.ProductsList;
        }

        private void editProduct(clsAllProduct prProduct)
        {
            if (prProduct != null)
                Frame.Navigate(typeof(pgProduct), prProduct);
        }

        private async void Select_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Please select a product");
            if (lstProduct.SelectedItem != null)
                editProduct(lstProduct.SelectedItem as clsAllProduct);
            else
                await md.ShowAsync();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

    }
}
