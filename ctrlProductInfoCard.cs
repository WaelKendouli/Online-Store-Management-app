using LibraryLogicLayer;
using LogicLayer;
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
    public partial class ctrlProductInfoCard : UserControl
    {


       public clsProduct CurrentProduct { get; set; } = null;

        List<string> liPhotos = new List<string>();
        int _CurrentIndex = 0;
        public ctrlProductInfoCard()
        {
            InitializeComponent();
        }

        private void _NextPhotoSelected()
        {
            if (liPhotos.Count==0)
            {
                throw new Exception("list of pictures is already empty you can't perform this operation");
            }

            if (_CurrentIndex==liPhotos.Count-1)
            {
                _CurrentIndex = 0;
            }
            else
            {
                _CurrentIndex++;
                pbProductImage.Image = Image.FromFile(liPhotos[_CurrentIndex]);
            }

        }

        private void _PreviousPhotoSelected()
        {
            if (liPhotos.Count == 0)
            {
                throw new Exception("list of pictures is already empty you can't perform this operation");
            }

            if (_CurrentIndex == 0)
            {
                _CurrentIndex = liPhotos.Count - 1;
            }
            else
            {
                _CurrentIndex--;
                pbProductImage.Image = Image.FromFile(liPhotos[_CurrentIndex]);
            }

        }

        public async void LoadProductCardInfos(int ProductID)
        {
            CurrentProduct = await clsProduct.FindProductByID(ProductID);
            if (CurrentProduct!=null)
            {
                liPhotos = CurrentProduct.ListOfImagesPaths;
                lbProductName.Text = CurrentProduct.Name;
                lbQuantity.Text = CurrentProduct.Quantity.ToString();
                txtDescription.Text = CurrentProduct.Description;
                if (liPhotos.Count > 0)
                {
                    pbProductImage.Image = Image.FromFile(liPhotos[0]);
                }
                btnNext.Enabled = liPhotos.Count > 1;
                btnPrevious.Enabled = liPhotos.Count > 1;
            }
        }


        private void ctrlProductInfoCard_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _NextPhotoSelected();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _PreviousPhotoSelected();
        }
    }
}
