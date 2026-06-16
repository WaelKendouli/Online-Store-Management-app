using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsShipmentDA
    {
        public static int AddNewShipement(
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
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewShipement", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Handle Shipping_Carrier (required)
                if (string.IsNullOrEmpty(shipping_Carrier))
                {
                    throw new ArgumentException("Shipping carrier is required", nameof(shipping_Carrier));
                }
                command.Parameters.AddWithValue("@Shipping_Carrier", shipping_Carrier);

                // Handle carrier_service_level (nullable - varchar(50))
                if (string.IsNullOrEmpty(carrier_service_level))
                {
                    command.Parameters.AddWithValue("@carrier_service_level", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@carrier_service_level", carrier_service_level);
                }

                // Handle tracking_number (nullable - varchar(100))
                if (string.IsNullOrEmpty(tracking_number))
                {
                    command.Parameters.AddWithValue("@tracking_number", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@tracking_number", tracking_number);
                }

                // Handle tracking_url (nullable - varchar(255))
                if (string.IsNullOrEmpty(tracking_url))
                {
                    command.Parameters.AddWithValue("@tracking_url", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@tracking_url", tracking_url);
                }

                // Handle estimated_delivery_date (nullable - date)
                command.Parameters.AddWithValue("@estimated_delivery_date", estimated_delivery_date ?? (object)DBNull.Value);

                // Handle actual_delivery_date (nullable - date)
                command.Parameters.AddWithValue("@actual_delivery_date", actual_delivery_date ?? (object)DBNull.Value);

                // Handle shipping_notes (nullable - text)
                if (string.IsNullOrEmpty(shipping_notes))
                {
                    command.Parameters.AddWithValue("@shipping_notes", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@shipping_notes", shipping_notes);
                }

                // Handle shipping_updates (nullable - text)
                if (string.IsNullOrEmpty(shipping_updates))
                {
                    command.Parameters.AddWithValue("@shipping_updates", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@shipping_updates", shipping_updates);
                }

                // Handle shipping_cost (required - decimal(8,2))
                command.Parameters.AddWithValue("@shipping_cost", shipping_cost);

                // Handle ShipmentStatusID (required)
                command.Parameters.AddWithValue("@ShipmentStatusID", shipmentStatusID);

                // Output parameter for the new Shipment ID
                var outputIdParam = new SqlParameter("@NewShipmentID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                // Execute the stored procedure
                connection.Open();
                command.ExecuteNonQuery();

                // Return the newly generated Shipment ID
                return (int)outputIdParam.Value;
            }
        }

        public static Dictionary<string, int> GetShippementStatus()
        {
            Dictionary<string, int> DicShippementStatus = new Dictionary<string, int>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetShippementStatus", conx))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conx.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Assuming the table has StatusName and StatusID columns
                        // Adjust column names based on your actual ShippmentStatus table structure
                        string statusName = reader.GetString(reader.GetOrdinal("StatusName")); // Or "Status_Name"
                        int statusID = reader.GetInt32(reader.GetOrdinal("StatusID")); // Or "Status_ID"

                        if (!DicShippementStatus.ContainsKey(statusName))
                        {
                            DicShippementStatus.Add(statusName, statusID);
                        }
                    }
                }
            }
            return DicShippementStatus;
        }

        public static bool UpdateShipment(int shipmentID, string shipping_Carrier, string carrier_service_level, string tracking_number,
            string tracking_url, DateTime? estimated_delivery_date, DateTime? actual_delivery_date,
            string shipping_notes, string shipping_updates, decimal shipping_cost, int shipmentStatusID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateShipment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add Shipment ID parameter
                command.Parameters.AddWithValue("@ShipmentID", shipmentID);

                // Add Shipping_Carrier parameter
                command.Parameters.AddWithValue("@Shipping_Carrier", shipping_Carrier);

                // Handle carrier_service_level (nullable)
                if (string.IsNullOrEmpty(carrier_service_level))
                {
                    command.Parameters.AddWithValue("@carrier_service_level", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@carrier_service_level", carrier_service_level);
                }

                // Handle tracking_number (nullable)
                if (string.IsNullOrEmpty(tracking_number))
                {
                    command.Parameters.AddWithValue("@tracking_number", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@tracking_number", tracking_number);
                }

                // Handle tracking_url (nullable)
                if (string.IsNullOrEmpty(tracking_url))
                {
                    command.Parameters.AddWithValue("@tracking_url", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@tracking_url", tracking_url);
                }

                // Handle estimated_delivery_date (nullable)
                if (estimated_delivery_date.HasValue)
                {
                    command.Parameters.AddWithValue("@estimated_delivery_date", estimated_delivery_date.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@estimated_delivery_date", DBNull.Value);
                }

                // Handle actual_delivery_date (nullable)
                if (actual_delivery_date.HasValue)
                {
                    command.Parameters.AddWithValue("@actual_delivery_date", actual_delivery_date.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@actual_delivery_date", DBNull.Value);
                }

                // Handle shipping_notes (nullable)
                if (string.IsNullOrEmpty(shipping_notes))
                {
                    command.Parameters.AddWithValue("@shipping_notes", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@shipping_notes", shipping_notes);
                }

                // Handle shipping_updates (nullable)
                if (string.IsNullOrEmpty(shipping_updates))
                {
                    command.Parameters.AddWithValue("@shipping_updates", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@shipping_updates", shipping_updates);
                }

                // Add shipping_cost parameter
                command.Parameters.AddWithValue("@shipping_cost", shipping_cost);

                // Add ShipmentStatusID parameter
                command.Parameters.AddWithValue("@ShipmentStatusID", shipmentStatusID);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }


    }
}
