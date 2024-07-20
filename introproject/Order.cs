using introproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }

        public List<Item> contents;
        public Order(int orderId, string orderDetails, DateTime orderDate, List<Item> items)
        {
            OrderId = orderId;
            OrderDetails = orderDetails;
            OrderDate = orderDate;
            contents = items;
        }
    }
}
