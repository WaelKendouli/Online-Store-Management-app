using LogicLayer;
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

namespace OnlineStoreProject.Orders_UI
{
    public partial class frmOrdersHistory : Form
    {
        int _CustomerID = 0;
        DataTable _dtOrdersHistory = new DataTable();
        public frmOrdersHistory(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            
        }
        public async void LoadData()
        {
            dgvOrdersHistory.DataSource = _dtOrdersHistory;
            _dtOrdersHistory = await clsOrder.GetHistoryOfOrdersPerCustomerAsync(_CustomerID);
            clsSunnyUIDataGridViewSettings.LoadData(_dtOrdersHistory, dgvOrdersHistory,
                cbItems, new List<string> { "Amount" , "Quantity" , "OrderTime" }, 140);
        }
        private void frmOrdersHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void updateThisOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveOrderForCustomer frm = new frmSaveOrderForCustomer((int)dgvOrdersHistory.CurrentRow.Cells[1].Value
                , (int)dgvOrdersHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData();
        }

        private void addNewOrderForThisCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveOrderForCustomer frm = new frmSaveOrderForCustomer((int)dgvOrdersHistory.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            LoadData();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.HandleTextBoxChangingEvent(txtInput, cbItems, _dtOrdersHistory);
        }

        private void pDFFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDFConverter frm = new frmPDFConverter(_dtOrdersHistory , "Order history table");
            frm.ShowDialog();
        }

        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvertToXML frm = new frmConvertToXML(_dtOrdersHistory, "Order history table");
            frm.ShowDialog();
        }
    }
}
