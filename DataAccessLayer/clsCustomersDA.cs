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
    public class clsCustomersDA
    {
        public static int AddNewCustomer(string firstName, string secondName, string thirdName, string lastName,
    string phone, string email, string password)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Handle First Name (required)
                command.Parameters.AddWithValue("@First_name", firstName);

                // Handle Second Name (nullable)
                if (string.IsNullOrEmpty(secondName))
                {
                    command.Parameters.AddWithValue("@Second_name", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Second_name", secondName);
                }

                // Handle Third Name (nullable)
                if (string.IsNullOrEmpty(thirdName))
                {
                    command.Parameters.AddWithValue("@Third_name", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Third_name", thirdName);
                }

                // Handle Last Name (required)
                command.Parameters.AddWithValue("@Last_name", lastName);

                // Handle Phone (required)
                command.Parameters.AddWithValue("@Phone", phone);

                // Handle Email (required)
                command.Parameters.AddWithValue("@Email", email);

                // Handle Password (required)
                command.Parameters.AddWithValue("@Password", password);

                // Output parameter for the new Customer ID
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

        public static bool IsCustomerExist(int customerID, string email, string phone)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsCustomerExist", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    connection.Open();

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        isFound = reader.HasRows;
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }

                    return isFound;
                }
            }
        }
        public static DataTable GetListOfCustomers()
        {
            DataTable dtCustomers = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetListOfCustomers", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtCustomers.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (log it, etc.)
                    }
                }
            }
            return dtCustomers;
        }

        public static List<CustomerDTO> GetListOfCustomersDTOs()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetListOfCustomers", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle nullable fields
                            string secondName = reader.IsDBNull(reader.GetOrdinal("Second_name"))
                                ? "" : reader.GetString(reader.GetOrdinal("Second_name"));

                            string thirdName = reader.IsDBNull(reader.GetOrdinal("Third_name"))
                                ? "" : reader.GetString(reader.GetOrdinal("Third_name"));

                            CustomerDTO customer = new CustomerDTO(
                                reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                reader.GetString(reader.GetOrdinal("First_name")),
                                secondName,
                                thirdName,
                                reader.GetString(reader.GetOrdinal("Last_name")),
                                reader.GetString(reader.GetOrdinal("Phone")),
                                reader.GetString(reader.GetOrdinal("Email")),
                                reader.GetString(reader.GetOrdinal("Password"))
                            );
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;
        }

        


        public static bool DeleteCustomer(int customerID)
        {
            int rowsAffected = -1;
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_DeleteCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }

                return (rowsAffected > 0);
            }
        }
        public static CustomerDTO FindCustomerByID(int CustomerId)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindCustomerByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Handle nullable fields
                            var SecondNameOrdinal = reader.GetOrdinal("Second_name");
                            string SecondName = reader.IsDBNull(SecondNameOrdinal) ? "" : reader.GetString(SecondNameOrdinal);

                            var ThirdNameOrdinal = reader.GetOrdinal("Third_name");
                            string ThirdName = reader.IsDBNull(ThirdNameOrdinal) ? "" : reader.GetString(ThirdNameOrdinal);

                            return new CustomerDTO(
                                reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                reader.GetString(reader.GetOrdinal("First_name")),
                                SecondName,
                                ThirdName,
                                reader.GetString(reader.GetOrdinal("Last_name")),
                                reader.GetString(reader.GetOrdinal("Phone")),
                                reader.GetString(reader.GetOrdinal("Email")),
                                reader.GetString(reader.GetOrdinal("Password"))
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static DataTable GetCustomerPurchaseHistory(int customerID)
        {
            DataTable dtPurchaseHistory = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetCustomerPurchaseHistory", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtPurchaseHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (log it, etc.)
                    }
                }
            }
            return dtPurchaseHistory;
        }

        public static DataTable GetRatingHistory(int customerID)
        {
            DataTable dtRatingHistory = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_RatingHistory", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtRatingHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (log it, etc.)
                    }
                }
            }
            return dtRatingHistory;
        }
        public static bool UpdateCustomer(int customerID, string firstName, string secondName, string thirdName, string lastName,
    string phone, string email, string password)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add Customer ID parameter
                command.Parameters.AddWithValue("@CustomerID", customerID);

                // Add First Name parameter
                command.Parameters.AddWithValue("@First_name", firstName);

                // Handle Second Name (nullable)
                if (string.IsNullOrEmpty(secondName))
                {
                    command.Parameters.AddWithValue("@Second_name", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Second_name", secondName);
                }

                // Handle Third Name (nullable)
                if (string.IsNullOrEmpty(thirdName))
                {
                    command.Parameters.AddWithValue("@Third_name", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Third_name", thirdName);
                }

                // Add Last Name parameter
                command.Parameters.AddWithValue("@Last_name", lastName);

                // Add Phone parameter
                command.Parameters.AddWithValue("@Phone", phone);

                // Add Email parameter
                command.Parameters.AddWithValue("@Email", email);

                // Add Password parameter
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }

    }
}
