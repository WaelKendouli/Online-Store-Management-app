using LibraryLogicLayer;
using LogicLayer;
using LogicLayer.Events;
using OnlineStoreProject.UI_Tools;
using Sunny.UI;
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
    public partial class ctrlSaveProductInfos : UserControl
    {
        public ctrlSaveProductInfos()
        {
            InitializeComponent();
        }
        List<string> liPhotosPath = new List<string>();
        Dictionary<string, int> DicProdCategories = new Dictionary<string, int>();
        public event EventHandler<ProductEventArgs> OnProductInfosSaved;

        protected virtual void ProductInfosSaved(ProductEventArgs e)
        {
            OnProductInfosSaved?.Invoke(this, e);
        }

        private bool _ValidateIntegerValues(UITextBox tx)
        {
            if (int.TryParse(tx.Text, out int result) == false || result < 0)
            {
                tx.Clear();
                return false;
            }
            return true;
        }
        private bool _ValidateDoubleValues(UITextBox tx)
        {
            if (decimal.TryParse(tx.Text, out decimal result)==false || result < 0)
            {
                tx.Clear();
                return false;
            }
            return true;
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (_ValidateDoubleValues(txtPrice)==false)
            {
                return;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (_ValidateIntegerValues(txtQuantity) == false)
            {
                return;
            }
        }

        private void _LoadCategoriesComboBox()
        {
            foreach (var item in DicProdCategories)
            {
                cbCategories.Items.Add(item.Key);
            }

        }
        public async void LoadCategoryList()
        {
            cbCategories.Enabled = false;
             DicProdCategories = await clsProduct.GetListOfCategoriesAsync();
            cbCategories.Enabled = true;
            _LoadCategoriesComboBox();
        }

        private void ctrlSaveProductInfos_Load(object sender, EventArgs e)
        {

        }

        public void SetUserControlToUpdateMode(clsProduct product) {
            cbImagesPaths.Visible = false;
            btnAddPhoto.Visible = false;
            pbProducts.Visible = false;
            lbCategoryText.Text = "Update Category :";
            txtDescription.Text = product.Description;
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtName,
                e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtName, e, clsInputValidator.IsNameNotValid,
                "this field shouldn't be empty");
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtDescription,
                e, string.IsNullOrEmpty, "this field shouldn't be empty");
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            ProductInfosSaved(new ProductEventArgs(txtName.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), DicProdCategories[cbCategories.SelectedText],liPhotosPath));
        }

        private void _AddPhoto()
        {
            string PhotoPath = clsPhotosHandeling._SelectPhotoCover(pbProducts);
            pbProducts.Image = Image.FromFile(PhotoPath);
            if (liPhotosPath.Contains(PhotoPath)==false)
            {
                liPhotosPath.Add(PhotoPath);
            }
            if (cbImagesPaths.Items.Contains(PhotoPath)==false)
            {
                cbImagesPaths.Items.Add(PhotoPath);
            }

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            _AddPhoto();
        }

        private void cbImagesPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbProducts.Image = Image.FromFile(cbImagesPaths.SelectedText);
        }
    }
}
