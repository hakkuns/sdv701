using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoodWinForm
{
    public partial class frmProduct : Form
    {
        protected clsAllProduct _Product;

        public frmProduct()
        {
            InitializeComponent();
        }

        public void SetDetails(clsAllProduct prProduct)
        {
            _Product = prProduct;
            updateForm();
            ShowDialog();
        }

        private async void btnOK_ClickAsync(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                if (txtName.Enabled)
                    MessageBox.Show(await ServiceClient.InsertProductAsync(_Product));
                else
                    MessageBox.Show(await ServiceClient.UpdateProductAsync(_Product));
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Text = _Product.ProductName;
            txtName.Enabled = string.IsNullOrEmpty(_Product.ProductName);

            txtCreation.Text = _Product.Date.ToShortDateString();
            txtValue.Text = _Product.Price.ToString();
            txtInstock.Text = _Product.Instock.ToString();
        }

        protected virtual void pushData()
        {
            _Product.ProductName = txtName.Text;
            _Product.Date = DateTime.Parse(txtCreation.Text);
            _Product.Price = decimal.Parse(txtValue.Text);
            _Product.Instock = int.Parse(txtInstock.Text);
        }

        public delegate void LoadProductFormDelegate(clsAllProduct prProduct);
        public static Dictionary<string, Delegate> _ProductsForm = new Dictionary<string, Delegate>
        {
            
            { "1", new LoadProductFormDelegate(frmFruit.Run)},
            { "3", new LoadProductFormDelegate(frmMeat.Run) },
            { "2", new LoadProductFormDelegate(frmVegetable.Run) }
            
        };

        public static void DispatchWorkForm(clsAllProduct prProduct)
        {
            _ProductsForm[prProduct.Category].DynamicInvoke(prProduct);
            //_ProductsForm["2"].DynamicInvoke(prProduct);
        }
        
    }
}