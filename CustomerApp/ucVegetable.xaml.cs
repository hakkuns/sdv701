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
    public sealed partial class ucVegetable : IProductControl
    {
        public ucVegetable()
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
            prProduct.Freshness = txtFreshness.Text;
            prProduct.Category = "2";
        }

        public void UpdateControl(clsAllProduct prProduct)
        {
            txtPrice.Text = prProduct.Price.ToString();
            txtFreshness.Text = prProduct.Freshness;
        }
    }
}
