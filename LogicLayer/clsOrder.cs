using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class clsOrder
    {
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
        }

        // Parameterized constructor
        public clsOrder(int orderId, DateTime orderDate, TimeSpan orderTime,
                     int quantity, decimal amount, int customerId,
                     int productId, int orderStatusId)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            OrderTime = orderTime;
            Quantity = quantity;
            Amount = amount;
            CustomerId = customerId;
            ProductId = productId;
            OrderStatusId = orderStatusId;
        }

        // Override ToString() for easy display
        public override string ToString()
        {
            return $"Order ID: {OrderId}, Date: {OrderDate.ToShortDateString()}, " +
                   $"Time: {OrderTime}, Quantity: {Quantity}, Amount: {Amount:C}, " +
                   $"Customer ID: {CustomerId}, Product ID: {ProductId}, " +
                   $"Status ID: {OrderStatusId}";
        }
    }
}
