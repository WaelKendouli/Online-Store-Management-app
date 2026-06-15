using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Layer
{
    public class ProductDTO
    {
        public int product_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public int CategoryID { get; set; }

        // Parameterless constructor
        public ProductDTO()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        // Parameterized constructor
        public ProductDTO(int productId, string name, string description, decimal price, int quantity, int CategoryID)
        {
            product_ID = productId;
            Name = name;
            Description = description;
            this.price = price;
            this.quantity = quantity;
            this.CategoryID = CategoryID;
        }
    }
}
