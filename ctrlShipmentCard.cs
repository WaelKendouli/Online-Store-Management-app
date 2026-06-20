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
    public partial class ctrlShipmentCard : UserControl
    {
        public ctrlShipmentCard()
        {
            InitializeComponent();
        }
        Dictionary<string , int>
        private void ctrlShipmentCard_Load(object sender, EventArgs e)
        {

        }
        public void FillCard(clsShippment shipment)
        {
            if (shipment==null)
            {
                return;
            }
            lbCarrierService.Text = shipment.Carrier_Service_Level;
            lbCost.Text = shipment.Shipping_Cost.ToString();
            lbDeliveryDate.Text = shipment.Actual_Delivery_Date.ToString();
            lbEstimatedDate.Text = shipment.Estimated_Delivery_Date.ToString();
            lbSatus.Text = shipment.
        }
        private void lbTrackingURL_Click(object sender, EventArgs e)
        {

        }
    }
}
