using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using LogicLayer.Events;
namespace OnlineStoreProject.Shippment_UI
{
    public partial class frmSaveShippmentInfos : Form
    {
        public frmSaveShippmentInfos()
        {
            InitializeComponent();
        }
        enum enShipments { 
            Add , Update
        }
        clsShippment Shippment = new clsShippment();
        enShipments _Mode = enShipments.Add;
        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
        public void Save(ShipmentsEventArgs e)
        {
            string Operation_Name = "";
            switch (_Mode)
            {
                case enShipments.Add:
                    Shippment = new clsShippment(e.Shipping_Carrier, e.carrier_service_level,
                        e.tracking_number, e.tracking_url,
                        e.estimated_delivery_date, e.actual_delivery_date,
                        e.shipping_notes, e.shipping_updates,
                        e.shipping_cost, e.ShipmentStatusID);
                    Operation_Name = " Adding ";
                    _Mode = enShipments.Update;
                    break;
                case enShipments.Update:

                    break;
            }

        }
        private void ctrlSaveShippementInfo1_OnShippementInfoConfirmed(object sender, ShipmentsEventArgs e)
        {

        }

        private void frmSaveShippmentInfos_Load(object sender, EventArgs e)
        {

        }
    }
}
