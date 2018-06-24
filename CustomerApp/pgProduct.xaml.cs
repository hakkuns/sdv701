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
    public sealed partial class pgProduct : Page
    {
        protected clsAllProduct _Product;
        protected clsOrder _Order = new clsOrder();

        public pgProduct()
        {
            this.InitializeComponent();

            _ProductContent = new Dictionary<string, Delegate>
            {
                { "1", new LoadWorkControlDelegate(RunFruit)},
                { "2", new LoadWorkControlDelegate(RunVegetable)},
                { "3", new LoadWorkControlDelegate(RunMeat)}
            };
        }

        private async void Button1_Click(object sender, RoutedEventArgs e)
        {
            pushData();
            if (txtName.IsTextSelectionEnabled)
                await ServiceClient.InsertProductAsync(_Product);
            else
                await ServiceClient.UpdateProductAsync(_Product);
            Frame.GoBack();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void updatePage(clsAllProduct prProduct)
        {
            _Product = prProduct;
            txtName.Text = _Product.ProductName;
            txtDate.Text = _Product.Date.ToString("d");
            txtPrice.Text = _Product.Price.ToString();
            (ctcProductSpecs.Content as IProductControl).UpdateControl(prProduct);
        }
        
        private void pushData()
        {
            _Product.ProductName = txtName.Text;
            _Product.Date = DateTime.Parse(txtDate.Text);
            _Product.Price = decimal.Parse(txtPrice.Text);
           // _Order.Quantity = txtQuantity.Text;
           // _Order.Contact = txtContact.Text;
            (ctcProductSpecs.Content as IProductControl).PushData(_Product);

           // (ctcProductSpecs.Content as IProductControl).PushData(_Order);
        }

        private void RunFruit(clsAllProduct prProduct)
        {
            ctcProductSpecs.Content = new ucFruit();
        }

        private void RunMeat(clsAllProduct prProduct)
        {
            ctcProductSpecs.Content = new ucMeat();
        }

        private void RunVegetable(clsAllProduct prProduct)
        {
            ctcProductSpecs.Content = new ucVegetable();
        }
        
        private delegate void LoadWorkControlDelegate(clsAllProduct prProduct);
        private Dictionary<string, Delegate> _ProductContent;
        private void dispatchWorkContent(clsAllProduct prProduct)
        {
            _ProductContent[prProduct.Category].DynamicInvoke(prProduct);
            updatePage(prProduct);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            dispatchWorkContent(e.Parameter as clsAllProduct);
        }
        
        private async void Order_Click(object sender, RoutedEventArgs e)
        {

            if ((txtQuantity.Text == "") || (txtContact.Text == ""))
            {
                txtOrder.Text = "Enter any value";
                return;
            }

            MessageDialog msg = new MessageDialog("Are you sure to order?");
            msg.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(this.CommandInvokedHandler_yesAsync)));
            msg.Commands.Add(new UICommand("No", new UICommandInvokedHandler(this.CommandInvokedHandler_no)));
            await msg.ShowAsync();  
        }

        private async void CommandInvokedHandler_yesAsync(IUICommand command)
        {
            pushData();

            _Order.PlaceName = _Product.PlaceName;
            _Order.ProductName = _Product.ProductName;
            _Order.Price = _Product.Price;
            _Order.Date = _Product.Date;

            _Order.Quantity = txtQuantity.Text;
            _Order.Contact = txtContact.Text;
            
            //string message = await ServiceClient.InsertOrderAsync(_Product);

            string message = await ServiceClient.InsertOrderAsync(_Order);
            txtOrder.Text = message.Trim('"');
            //txtOrder.Text = await ServiceClient.InsertOrderAsync(_Product);
        }

        private void CommandInvokedHandler_no(IUICommand command)
        {
        }

        private void txtQuantity_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Key.ToString(), "[0-9]"))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtContact_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Key.ToString(), "[0-9]"))
                e.Handled = false;
            else
                e.Handled = true;
        }
    
    }
}
