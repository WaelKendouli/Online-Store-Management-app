using OnlineStoreProject.Products_UI;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            frmCustomersManagement frm = new frmCustomersManagement();
            frm.ShowDialog();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProductsManagemts frm = new frmProductsManagemts();
            frm.ShowDialog();
        }
    }
}
