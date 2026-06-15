using OnlineStoreProject.UI_Tools;
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
using LogicLayer;
namespace OnlineStoreProject
{
    public partial class frmSearchCustomer : Form
    {
        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {

        }

        private void ctrlSearchCustomer1_OnSearchedPerformed(object sender, clsCustomerEventsArgs e)
        {
            dgvCustomerHistory.DataSource = clsCustomer.GetCustomerPurchaseHistory(e.CustomerID);
        }
    }
}
