using LibraryLogicLayer;
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
using DTO_Layer;
namespace OnlineStoreProject
{
    public partial class ctrlSaveICustomerInfo : UserControl
    {
        public ctrlSaveICustomerInfo()
        {
            InitializeComponent();
        }
        public event EventHandler<clsCustomerEventsArgs> OnCustomerSaved;

        protected virtual void CustomerSaved(clsCustomerEventsArgs e)
        {
            OnCustomerSaved?.Invoke(this, e);
        }

        private bool _IsEmpty(CancelEventArgs e, UITextBox textBox)
        {
            return clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, textBox, e, string.IsNullOrEmpty, "this field shouldn't be empty");
        }

        private bool _Validate(CancelEventArgs e, UITextBox textBox, clsSunnyUIErrorProviderVerfication.delValidationFunction ValidationFunction, string ErrorMessage = "this field is not valid")
        {
            return clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, textBox, e, ValidationFunction, ErrorMessage);
        }

        private void ctrlSaveICustomerInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(e, txtFirstName))
            {
                return;
            }
            _Validate(e, txtFirstName, clsInputValidator.IsNameNotValid);
        }

        private void FillText(UITextBox tx , string content)
        {
            tx.Text = content;
        }
        public void FillInfos(CustomerDTO DTO)
        {
            if (DTO != null)
            {
                FillText(txtFirstName, DTO.First_name);
                FillText(txtLastName, DTO.Last_name);
                FillText(txtThirdName, DTO.Third_name);
                FillText(txtSecondName, DTO.Second_name);
                FillText(txtEmail, DTO.Email);
                FillText(txtPassword, DTO.Password);
                FillText(txtPhone, DTO.Phone);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            CustomerSaved(new clsCustomerEventsArgs(txtFirstName.Text, txtSecondName.Text, txtThirdName.Text, txtLastName.Text,
                txtPhone.Text, txtEmail.Text, txtPassword.Text));
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                return;
            }
            _Validate(e, txtSecondName, clsInputValidator.IsNameNotValid);
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdName.Text))
            {
                return;
            }
            _Validate(e, txtThirdName, clsInputValidator.IsNameNotValid);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(e, txtLastName))
            {
                return;
            }
            _Validate(e, txtLastName, clsInputValidator.IsNameNotValid);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(e, txtPhone))
            {
                return;
            }
            _Validate(e, txtPhone, clsInputValidator.IsPhoneInputNotCorrect);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(e, txtEmail))
            {
                return;
            }
            _Validate(e, txtEmail, clsInputValidator.IsEmailNotValid);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(e, txtPassword))
            {
                return;
            }
        }
    }
}
