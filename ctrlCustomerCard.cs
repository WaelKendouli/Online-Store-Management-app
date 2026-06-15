using DTO_Layer;
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
    public partial class ctrlCustomerCard : UserControl
    {
        public ctrlCustomerCard()
        {
            InitializeComponent();
        }


        public void ResetCard()
        {
            lbID.Text = "[????]";
            lbFirstName.Text = "[????]";
            lbLastname.Text = "[????]";
            lbPhone.Text = "[????]";
            lbSecondName.Text = "[????]";
            lbThirdName.Text = "[????]";
            lbEmail.Text = "[????]";
        }
        public void FillCustomerInfos(CustomerDTO DTO)
        {
            if (DTO != null)
            {
                lbID.Text = DTO.CustomerID.ToString();
                lbFirstName.Text = DTO.First_name;
                lbLastname.Text = DTO.Last_name;
                lbPhone.Text = DTO.Phone;
                lbSecondName.Text = DTO.Second_name;
                lbThirdName.Text = DTO.Third_name;
                lbEmail.Text = DTO.Email;

            }
            
        }

        private void ctrlCustomerCard_Load(object sender, EventArgs e)
        {

        }
    }
}
