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
        int _ShipmentID;
    
        public frmSaveShippmentInfos(int ShipmentID)
        {
            InitializeComponent();
            _ShipmentID = ShipmentID;
            _Mode = enShipments.Update;
            Shippment = clsShippment.GetShipmentByID(_ShipmentID);
            ctrlSaveShippementInfo1.FillExistingInformation(Shippment.DTO);
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
                    Operation_Name = " Updating ";
                    if (Shippment==null)
                    {
                        throw new Exception("Shipment object is null");
                    }
                    Shippment.EditAttributes(e);
                    break;
                    
            }
            if (Shippment.Save())
            {
                MessageBox.Show($"{Operation_Name}Shipment done successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{Operation_Name}Shipment failed", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        private void ctrlSaveShippementInfo1_OnShippementInfoConfirmed(object sender, ShipmentsEventArgs e)
        {
            Save(e);
            
        }
       
        private void frmSaveShippmentInfos_Load(object sender, EventArgs e)
        {

        }
    }
}
