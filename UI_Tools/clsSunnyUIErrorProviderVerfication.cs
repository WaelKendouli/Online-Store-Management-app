using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace OnlineStoreProject.UI_Tools
{
    public class clsSunnyUIErrorProviderVerfication
    {
        public delegate bool delValidationFunction(string input);
        public delegate bool delCheckExistence(int ID, string Input);
        public static bool _ValidateByErrorProvider(ErrorProvider ep, UITextBox tx, CancelEventArgs e,
           delValidationFunction ValidationFunction, string ErrorMessage = "")
        {

            if (ValidationFunction(tx.Text.Trim()))
            {
                // Cancel the event and set the error
                e.Cancel = true;
                ep.SetError(tx, ErrorMessage);

                // Optional: Select the textbox with error
                // tx.Select(0, tx.Text.Length);
                return true;

            }
            else
            {
                // Clear the error
                ep.SetError(tx, "");
                e.Cancel = false;
                return false;
            }

        }

        public static bool _ValidateByErrorProvider(ErrorProvider ep, UIRichTextBox tx, CancelEventArgs e,
           delValidationFunction ValidationFunction, string ErrorMessage = "")
        {

            if (ValidationFunction(tx.Text.Trim()))
            {
                // Cancel the event and set the error
                e.Cancel = true;
                ep.SetError(tx, ErrorMessage);

                // Optional: Select the textbox with error
                // tx.Select(0, tx.Text.Length);
                return true;

            }
            else
            {
                // Clear the error
                ep.SetError(tx, "");
                e.Cancel = false;
                return false;
            }

        }


        public static bool _ExistenceValidationByErrorProvider(ErrorProvider ep, UITextBox tx, CancelEventArgs e,
          delCheckExistence ExistenceFunction, int ID, string ErrorMessage = "", bool ExistenceCondition = false)
        {

            if (ExistenceFunction(ID, tx.Text.Trim()) == ExistenceCondition)
            {
                // Cancel the event and set the error
                e.Cancel = true;
                ep.SetError(tx, ErrorMessage);

                // Optional: Select the textbox with error
                tx.Select(0, tx.Text.Length);
                return true;

            }
            else
            {
                // Clear the error
                ep.SetError(tx, "");
                e.Cancel = false;
                return false;
            }
        }
    }
}