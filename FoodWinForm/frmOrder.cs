using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodWinForm
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        public static void Run()
        {
            frmOrder lcOrderForm = new frmOrder();
            lcOrderForm.Activate();

            lcOrderForm.Show();
            
        }

        public async void UpdateDisplayAsync()
        {
            lstOrder.DataSource = null;
            lstOrder.DataSource = await ServiceClient.GetOrderAsync();
        }
        
        private void frmOrder_Load(object sender, EventArgs e)
        {
            UpdateDisplayAsync();
        }

        private async void delete_ClickAsync(object sender, EventArgs e)
        {
            int lcIndex = lstOrder.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteOrderAsync(lstOrder.SelectedItem as clsOrder));
                //await refreshFormFromDBAsync(_Place.PlaceName);
                UpdateDisplayAsync();
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void total_ClickAsync(object sender, EventArgs e)
        {
            UpdateDisplayAsync();
            txtPrice.Text = await ServiceClient.GetTotalPriceAsync();
        }
        
    }
}
