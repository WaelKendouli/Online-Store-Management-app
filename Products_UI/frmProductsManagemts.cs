using LibraryLogicLayer;
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
using LogicLayer.ConvertersClasses;
using LogicLayer.Interfaces;
using LogicLayer.BackGroundOperations;
namespace OnlineStoreProject.Products_UI
{
    public partial class frmProductsManagemts : Form
    {
        public frmProductsManagemts()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void _RefreshDataGridView()
        {
           
            dt = clsProduct.GetAllProducts();
            clsSunnyUIDataGridViewSettings.LoadData(dt,dgvProducts,cbItems,new List<string> { "quantity" , "price" },200);
        }
        private void frmProductsManagemts_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();
        }

        private async void Convert(IF_Convertible obj , string FileName , string TableName)
        {
            bool Result = await clsBackgroundWorker.Converter(obj, dt, FileName, TableName);

            if (Result)
            {
                MessageBox.Show($"{FileName} was created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{FileName} creation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmSaveProductsInfos frm = new frmSaveProductsInfos();
            frm.ShowDialog();
            _RefreshDataGridView();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.HandleTextBoxChangingEvent(txtInput, cbItems, dt);
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlProductDetails frm = new ctrlProductDetails((int)dgvProducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

       

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new frmSearchProduct();
            frm.ShowDialog();
        }

        private void xMLDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvertToXML frm = new frmConvertToXML(dt,"ProductsXML");
            frm.ShowDialog();
        }

       

        private void turnThisListIntoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pDFFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDFConverter frm = new frmPDFConverter(dt, "Products Table");
            frm.ShowDialog();
        }

        private void jSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvertToJSON frm = new frmConvertToJSON(dt, "Products");
            frm.ShowDialog();
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeserializeToDataTable frm = new frmDeserializeToDataTable();
            frm.ShowDialog();
        }

        private void updateThisProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveProductsInfos frm = new frmSaveProductsInfos((int)dgvProducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
