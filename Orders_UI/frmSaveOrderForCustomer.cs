using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer.Events;
namespace OnlineStoreProject.Orders_UI
{
    public partial class frmSaveOrderForCustomer : Form
    {
        public frmSaveOrderForCustomer()
        {
            InitializeComponent();
        }
        decimal _Price = 0;
        private void _UpdateAmountPerProduct(decimal Price , int OrderQuantity)
        {
            double Percentage = (Convert.ToDouble(Price) * 0.2) ;
            decimal OrderAmount = (Price + Convert.ToDecimal(Percentage)) * OrderQuantity;
            txtAmount.Text = Convert.ToString(OrderAmount);        
        }

        private void frmSaveOrderForCustomer_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "????";
            numQuantity.Maximum = 1000;
            ctrlSearchProduct1.FillListProductsFromDB_ForLoad();
        }

        private void _UpdateMaximumQuantity(int ProductQuantity)
        {
            numQuantity.Maximum = ProductQuantity;
        }
        private void ctrlSearchProduct1_OnProductSelected(object sender, ProductEventArgs e)
        {
            _Price = e.Price;
            _UpdateAmountPerProduct(_Price , Convert.ToInt16(numQuantity.Value));
            _UpdateMaximumQuantity(e.Quantity);
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            numQuantity.Value++;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (numQuantity.Value == 0)
            {
                return;
            }
            numQuantity.Value--;

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            _UpdateAmountPerProduct(_Price, Convert.ToInt16(numQuantity.Value));
        }
    }
}
