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

namespace OnlineStoreProject
{
    public partial class frmSearchCustomerForRating : Form
    {
        public frmSearchCustomerForRating()
        {
            InitializeComponent();
        }

        private void ctrlSearchCustomer1_OnSearchedPerformed(object sender, clsCustomerEventsArgs e)
        {
            frmRatingListcs frm = new frmRatingListcs(e.CustomerID);
            frm.ShowDialog();
        }
    }
}
