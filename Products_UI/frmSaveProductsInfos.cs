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

namespace OnlineStoreProject.Products_UI
{
    public partial class frmSaveProductsInfos : Form
    {

        enum enMode { eUpdate = 1 , eAdd = 2 }

        enMode _Mode = enMode.eAdd;
        public frmSaveProductsInfos()
        {
            InitializeComponent();
            _Mode = enMode.eAdd;
        }

        public frmSaveProductsInfos(int ProductID)
        {
            InitializeComponent();
            _Mode = enMode.eUpdate;
            _GetProductByID(ProductID);
            ctrlSaveProductInfos1.SetUserControlToUpdateMode(product);
        }

        clsProduct product = new clsProduct();
        private void frmSaveProductsInfos_Load(object sender, EventArgs e)
        {
            ctrlSaveProductInfos1.LoadCategoryList();
        }

        private async void _GetProductByID(int ProductID)
        {
            product = await clsProduct.FindProductByID(ProductID);
        }


        private async Task<bool> _AddProductImagesList(List<string> liItems , int PriceID)
        {
            return await clsProduct.InsertImagesOfProduct(liItems, PriceID);
        }

        private async void _Save(ProductEventArgs e)
        {
            switch (_Mode)
            {
                case enMode.eAdd:
                    product = new clsProduct(e.Name, e.Description, e.Price, e.Quantity, e.CategoryID);
                    break;
                case enMode.eUpdate:
                    product.EditAttributes(e);
                    break;
            }


            if (product.Save())
            {
                MessageBox.Show("Product was added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (e.LiPhotosPaths.Count > 0)
                {
                    bool result = await _AddProductImagesList(e.LiPhotosPaths, product.ProductID);
                    if (result == true)
                    {
                        MessageBox.Show("Product Images was saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product Images saving failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("saving product information failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlSaveProductInfos1_OnProductInfosSaved(object sender, ProductEventArgs e)
        {
            _Save(e);
        }
    }
}
