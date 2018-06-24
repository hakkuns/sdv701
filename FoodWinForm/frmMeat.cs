using System;
using System.Windows.Forms;

namespace FoodWinForm
{
    public sealed partial class frmMeat : frmProduct
    {
        public frmMeat()
        {
            InitializeComponent();
        }

        public static frmMeat instance = new frmMeat();

        public static frmMeat Getinstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmMeat();
                }
                return instance;
            }
        }

        public static void Run(clsAllProduct prProduct)
        {
            Getinstance.SetDetails(prProduct);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtAmount.Text = _Product.Amount;
        }

        protected override void pushData()
        {
            base.pushData();
            _Product.Amount = txtAmount.Text;
            _Product.Category = "3";
        }
    }
}

