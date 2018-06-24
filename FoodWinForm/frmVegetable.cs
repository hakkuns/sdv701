using System;
using System.Windows.Forms;

namespace FoodWinForm
{
    public sealed partial class frmVegetable : frmProduct
    {
        public frmVegetable()
        {
            InitializeComponent();
        }

        public static frmVegetable instance = new frmVegetable();

        public static frmVegetable Getinstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmVegetable();
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
            txtFreshness.Text = _Product.Freshness;
        }

        protected override void pushData()
        {
            base.pushData();
            _Product.Freshness = txtFreshness.Text;
            _Product.Category = "2";
        }
        
    }
}

