using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FoodWinForm
{
    public partial class frmPlace : Form
    {
        private clsPlace _Place;

        private static Dictionary<string, frmPlace> _PlaceFormList =
        new Dictionary<string, frmPlace>();

        private frmPlace()
        {
            InitializeComponent();
        }

        public static async void RunAsync(string prPlaceName)
        {
            frmPlace lcPlaceForm;

            if (string.IsNullOrEmpty(prPlaceName) ||
            !_PlaceFormList.TryGetValue(prPlaceName, out lcPlaceForm))

            {
                lcPlaceForm = new frmPlace();
                if (string.IsNullOrEmpty(prPlaceName))
                    lcPlaceForm.SetDetails(new clsPlace());
                else
                {
                    _PlaceFormList.Add(prPlaceName, lcPlaceForm);
                    await lcPlaceForm.refreshFormFromDBAsync(prPlaceName);
                }
            }
            else
            {
                lcPlaceForm.Show();
                lcPlaceForm.Activate();
            }
        }

        private void updateTitle(string prPlaceName)
        {
            if (!string.IsNullOrEmpty(prPlaceName))
                Text = "Place Details - " + prPlaceName;
        }

        private void UpdateDisplay()
        {
            lstProducts.DataSource = null;
            if (_Place.ProductsList != null)
                lstProducts.DataSource = _Place.ProductsList;
        }

        public void UpdateForm()
        {
            txtPlaceName.Text = _Place.PlaceName;
            txtCode.Text = _Place.Code;
           // txtPhone.Text = _Place.Phone;
        }

        public void SetDetails(clsPlace prPlace)
        {
            _Place = prPlace;
            txtPlaceName.Enabled = string.IsNullOrEmpty(_Place.PlaceName);
            UpdateForm();
            UpdateDisplay();
           // frmMain.Instance.ProductNameChanged += new frmMain.Notify(updateTitle);
            Show();
        }
        
        private void pushData()
        {
            _Place.PlaceName = txtPlaceName.Text;
            _Place.Code = txtCode.Text;
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            if ((txtPlaceName.Text == "") || (txtCode.Text == ""))
            {
                MessageBox.Show("Please enter any value");
                return;
            }

            string lcReply = new InputBox(clsAllProduct.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(lcReply))
            {
                clsAllProduct lcProduct = clsAllProduct.NewProduct(lcReply);
                if (lcProduct != null)      
                {
                    if (txtPlaceName.Enabled)               
                    {
                        pushData();
                        await ServiceClient.InsertPlaceAsync(_Place);
                        txtPlaceName.Enabled = false;
                    }

                    lcProduct.PlaceName = _Place.PlaceName;
                    frmProduct.DispatchWorkForm(lcProduct);
                    if (!string.IsNullOrEmpty(lcProduct.ProductName))          
                    {
                        await refreshFormFromDBAsync(_Place.PlaceName);
                        frmMain.Instance.UpdateDisplayAsync();
                    }
                }
            }
        }

        private void lstProducts_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                frmProduct.DispatchWorkForm(lstProducts.SelectedValue as clsAllProduct);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            int lcIndex = lstProducts.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteProductAsync(lstProducts.SelectedItem as clsAllProduct));
                await refreshFormFromDBAsync(_Place.PlaceName);
                frmMain.Instance.UpdateDisplayAsync();
            }
        }

        private async void btnClose_ClickAsync(object sender, EventArgs e)
        {
            if ((txtPlaceName.Text == "") || (txtCode.Text == ""))
            {
                Close();
            }
            else
            {

                try
                {
                    pushData();
                    if (txtPlaceName.Enabled)
                    {
                        MessageBox.Show(await ServiceClient.InsertPlaceAsync(_Place));
                        frmMain.Instance.UpdateDisplayAsync();
                        txtPlaceName.Enabled = false;
                    }
                    else
                        MessageBox.Show(await ServiceClient.UpdatePlaceAsync(_Place));
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private Boolean isValid()
        {  
                return true;
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private async System.Threading.Tasks.Task refreshFormFromDBAsync(string prPlaceName)
        {
            SetDetails(await ServiceClient.GetPlaceAsync(prPlaceName));
        }
        
        private async void order_ClickAsync(object sender, EventArgs e)
        {
            MessageBox.Show(await ServiceClient.InsertOrderAsync(lstProducts.SelectedItem as clsAllProduct));
        }
        
    }
}