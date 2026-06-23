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

        clsProduct Current = null;

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

        private async void _Search()
        {
            if (cbItems.Items.Count > 0 && cbItems.Enabled == true)
            {
                Current = await clsProduct.FindProductByName(cbItems.SelectedItem.ToString());
                if (Current!=null)
                {
                    ctrlProductCardInfos1.LoadProductCardInfo(Current);
                    OnProductSelect(new ProductEventArgs(Current.ProductID ,Current.Name, Current.Description,
                        Current.Price, Current.Quantity,
                        Current.CategoryID, Current.ListOfImagesPaths));
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
