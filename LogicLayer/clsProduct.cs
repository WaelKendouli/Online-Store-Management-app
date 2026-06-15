using DataAccessLayer;
using DTO_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.Events;
using System.Runtime.CompilerServices;
namespace LogicLayer
{
    public class clsProduct
    {
        enum Mode
        {
            eAddNew = 1,
            eUpdate = 2
        }

        Mode _Mode = Mode.eAddNew;
        public ProductDTO DTO = null;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }

        public List<string> ListOfImagesPaths = new List<string>();

        // Private constructor for existing product (Update mode)
        private clsProduct(int productId, string name, string description, decimal price, int quantity,int CategoryID)
        {
            DTO = new ProductDTO(productId, name, description, price, quantity , CategoryID);
            _Mode = Mode.eUpdate;
            ProductID = productId;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            this.CategoryID = CategoryID;
        }

        // Public constructor for new product (Add mode)
        public clsProduct(string name, string description, decimal price, int quantity, int CategoryID)
        {
            _Mode = Mode.eAddNew;
            DTO = new ProductDTO(this.ProductID, name, description, price, quantity,CategoryID);
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            this.CategoryID = CategoryID;
        }

        public clsProduct()
        {
            _Mode = Mode.eAddNew;
            DTO = new ProductDTO();
           
        }

        private async Task InitializeImageListAsync()
        {
            this.ListOfImagesPaths = await clsProductsDA.GetListOfImagesPerProducts(this.ProductID);
        }

        public static async Task<List<string>> GetListOfProductsName(int CategoryID)
        {
            return await clsProductsDA.GetListOfProductsName(CategoryID);
        }

        private bool AddNewProduct(string name, string description, decimal price, int quantity, int CategoryID)
        {
            int newID = clsProductsDA.AddNewProduct(name, description, price, quantity, CategoryID);
            if (newID > 0)
            {
                this.ProductID = newID;
                return true;
            }
            return false;
        }

        private bool UpdateProduct(int productID, string name, string description, decimal price, int quantity,int CategoryID)
        {
            return clsProductsDA.UpdateProduct(productID, name, description, price, quantity, CategoryID);
        }

        public static DataTable GetAllProducts()
        {
            return clsProductsDA.GetAllProducts();
        }

        public static List<ProductDTO> GetAllProductsAsList()
        {
            return clsProductsDA.GetAllProductsAsList();
        }

        public static async Task<clsProduct> FindProductByID(int productID)
        {
            ProductDTO DTO = clsProductsDA.FindProductByID(productID);
            if (DTO == null)
            {
                return null;
            }
            clsProduct NewProduct = new clsProduct(DTO.product_ID, DTO.Name, DTO.Description,
                DTO.price, DTO.quantity, DTO.CategoryID);
         await   NewProduct.InitializeImageListAsync();
            return NewProduct;
        }

        public static async Task<Dictionary<string, int>> GetListOfCategoriesAsync()
        {
            return await clsProductsDA.GetListOfCategoriesAsync(); 
        }

        public static async Task< clsProduct> FindProductByName(string Name)
        {
            ProductDTO DTO = clsProductsDA.FindProductByName(Name);
            if (DTO == null)
            {
                return null;
            }
            clsProduct NewProduct = new clsProduct(DTO.product_ID, DTO.Name, DTO.Description,
                DTO.price, DTO.quantity, DTO.CategoryID);
            await NewProduct.InitializeImageListAsync();
            return NewProduct;
        }


        public static bool DeleteProduct(int productID)
        {
            return clsProductsDA.DeleteProduct(productID);
        }

        public static async Task<bool> InsertImagesOfProduct(List<string> ImagesPathsList, int ProductID)
        {
            return await clsProductsDA.InsertImagesOfProduct(ImagesPathsList, ProductID);
        }
        public static async Task<List<string>> GetListOfImagesPerProducts(int ProductID)
        {
            return await clsProductsDA.GetListOfImagesPerProducts(ProductID);
        }

        public void EditAttributes(ProductEventArgs e)
        {
           
            this.Name = e.Name;
            this.Description = e.Description;
            this.Price = e.Price;
            this.Quantity = e.Quantity;
            this.CategoryID = e.CategoryID;
            this.ListOfImagesPaths = e.LiPhotosPaths;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.eAddNew:
                    if (AddNewProduct(this.Name, this.Description, this.Price, this.Quantity,this.CategoryID))
                    {
                        _Mode = Mode.eUpdate;
                        return true;
                    }
                    break;

                case Mode.eUpdate:
                    return UpdateProduct(this.ProductID, this.Name, this.Description, this.Price, this.Quantity,this.CategoryID);
            }
            return false;
        }
    }
}
