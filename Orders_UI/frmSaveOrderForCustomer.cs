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
            _Order = clsOrder.FindOrderByID(_OrderID);
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
        private void InitialLoad()
        {
            txtAmount.Text = "0";
            numQuantity.Maximum = 1000;
            ctrlSearchProduct1.FillListProductsFromDB_ForLoad();
            switch (_Mode)
            {
                case enMode.eUpdate:
                    if (_Order == null)
                    {
                        throw new Exception("Order object shouldn't be null");
                    }
                    ctrlSearchProduct1.FillUserControlBasedOnProductID(_Order.ProductId);
                    break;
            }
        }


        private void frmSaveOrderForCustomer_Load(object sender, EventArgs e)
        {
            InitialLoad();
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
            if (numQuantity.Value == _MaximumQuantity)
            {
                numQuantity.Value = 0;
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
            string Operation = string.Empty;
            switch (_Mode)
            {
                case enMode.eAdd:
                    _Order = new clsOrder(DateTime.Now, DateTime.Now.TimeOfDay,
               Convert.ToInt32(numQuantity.Value), _OrderAmount, _CustomerID, _ProductID, 1);
                    Operation = "Placing";
                    _Mode = enMode.eUpdate;
                    break;
                case enMode.eUpdate:
                    Operation = "Updating";
                    if (_Order == null)
                    {
                        throw new Exception("Order object shouldn't be null");
                    }
                    break;
            }

            if (_Order.Save())
            {
                MessageBox.Show($"{Operation} was done successfully on {_Order.OrderDate}","",MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{Operation} failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
