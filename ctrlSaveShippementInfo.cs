using LibraryLogicLayer;
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
using System.Xml.Linq;

namespace OnlineStoreProject
{
    public partial class ctrlSaveShippementInfo : UserControl
    {
        public ctrlSaveShippementInfo()
        {
            InitializeComponent();
        }

       


        private void ctrlSaveShippementInfo_Load(object sender, EventArgs e)
        {

        }

        private void txt_Shipping_Carrier_Validating(object sender, CancelEventArgs e)
        {
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_Shipping_Carrier,
               e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_Shipping_Carrier, e, clsInputValidator.IsShippingCarrierNotCorrect,
                "Shipping Carrier must be one of: UPS, FedEx, USPS, DHL, Canada Post, or Other\r\n\r\n");
        }

        private void txt_carrier_service_level_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_tracking_url_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_shipping_updates_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_shipping_cost_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
