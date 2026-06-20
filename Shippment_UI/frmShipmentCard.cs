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

namespace OnlineStoreProject.Shippment_UI
{
    public partial class frmShipmentCard : Form
    {
        clsShippment _Shipment = new clsShippment();
        public frmShipmentCard(int ShipmentID)
        {
            InitializeComponent();
            _Shipment = clsShippment.GetShipmentByID(ShipmentID);
        }

        private void frmShipmentCard_Load(object sender, EventArgs e)
        {
            ctrlShipmentCard1.FillCard(_Shipment);
        }
    }
}
