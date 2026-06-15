using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreProject
{
    public partial class ctrlProductCardInfos : UserControl
    {
        clsProduct CurrentProduct = null;
        int _CurrentIndex = 0;
        List<string> liPhotos = new List<string>();
        public ctrlProductCardInfos()
        {
            InitializeComponent();
        }

        private void _NextPhotosSelected()
        {
            if (liPhotos.Count == 0)
            {
                throw new Exception("List of photos is empty");
            }
            if (_CurrentIndex==liPhotos.Count-1)
            {
                _CurrentIndex = 0;
            }
            else
            {
                _CurrentIndex++;
            }
            if (File.Exists(liPhotos[_CurrentIndex]))
            {
                pbProductImage.Image = Image.FromFile(liPhotos[_CurrentIndex]);
            }
            else
            {
                pbProductImage.Image = null;
            }

        }

        private void _PreviousPhotosSelected()
        {
            if (liPhotos.Count == 0)
            {
                throw new Exception("List of photos is empty");
            }
            if (_CurrentIndex == 0)
            {
                _CurrentIndex = liPhotos.Count - 1;
            }
            else
            {
                _CurrentIndex--;
            }
            if (File.Exists(liPhotos[_CurrentIndex]))
            {
                pbProductImage.Image = Image.FromFile(liPhotos[_CurrentIndex]);
            }
            else
            {
                pbProductImage.Image = null;
            }
        }

        public async void LoadProductCardInfo(int ProductID)
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            CurrentProduct = await clsProduct.FindProductByID(ProductID);
            if (CurrentProduct != null)
            {
                lbProductName.Text = CurrentProduct.Name;
                lbPrice.Text = CurrentProduct.Price.ToString() + " $ ";
                lbQuantity.Text = CurrentProduct.Quantity.ToString() + " Units";
                txtDescription.Text = CurrentProduct.Description;
                liPhotos = CurrentProduct.ListOfImagesPaths;
                if (liPhotos.Count>0)
                {
                    pbProductImage.Image = Image.FromFile(liPhotos[0]);
                }
                btnNext.Enabled = liPhotos.Count > 1;
                btnPrevious.Enabled = liPhotos.Count > 1;
            }
        }

        public void LoadProductCardInfo(clsProduct Product)
        {
            CurrentProduct = Product;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            if (CurrentProduct != null)
            {
                lbProductName.Text = CurrentProduct.Name;
                lbPrice.Text = CurrentProduct.Price.ToString() + " $ ";
                lbQuantity.Text = CurrentProduct.Quantity.ToString() + " Units";
                txtDescription.Text = CurrentProduct.Description;
                liPhotos = CurrentProduct.ListOfImagesPaths;
                if (liPhotos.Count > 0)
                {
                    pbProductImage.Image = Image.FromFile(liPhotos[0]);
                }
                btnNext.Enabled = liPhotos.Count > 1;
                btnPrevious.Enabled = liPhotos.Count > 1;
            }
        }


        private void ctrlProductCardInfos_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _PreviousPhotosSelected();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _NextPhotosSelected();
        }
    }
}
