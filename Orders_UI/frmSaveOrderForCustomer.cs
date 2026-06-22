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

        private void _UpdateAmountPerProduct(decimal Price)
        {
            double Percentage = Convert.ToDouble(Price) * 0.4;
            decimal OrderAmount = Price + Convert.ToDecimal(Percentage);
            txtAmount.Text = Convert.ToString(OrderAmount);        
        }

        private void frmSaveOrderForCustomer_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "????";
        }

        private void ctrlSearchProduct1_OnProductSelected(object sender, ProductEventArgs e)
        {
            _UpdateAmountPerProduct(e.Price);
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
    }
}
