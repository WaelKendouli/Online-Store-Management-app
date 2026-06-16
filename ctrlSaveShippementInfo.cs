using LibraryLogicLayer;
using LogicLayer;
using LogicLayer.Events;
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

        Dictionary<string, int> dicShipmentStatus = new Dictionary<string, int>(); 
        public event EventHandler<ShipmentsEventArgs> OnShippementInfoConfirmed;
        string Tracking_Number = string.Empty;
        protected virtual void OnShippementInfosSaved(ShipmentsEventArgs e)
        {
            OnShippementInfoConfirmed?.Invoke(this, e);
        }
        private void GenerateNumber()
        {
            Tracking_Number = clsNumberGenerator.GenerateRandomTrackingNumber();
            txt_tracking_number.Text = Tracking_Number;
        }
        private void _InitializeShipmentStatus()
        {
            dicShipmentStatus = clsShippment.GetShipmentStatuses();
            foreach (var item in dicShipmentStatus)
            {
                cbShippmentStatus.Items.Add(item.Key);
            }
            if (cbShippmentStatus.Items.Count > 0)
            {
                cbShippmentStatus.SelectedIndex = 0;
            }
        }
        void _InitializeUserControl()
        {
            dtpEstimatedDate.Value = DateTime.Now;
            dtpEstimatedDate.Value = DateTime.Now;
            _InitializeShipmentStatus();
        }
        private void ctrlSaveShippementInfo_Load(object sender, EventArgs e)
        {
            GenerateNumber();
            _InitializeUserControl();
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
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_carrier_service_level,
               e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
           
        }

        private void txt_tracking_url_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tracking_url.Text))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_tracking_url, e, clsInputValidator.IsTrackingURLNotCorrect,
                "Tracking URL must be a valid web address starting with http:// or https:// and contain '/track?' followed by 'tracknum=' (e.g., https://www.ups.com/track?tracknum=1Z999AA1)");
        }

        private void txt_shipping_updates_Validating(object sender, CancelEventArgs e)
        {
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_shipping_updates, e, clsInputValidator.IsShippingUpdatesNotCorrect,
    "Shipping Updates can contain letters, numbers, spaces, and punctuation (. , : ; -). Maximum 255 characters");
        }

        private void txt_shipping_cost_Validating(object sender, CancelEventArgs e)
        {
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_shipping_cost,
   e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txt_shipping_cost, e, clsInputValidator.IsShippingCostNotCorrect,
                "Shipping Cost must be a positive number with up to 2 decimal places (e.g., 12.99, 5.00, 9.50)");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                return;
            }
            OnShippementInfosSaved(new ShipmentsEventArgs(txt_Shipping_Carrier.Text.ToString(), txt_carrier_service_level.Text.ToString(), Tracking_Number, txt_tracking_url.Text,
                dtpEstimatedDate.Value, dtpActualDeliveryDate.Value,
                txt_shipping_notes.Text, txt_shipping_updates.Text,
                Convert.ToDecimal(txt_shipping_cost.Text), dicShipmentStatus[cbShippmentStatus.SelectedText]));
        }
    }
}
