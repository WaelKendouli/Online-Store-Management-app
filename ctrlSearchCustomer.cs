using LogicLayer;
using LogicLayer.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreProject
{
    public partial class ctrlSearchCustomer : UserControl
    {
        public ctrlSearchCustomer()
        {
            InitializeComponent();
        }
        clsCustomer customer = null;
        public event EventHandler<clsCustomerEventsArgs> OnSearchedPerformed;

        protected virtual void OnSearchFinished(clsCustomerEventsArgs e)
        {
            OnSearchedPerformed?.Invoke(this, e);
        }

        private void ctrlSearchCustomer_Load(object sender, EventArgs e)
        {

        }

        private bool Search()
        {
            int CustomerID = -1;
            if (int.TryParse(txtInput.Text ,out int result)==false)
            {
                
                MessageBox.Show("input is not valid","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                CustomerID = result;
            }
            customer = clsCustomer.FindCustomerByID(CustomerID);
            
            if (customer==null)
            {
                MessageBox.Show("Customer was not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlCustomerCard1.ResetCard();
                return false;
            }
            ctrlCustomerCard1.FillCustomerInfos(customer.DTO);
            return true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Search()==true)
            {
                OnSearchFinished(new clsCustomerEventsArgs(customer.CustomerID, customer.First_name, customer.Second_name, customer.Third_name, customer.Last_name, customer.Phone, customer.Email));
            }
        }
    }
}
