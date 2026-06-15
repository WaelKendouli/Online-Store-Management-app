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
    public class clsProductsDA
    {
        public static int AddNewProduct(string name, string description, decimal price, int quantity , int CategoryID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Handle Name (required)
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Product name is required", nameof(name));
                }
                command.Parameters.AddWithValue("@Name", name);

                // Handle Description (nullable - based on nvarchar(400))
                if (string.IsNullOrEmpty(description))
                {
                    command.Parameters.AddWithValue("@Description", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Description", description);
                }

                command.Parameters.AddWithValue("@CategoryID", CategoryID);

                // Handle price (required)
                command.Parameters.AddWithValue("@price", price);

                // Handle quantity (required)
                command.Parameters.AddWithValue("@quantity", quantity);

                // Output parameter for the new Product ID
                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                // Execute the stored procedure
                connection.Open();
                command.ExecuteNonQuery();

                // Return the newly generated Product ID
                return (int)outputIdParam.Value;
            }
        }

        public static bool UpdateProduct(int productID, string name, string description, decimal price, int quantity,int CategoryID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add Product ID parameter
                command.Parameters.AddWithValue("@ID", productID);

                // Add Name parameter (required)
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Product name is required", nameof(name));
                }
                command.Parameters.AddWithValue("@Name", name);

                // Handle Description (nullable)
                if (string.IsNullOrEmpty(description))
                {
                    command.Parameters.AddWithValue("@Description", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Description", description);
                }

                // Add price parameter
                command.Parameters.AddWithValue("@price", price);

                // Add quantity parameter
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }
        public static DataTable GetAllProducts()
        {
            DataTable dtProducts = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllProducts", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtProducts.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (log it, etc.)
                    }
                }
            }
            return dtProducts;
        }


        public static ProductDTO FindProductByID(int ProductId)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindProductByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", ProductId);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Handle nullable Description field
                            var DescriptionOrdinal = reader.GetOrdinal("Description");
                            string Description = reader.IsDBNull(DescriptionOrdinal) ? "" : reader.GetString(DescriptionOrdinal);

                            return new ProductDTO(
                                reader.GetInt32(reader.GetOrdinal("ProductID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                Description,
                                reader.GetDecimal(reader.GetOrdinal("price")),
                                reader.GetInt32(reader.GetOrdinal("quantity")),
                                 reader.GetInt32(reader.GetOrdinal("CategoryID"))
                            );
                        }
                    }
                }
            }
            return null;
        }

        public static async Task<Dictionary<string, int>> GetListOfCategoriesAsync()
        {
            Dictionary<string, int> DicCategories = new Dictionary<string, int>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetListOfCategories", conx))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                await conx.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string categoryName = reader.GetString(reader.GetOrdinal("Category_Name"));
                        int categoryID = reader.GetInt32(reader.GetOrdinal("CategoryID"));

                        if (!DicCategories.ContainsKey(categoryName))
                        {
                            DicCategories.Add(categoryName, categoryID);
                        }
                    }
                }
            }
            return DicCategories;
        }

        public static List<ProductDTO> GetAllProductsAsList()
        {
            List<ProductDTO> products = new List<ProductDTO>();

            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetAllProducts", conx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conx.Open();

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductDTO product = new ProductDTO
                            {
                                product_ID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description")),
                                price = reader.GetDecimal(reader.GetOrdinal("price")),
                                quantity = reader.GetInt32(reader.GetOrdinal("quantity")),
                                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID"))
                            };
                            products.Add(product);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, etc.)
                    return null; // Return empty list on error
                }
            }

            return products;
        }


        public static async Task<bool> InsertImagesOfProduct(List<string>ImagesPathsList , int ProductID)
        {
            try
            {
                using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_AddImagesPathsForProduct", conx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        var Img = cmd.Parameters.Add("@ImagesPath", SqlDbType.NVarChar);
                        await conx.OpenAsync();
                        foreach (string path in ImagesPathsList)
                        {
                            Img.Value = path;
                            await cmd.ExecuteNonQueryAsync();
                           
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public static async Task<List<string>> GetListOfImagesPerProducts(int ProductID)
        {
            List<string> liImages = new List<string>();
            try
            {
                using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetImagesListForProduct", conx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                       await conx.OpenAsync();
                        using (SqlDataReader rd = await cmd.ExecuteReaderAsync())
                        {
                            while (rd.Read())
                            {
                                liImages.Add(rd.GetString(rd.GetOrdinal("Image_Path")));
                            }
                        }
                    }

                }
                return  liImages;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static bool DeleteProduct(int productID)
        {
            int rowsAffected = -1;
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_DeleteProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", productID);

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

        public static ProductDTO FindProductByName(string Name)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindProductByName", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", Name);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Handle nullable Description field
                            var DescriptionOrdinal = reader.GetOrdinal("Description");
                            string Description = reader.IsDBNull(DescriptionOrdinal) ? "" : reader.GetString(DescriptionOrdinal);

                            return new ProductDTO(
                                reader.GetInt32(reader.GetOrdinal("ProductID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                Description,
                                reader.GetDecimal(reader.GetOrdinal("price")),
                                reader.GetInt32(reader.GetOrdinal("quantity")),
                                reader.GetInt32(reader.GetOrdinal("CategoryID"))
                            );
                        }
                    }
                }
            }
            return null;
        }


        public static async Task<List<string>> GetListOfProductsName(int CategoryID)
        {
            List<string> liProductNames = new List<string>();
            try
            {
                using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetListOfProductsName", conx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        await conx.OpenAsync();
                        using (SqlDataReader rd = await cmd.ExecuteReaderAsync())
                        {
                            while (rd.Read())
                            {
                                liProductNames.Add(rd.GetString(rd.GetOrdinal("Name")));
                            }
                        }
                    }
                }
                return liProductNames;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
