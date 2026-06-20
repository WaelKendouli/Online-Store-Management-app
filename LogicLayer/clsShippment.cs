using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;
using System.Data;
using LogicLayer.Events;
namespace LogicLayer
{
    public class clsShippment
    {
        enum Mode
        {
            eAddNew = 1,
            eUpdate = 2
        }

        Mode _Mode = Mode.eAddNew;
        public ShipmentDTO DTO = null;

        // Properties
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

        
        // Private constructor for existing shipment (Update mode)
        private clsShippment(
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
            DTO = new ShipmentDTO(
                shipmentID,
                shipping_Carrier,
                carrier_service_level,
                tracking_number,
                tracking_url,
                estimated_delivery_date,
                actual_delivery_date,
                shipping_notes,
                shipping_updates,
                shipping_cost,
                shipmentStatusID
            );
            _Mode = Mode.eUpdate;

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

        // Public constructor for new shipment (Add mode)
        public clsShippment(
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
            _Mode = Mode.eAddNew;
            DTO = new ShipmentDTO(
                0, // Placeholder ID for new shipment
                shipping_Carrier,
                carrier_service_level,
                tracking_number,
                tracking_url,
                estimated_delivery_date,
                actual_delivery_date,
                shipping_notes,
                shipping_updates,
                shipping_cost,
                shipmentStatusID
            );

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

        // Default constructor
        public clsShippment()
        {
            _Mode = Mode.eAddNew;
            DTO = new ShipmentDTO();
        }

        // Private Add New Shipment
        private bool AddNewShipment(
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
            int newID = clsShipmentDA.AddNewShipement(
                shipping_Carrier,
                carrier_service_level,
                tracking_number,
                tracking_url,
                estimated_delivery_date,
                actual_delivery_date,
                shipping_notes,
                shipping_updates,
                shipping_cost,
                shipmentStatusID
            );

            if (newID > 0)
            {
                this.ShipmentID = newID;
                return true;
            }
            return false;
        }

        // Private Update Shipment
        private bool UpdateShipment(
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
            return clsShipmentDA.UpdateShipment(
                shipmentID,
                shipping_Carrier,
                carrier_service_level,
                tracking_number,
                tracking_url,
                estimated_delivery_date,
                actual_delivery_date,
                shipping_notes,
                shipping_updates,
                shipping_cost,
                shipmentStatusID
            );
        }

        // Static method to get shipment status dictionary
        public static Dictionary<string, int> GetShipmentStatuses()
        {
            return clsShipmentDA.GetShippementStatus();
        }

        public static ShipmentDTO GetShipmentByID(int ShipmentID)
        {
            return clsShipmentDA.FindShipmentByID(ShipmentID);
        }
        
        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.eAddNew:
                    if (AddNewShipment(
                        this.Shipping_Carrier,
                        this.Carrier_Service_Level,
                        this.Tracking_Number,
                        this.Tracking_URL,
                        this.Estimated_Delivery_Date,
                        this.Actual_Delivery_Date,
                        this.Shipping_Notes,
                        this.Shipping_Updates,
                        this.Shipping_Cost,
                        this.ShipmentStatusID
                    ))
                    {
                        _Mode = Mode.eUpdate;
                        // Update DTO with new ID
                        if (this.DTO != null)
                        {
                            this.DTO.ShipmentID = this.ShipmentID;
                        }
                        return true;
                    }
                    break;

                case Mode.eUpdate:
                    if (UpdateShipment(
                        this.ShipmentID,
                        this.Shipping_Carrier,
                        this.Carrier_Service_Level,
                        this.Tracking_Number,
                        this.Tracking_URL,
                        this.Estimated_Delivery_Date,
                        this.Actual_Delivery_Date,
                        this.Shipping_Notes,
                        this.Shipping_Updates,
                        this.Shipping_Cost,
                        this.ShipmentStatusID
                    ))
                    {
                        DTO = new ShipmentDTO(this.ShipmentID,
                        this.Shipping_Carrier,
                        this.Carrier_Service_Level,
                        this.Tracking_Number,
                        this.Tracking_URL,
                        this.Estimated_Delivery_Date,
                        this.Actual_Delivery_Date,
                        this.Shipping_Notes,
                        this.Shipping_Updates,
                        this.Shipping_Cost,
                        this.ShipmentStatusID);
                        return true;
                    }
                    return false;
            }
            return false;
        }
        public static async Task<DataTable> GetShippementListAsync()
        {
            return await clsShipmentDA.GetShippementListAsync();
        }
        // Override ToString for easy display
        public override string ToString()
        {
            return $"Shipment #{ShipmentID} - {Shipping_Carrier} - {ShipmentStatusID}";
        }

        public void EditAttributes(ShipmentsEventArgs e)
        {
            this.Shipping_Carrier = e.Shipping_Carrier;
            this.Carrier_Service_Level = e.carrier_service_level;
            this.Tracking_Number = e.tracking_number;
            this.Tracking_URL = e.tracking_url;
            this.Estimated_Delivery_Date = e.estimated_delivery_date;
            this.Actual_Delivery_Date = e.actual_delivery_date;
            this.Shipping_Notes = e.shipping_notes;
            this.Shipping_Updates = e.shipping_updates;
            this.Shipping_Cost = e.shipping_cost;
            this.ShipmentStatusID = e.ShipmentStatusID;
        }

        }

        // Data Transfer Object for Shipment



    }
