using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using LogicLayer.Events;
namespace OnlineStoreProject.Orders_UI
{
    public partial class frmSaveOrderForCustomer : Form
    {
        enum enMode { eAdd , eUpdate }
        enMode _Mode = enMode.eAdd;
        public frmSaveOrderForCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _Mode = enMode.eAdd;
        }

        public frmSaveOrderForCustomer(int CustomerID , int OrderID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _OrderID = OrderID;
            _Mode = enMode.eUpdate;
        }
        int _OrderID = 0;
        int _CustomerID = 0;
        decimal _Price = 0;
        int _MaximumQuantity = 0;
        decimal _OrderAmount = 0;
        int _ProductID = -1;
        clsOrder _Order = new clsOrder();
        private void _UpdateAmountPerProduct(decimal Price, int OrderQuantity)
        {
            double Percentage = (Convert.ToDouble(Price) * 0.2);
            _OrderAmount = (Price + Convert.ToDecimal(Percentage)) * OrderQuantity;
            txtAmount.Text = Convert.ToString(_OrderAmount);
        }

        private void frmSaveOrderForCustomer_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
            numQuantity.Maximum = 1000;
            ctrlSearchProduct1.FillListProductsFromDB_ForLoad();
        }

        private void _UpdateMaximumQuantity(int ProductQuantity)
        {
            numQuantity.Maximum = ProductQuantity;
            _MaximumQuantity = ProductQuantity;
        }
        private void ctrlSearchProduct1_OnProductSelected(object sender, ProductEventArgs e)
        {
            _Price = e.Price;
            _ProductID = e.ProductID;
            _UpdateAmountPerProduct(_Price, Convert.ToInt16(numQuantity.Value));
            _UpdateMaximumQuantity(e.Quantity);
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }
        private void _HandleIncreasingQuantityValue()
        {
            if (numQuantity.Value > _MaximumQuantity)
            {
                numQuantity.Value = _MaximumQuantity;
            }
            else
            {
                numQuantity.Value++;
            }
        }

        private void _HandlingDecreasingQuantityValue()
        {
            if (numQuantity.Value == 0)
            {
                return;
            }
            numQuantity.Value--;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            _HandleIncreasingQuantityValue();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _HandlingDecreasingQuantityValue();

        }

        private void Order()
        {
             _Order = new clsOrder(DateTime.Now, DateTime.Now.TimeOfDay,
               Convert.ToInt32(numQuantity.Value), _OrderAmount, _CustomerID, _ProductID, 1);
            if (_Order.Insert())
            {
                MessageBox.Show($"Order was placed successfully on {_Order.OrderDate}","",MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Placing Order failed successfully on {_Order.OrderDate}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            _UpdateAmountPerProduct(_Price, Convert.ToInt16(numQuantity.Value));
            
        }

        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            Order();
        }
    }
}
