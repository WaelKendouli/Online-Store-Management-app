using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
