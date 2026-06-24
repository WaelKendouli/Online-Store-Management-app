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

namespace OnlineStoreProject
{
    public partial class ctrlSearchProduct : UserControl
    {
        public ctrlSearchProduct()
        {
            InitializeComponent();
        }

       public clsProduct CurrentProduct  { get; set; } = null;

        public event EventHandler<ProductEventArgs> OnProductSelected;

        Dictionary<string, int> dicCategories = new Dictionary<string, int>();

        protected virtual void OnProductSelect(ProductEventArgs e)
        {
            OnProductSelected?.Invoke(this, e);
        }


        private List<string> _ListOfProductNames = new List<string>();

        private void _FillCategoriesComboBox()
        {
            if (dicCategories.Count > 0)
            {
                foreach (var item in dicCategories)
                {
                    cbCategory.Items.Add(item.Key);
                }
                cbCategory.SelectedIndex = 0;
            }
        }

        private void _FillProductComboBox()
        {
            cbItems.Clear();
            if (_ListOfProductNames.Count > 0)
            {
                foreach (string ProductName in _ListOfProductNames)
                {
                    cbItems.Items.Add(ProductName);
                }
                cbItems.SelectedIndex = 0;
            }
        }

        private void _FillProductComboBox(string TargetedProductName)
        {
            cbItems.Clear();
            if (_ListOfProductNames.Count > 0)
            {
                foreach (string Product in _ListOfProductNames)
                {
                    cbItems.Items.Add(Product);
                    if (Product == TargetedProductName)
                    {
                        cbItems.SelectedItem = TargetedProductName;
                    }
                }
               
            }
        }

        private async void _GetProductListPerCategory()
        {
            if (dicCategories.Count > 0)
            {
                cbItems.SelectedIndex = 0;
                _ListOfProductNames = await clsProduct.GetListOfProductsName(dicCategories[cbCategory.SelectedItem.ToString()]);
                cbItems.Enabled = _ListOfProductNames != null;
                _FillProductComboBox();
            }
        }
        /// <summary>
        /// Overloaded function , Used After finding a product by ID
        /// </summary>
        /// <param name="CategoryID"></param>
        /// <exception cref="Exception"></exception>
        private async void _GetProductListPerCategory(int CategoryID , string ProductName)
        {
            if (CategoryID < 0)
            {
                throw new Exception("Category ID was not valid");
            }
            string CategoryName = string.Empty;
            foreach (var item in dicCategories)
            {
                if (item.Value == CategoryID)
                {
                    CategoryName = item.Key;
                }
            }
            cbCategory.SelectedItem = CategoryName;
            if (dicCategories.Count > 0)
            {
                cbItems.SelectedIndex = 0;
                _ListOfProductNames = await clsProduct.GetListOfProductsName(CategoryID);
                cbItems.Enabled = _ListOfProductNames != null;
                _FillProductComboBox( ProductName);

            }
        }

        public async void FillListProductsFromDB_ForLoad()
        {
            dicCategories = await clsProduct.GetListOfCategoriesAsync();
            _FillCategoriesComboBox();

        }

        private void ctrlProductCardInfos1_Load(object sender, EventArgs e)
        {
           
        }

        private void ctrlSearchProduct_Load(object sender, EventArgs e)
        {
            cbItems.Enabled = false;
        }

        /// <summary>
        /// overloaded function used after finding an existing product By ID
        /// </summary>
        

        public async void FillUserControlBasedOnProductID(int ProductID)
        {
            CurrentProduct = await clsProduct.FindProductByID(ProductID);
            if (CurrentProduct != null)
            {
                ctrlProductCardInfos1.LoadProductCardInfo(CurrentProduct);
                _GetProductListPerCategory(CurrentProduct.CategoryID, CurrentProduct.Name);
                OnProductSelect(new ProductEventArgs(CurrentProduct.ProductID, CurrentProduct.Name, CurrentProduct.Description,
                    CurrentProduct.Price, CurrentProduct.Quantity,
                    CurrentProduct.CategoryID, CurrentProduct.ListOfImagesPaths));
            }
            else
            {
                MessageBox.Show($"{cbItems.SelectedText.ToString()} Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void _Search()
        {
            if (cbItems.Items.Count > 0 && cbItems.Enabled == true)
            {
                CurrentProduct = await clsProduct.FindProductByName(cbItems.SelectedItem.ToString());
                if (CurrentProduct!=null)
                {
                    ctrlProductCardInfos1.LoadProductCardInfo(CurrentProduct);
                    OnProductSelect(new ProductEventArgs(CurrentProduct.ProductID ,CurrentProduct.Name, CurrentProduct.Description,
                        CurrentProduct.Price, CurrentProduct.Quantity,
                        CurrentProduct.CategoryID, CurrentProduct.ListOfImagesPaths));
                }
                else
                {
                    MessageBox.Show($"{cbItems.SelectedText.ToString()} Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private  void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            _GetProductListPerCategory();
        }
    }
}
