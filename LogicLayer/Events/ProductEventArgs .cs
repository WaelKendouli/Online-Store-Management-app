using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicLayer.Events
{
    public class ProductEventArgs : EventArgs
    {
        public int ID { get; }
        public string Name { get;  }
        public string Description { get;  }
        public decimal Price { get; }
        public int Quantity { get;  }
        public int CategoryID { get; }

        public List<string> LiPhotosPaths { get; } = new List<string>();

        public ProductEventArgs(string name, string description, decimal price, int quantity , int CategoryID, List<string> LiPhotosPaths)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            this.CategoryID = CategoryID;
            this.LiPhotosPaths = LiPhotosPaths;
        }

        public ProductEventArgs(int Id,string name, string description, decimal price, int quantity, int CategoryID, List<string> LiPhotosPaths)
        {
            ID = Id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            this.CategoryID = CategoryID;
            this.LiPhotosPaths = LiPhotosPaths;
        }

    }
}
