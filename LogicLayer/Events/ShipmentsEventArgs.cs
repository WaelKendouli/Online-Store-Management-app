using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Events
{
    public class ShipmentsEventArgs : EventArgs
    {
        // Primary Key
        public string Shippment_ID { get; }

        // Shipping Information
        public string Shipping_Carrier { get; }
        public string carrier_service_level { get; }
        public string tracking_number { get; }
        public string tracking_url { get; }

        // Dates
        public DateTime estimated_delivery_date { get; }
        public DateTime actual_delivery_date { get; }

        // Notes & Updates
        public string shipping_notes { get; }
        public string shipping_updates { get; }

        // Financial
        public decimal  shipping_cost { get; }

        // Status
        public int ShipmentStatusID { get; }

        // Constructors
        public ShipmentsEventArgs()
        {
            // Initialize all properties to defaults
            Shippment_ID = string.Empty;
            Shipping_Carrier = string.Empty;
            carrier_service_level = string.Empty;
            tracking_number = string.Empty;
            tracking_url = string.Empty;
            estimated_delivery_date = DateTime.Now;
            actual_delivery_date = DateTime.Now;
            shipping_notes = string.Empty;
            shipping_updates = string.Empty;
            shipping_cost = 0;
            ShipmentStatusID = 0;
        }

        public ShipmentsEventArgs(
           string shippment_ID,
           string shipping_Carrier,
           string carrier_service_level,
           string tracking_number,
           string tracking_url,
           DateTime estimated_delivery_date,
           DateTime actual_delivery_date,
           string shipping_notes,
           string shipping_updates,
           decimal shipping_cost,
           int shipmentStatusID)
        {
            Shippment_ID = shippment_ID;
            Shipping_Carrier = shipping_Carrier;
            this.carrier_service_level = carrier_service_level;
            this.tracking_number = tracking_number;
            this.tracking_url = tracking_url;
            this.estimated_delivery_date = estimated_delivery_date;
            this.actual_delivery_date = actual_delivery_date;
            this.shipping_notes = shipping_notes;
            this.shipping_updates = shipping_updates;
            this.shipping_cost = shipping_cost;
            ShipmentStatusID = shipmentStatusID;
        }



        public ShipmentsEventArgs(
            
            string shipping_Carrier,
            string carrier_service_level,
            string tracking_number,
            string tracking_url,
            DateTime estimated_delivery_date,
            DateTime actual_delivery_date,
            string shipping_notes,
            string shipping_updates,
            decimal shipping_cost,
            int shipmentStatusID)
        {
            
            Shipping_Carrier = shipping_Carrier;
            this.carrier_service_level = carrier_service_level;
            this.tracking_number = tracking_number;
            this.tracking_url = tracking_url;
            this.estimated_delivery_date = estimated_delivery_date;
            this.actual_delivery_date = actual_delivery_date;
            this.shipping_notes = shipping_notes;
            this.shipping_updates = shipping_updates;
            this.shipping_cost = shipping_cost;
            ShipmentStatusID = shipmentStatusID;
        }
    }
}
