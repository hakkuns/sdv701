using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CustomerApp
{
    public sealed partial class ucMeat : IProductControl
    {
        public ucMeat()
        {
            this.InitializeComponent();
        }

        public Grid Grid()
        {
            throw new NotImplementedException();
        }

        public void PushData(clsAllProduct prProduct)
        {
            prProduct.Price = decimal.Parse(txtPrice.Text);
            prProduct.Amount = txtAmount.Text;
            prProduct.Category = "3";
        }

        public void UpdateControl(clsAllProduct prProduct)
        {
            txtPrice.Text = prProduct.Price.ToString();
            txtAmount.Text = prProduct.Amount;
        }

    }
}
