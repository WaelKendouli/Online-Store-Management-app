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

namespace OnlineStoreProject.Shippment_UI
{
    public partial class frmShippmentManagement : Form
    {
        public frmShippmentManagement()
        {
            InitializeComponent();
        }
        DataTable dtShipments = new DataTable();

        private async void LoadShipmentList()
        {
            dtShipments = await clsShippment.GetShippementListAsync();
            dgvShipments.DataSource = dtShipments;
            clsSunnyUIDataGridViewSettings.LoadData(dtShipments, dgvShipments, cbItems, null, 170);

        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.HandleTextBoxChangingEvent(txtInput, cbItems, dtShipments);
        }
        private void LoadData()
        {
            LoadShipmentList();
        }
        private void frmShippmentManagement_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void btnAddNewShipment_Click(object sender, EventArgs e)
        {
            frmSaveShippmentInfos frm = new frmSaveShippmentInfos();
            frm.ShowDialog();
            LoadData();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void updateThisShippemntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveShippmentInfos frm = new frmSaveShippmentInfos((int)dgvShipments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData();
        }
    }
}
