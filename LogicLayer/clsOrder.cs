using DataAccessLayer;
using DTO_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class clsOrder
    {
        enum enMode { eAdd , eUpdate }

        enMode _Mode = enMode.eAdd;
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int OrderStatusId { get; set; }

        // Default constructor
        public clsOrder()
        {
            _Mode = enMode.eAdd;
        }
        public clsOrder( DateTime orderDate, TimeSpan orderTime,
                    int quantity, decimal amount, int customerId,
                    int productId, int orderStatusId)
        {
            _Mode = enMode.eAdd;
            OrderDate = orderDate;
            OrderTime = orderTime;
            Quantity = quantity;
            Amount = amount;
            CustomerId = customerId;
            ProductId = productId;
            OrderStatusId = orderStatusId;
        }
        // Parameterized constructor
        private clsOrder(int orderId, DateTime orderDate, TimeSpan orderTime,
                     int quantity, decimal amount, int customerId,
                     int productId, int orderStatusId)
        {
            _Mode = enMode.eUpdate;
            OrderId = orderId;
            OrderDate = orderDate;
            OrderTime = orderTime;
            Quantity = quantity;
            Amount = amount;
            CustomerId = customerId;
            ProductId = productId;
            OrderStatusId = orderStatusId;
        }
        private bool Insert()
        {
            this.OrderId = clsOrdersDA.InsertOrder(this.OrderDate, this.OrderTime, this.Quantity, this.Amount, this.CustomerId, this.ProductId, this.OrderStatusId);

            return this.OrderId > 0;

        }

        public static clsOrder FindOrderByID(int orderID)
        {
            OrderDTO DTO = clsOrdersDA.FindAnOrderByID(orderID);

            if (DTO == null)
            {
                return null;
            }

            return new clsOrder(DTO.OrderId, DTO.OrderDate, DTO.OrderTime,
                                DTO.Quantity, DTO.Amount, DTO.CustomerId,
                                DTO.ProductId, DTO.OrderStatusId);
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, Date: {OrderDate.ToShortDateString()}, " +
                   $"Time: {OrderTime}, Quantity: {Quantity}, Amount: {Amount:C}, " +
                   $"Customer ID: {CustomerId}, Product ID: {ProductId}, " +
                   $"Status ID: {OrderStatusId}";
        }
        private  bool UpdateOrder()
        {
            return clsOrdersDA.UpdateOrder( this.OrderId, this.OrderDate, this.OrderTime, this.Quantity, this.Amount, this.CustomerId, this.ProductId, this.OrderStatusId);        
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case  enMode.eAdd :
                    _Mode = enMode.eUpdate;
                    return Insert();
                case enMode.eUpdate:
                    return UpdateOrder();  
            }
            return false;
        }


    }
}
