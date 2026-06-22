using LogicLayer;
using OnlineStoreProject.Customers_UI;
using OnlineStoreProject.Orders_UI;
using OnlineStoreProject.Shippment_UI;
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

namespace OnlineStoreProject
{
    public partial class frmCustomersManagement : Form
    {
        public frmCustomersManagement()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void tpCrudOperations_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void _Refresh()
        {
            dt = clsCustomer.GetCustomersLis();
            dgvTable.DataSource = dt;
            clsSunnyUIDataGridViewSettings.LoadData(dt, dgvTable, cbItems , null , 200);
        }
        private void frmCustomersManagement_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.HandleTextBoxChangingEvent(txtInput, cbItems, dt);
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmSaveCustomerInfos frm = new frmSaveCustomerInfos();
            frm.ShowDialog();
            _Refresh();
        }

        private void updateThisCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveCustomerInfos frm = new frmSaveCustomerInfos((int)dgvTable.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();
        }

        private void Delete()
        {
            if (MessageBox.Show("are you sure ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsCustomer.DeleteCustomer((int)dgvTable.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Refresh();
                }
                else
                {
                    MessageBox.Show("deletion failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void deleteThisCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmSearchCustomer frm = new frmSearchCustomer();
            frm.ShowDialog();
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            frmSearchCustomerForRating frm = new frmSearchCustomerForRating();
            frm.ShowDialog();
        }

        private void addShippementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveShippmentInfos frm = new frmSaveShippmentInfos();
            frm.ShowDialog();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            frmSaveOrderForCustomer frm = new frmSaveOrderForCustomer();
            frm.ShowDialog();
        }
    }
}
