using LogicLayer;
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
namespace OnlineStoreProject.Customers_UI
{
    public partial class frmSaveCustomerInfos : Form
    {
        enum EnMode { eAddNew , eUpdate }

        EnMode _Mode = EnMode.eAddNew;
        public frmSaveCustomerInfos()
        {
            InitializeComponent();
        }

        public frmSaveCustomerInfos(int CustomerID)
        {
            customer = clsCustomer.FindCustomerByID(CustomerID);
            InitializeComponent();
            ctrlSaveICustomerInfo1.FillInfos(customer.DTO);
            _Mode = EnMode.eUpdate;
        }


        clsCustomer customer = null;

        private bool Save(clsCustomerEventsArgs e)
        {
            switch (_Mode)
            {
                case EnMode.eAddNew:
                    _Mode = EnMode.eUpdate;
                    customer = new clsCustomer(e.First_name, e.Second_name, e.Third_name,
                        e.Last_name, e.Phone, e.Email, e.Password);
                    return customer.Save();
                case EnMode.eUpdate:
                    if (customer==null)
                    {
                        throw new Exception("Cannot perform this operation because customer object is null");
                    }
                    customer.EditAttributes(e);
                    return customer.Save();
            }
            return false;
        }
        private void frmSaveCustomerInfos_Load(object sender, EventArgs e)
        {

        }

        private void ctrlSaveICustomerInfo1_OnCustomerSaved(object sender, clsCustomerEventsArgs e)
        {
            if (Save(e))
            {
                MessageBox.Show("Customer was saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Customer saving failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
