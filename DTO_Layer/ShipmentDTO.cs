using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Layer
{
    public class ShipmentDTO
    {
        public int ShipmentID { get; set; }
        public string Shipping_Carrier { get; set; }
        public string Carrier_Service_Level { get; set; }
        public string Tracking_Number { get; set; }
        public string Tracking_URL { get; set; }
        public DateTime? Estimated_Delivery_Date { get; set; }
        public DateTime? Actual_Delivery_Date { get; set; }
        public string Shipping_Notes { get; set; }
        public string Shipping_Updates { get; set; }
        public decimal Shipping_Cost { get; set; }
        public int ShipmentStatusID { get; set; }

        // Default constructor
        public ShipmentDTO() { }

        // Parameterized constructor
        public ShipmentDTO(
            int shipmentID,
            string shipping_Carrier,
            string carrier_service_level,
            string tracking_number,
            string tracking_url,
            DateTime? estimated_delivery_date,
            DateTime? actual_delivery_date,
            string shipping_notes,
            string shipping_updates,
            decimal shipping_cost,
            int shipmentStatusID)
        {
            ShipmentID = shipmentID;
            Shipping_Carrier = shipping_Carrier;
            Carrier_Service_Level = carrier_service_level;
            Tracking_Number = tracking_number;
            Tracking_URL = tracking_url;
            Estimated_Delivery_Date = estimated_delivery_date;
            Actual_Delivery_Date = actual_delivery_date;
            Shipping_Notes = shipping_notes;
            Shipping_Updates = shipping_updates;
            Shipping_Cost = shipping_cost;
            ShipmentStatusID = shipmentStatusID;
        }
    }
}
