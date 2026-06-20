using LogicLayer;
using OnlineStoreProject.UI_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
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

        private void DeleteShipment()
        {
            if (MessageBox.Show("Are you sure you want to delete this shipment" , "" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                if (clsShippment.DeleteShipment((int)dgvShipments.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deletion failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void pDFFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDFConverter frm = new frmPDFConverter(dtShipments, "Shipments");
            frm.ShowDialog();
        }

        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvertToXML frm = new frmConvertToXML(dtShipments, "Shipments");
            frm.ShowDialog();
        }

        private void jsonFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvertToJSON frm = new frmConvertToJSON(dtShipments, "Shipments");
            frm.ShowDialog();
        }

        private void deleteThisShippementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteShipment();
            LoadData();
        }

        private void seeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShipmentCard frm = new frmShipmentCard((int)dgvShipments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
