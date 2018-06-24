using System;
using System.Windows.Forms;

namespace FoodWinForm
{
    public sealed partial class frmMain : Form
    {   //Singleton
        private static readonly frmMain _Instance = new frmMain();
        public delegate void Notify(string prProductName);

        //public event Notify ProductNameChanged;

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get {
                return frmMain._Instance;
            }
        }

        private void updateTitle(string prProductName)
        {
            if (!string.IsNullOrEmpty(prProductName))
                Text = "Product - " + prProductName;
        }

        public async void UpdateDisplayAsync()
        {  
            lstPlaces.DataSource = null;
            lstPlaces.DataSource = await ServiceClient.GetPlaceNamesAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmPlace.RunAsync(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new place");
            }
        }

        private void lstPlaces_DoubleClick(object sender, EventArgs e)
        {
            frmPlace.RunAsync(lstPlaces.SelectedItem as string);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstPlaces.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting place", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    MessageBox.Show(await ServiceClient.DeletePlace(lcKey));
                    UpdateDisplayAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting place");
                }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplayAsync();
        }
     
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            frmOrder.Run();
        }
    }
}