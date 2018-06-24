using System;
using System.Windows.Forms;

namespace FoodWinForm
{
    public partial class frmFruit : frmProduct
    {
        public frmFruit()
        {
            InitializeComponent();
        }

        public static frmFruit instance = new frmFruit();

        public static frmFruit Getinstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmFruit();
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
            txtQuality.Text = _Product.Quality;
        }

        protected override void pushData()
        {
            base.pushData();
            _Product.Quality = txtQuality.Text;
            _Product.Category = "1";
        }
    }
}

