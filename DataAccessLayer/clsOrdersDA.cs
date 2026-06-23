using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;

namespace DataAccessLayer
{
    public class clsOrdersDA
    {
        public static int InsertOrder(DateTime orderDate, TimeSpan orderTime, int quantity, decimal amount, int customerID, int productID, int orderStatus_ID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_InsertOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add OrderDate parameter
                command.Parameters.AddWithValue("@OrderDate", orderDate);

                // Add OrderTime parameter
                command.Parameters.AddWithValue("@OrderTime", orderTime);

                // Add Quantity parameter
                command.Parameters.AddWithValue("@Quantity", quantity);

                // Add Amount parameter
                command.Parameters.AddWithValue("@Amount", amount);

                // Add CustomerID parameter
                command.Parameters.AddWithValue("@CustomerID", customerID);

                // Add ProductID parameter
                command.Parameters.AddWithValue("@ProductID", productID);

                // Add OrderStatus_ID parameter
                command.Parameters.AddWithValue("@OrderStatus_ID", orderStatus_ID);

                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                // Execute the stored procedure
                connection.Open();
                command.ExecuteNonQuery();

                // Return the newly generated Customer ID
                return (int)outputIdParam.Value;
            }
        }

        public static OrderDTO FindAnOrderByID(int OrderID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindAnOrderByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new OrderDTO(
                                reader.GetInt32(reader.GetOrdinal("order_id")),
                                reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                                reader.GetTimeSpan(reader.GetOrdinal("OrderTime")),
                                reader.GetInt32(reader.GetOrdinal("Quantity")),
                                reader.GetDecimal(reader.GetOrdinal("Amount")),
                                reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                reader.GetInt32(reader.GetOrdinal("ProductID")),
                                reader.GetInt32(reader.GetOrdinal("OrderStatus_ID"))
                            );
                        }
                    }
                }
            }
            return null;
        }


        public static bool UpdateOrder(int orderID, DateTime orderDate, TimeSpan orderTime, int quantity, decimal amount, int customerID, int productID, int orderStatusID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add Order ID parameter
                command.Parameters.AddWithValue("@OrderID", orderID);

                // Add OrderDate parameter
                command.Parameters.AddWithValue("@OrderDate", orderDate);

                // Add OrderTime parameter
                command.Parameters.AddWithValue("@OrderTime", orderTime);

                // Add Quantity parameter
                command.Parameters.AddWithValue("@Quantity", quantity);

                // Add Amount parameter
                command.Parameters.AddWithValue("@Amount", amount);

                // Add CustomerID parameter
                command.Parameters.AddWithValue("@CustomerID", customerID);

                // Add ProductID parameter
                command.Parameters.AddWithValue("@ProductID", productID);

                // Add OrderStatusID parameter
                command.Parameters.AddWithValue("@OrderStatusID", orderStatusID);

                connection.Open();
              return  command.ExecuteNonQuery() > 0;
                 
            }
        }

    }
}
