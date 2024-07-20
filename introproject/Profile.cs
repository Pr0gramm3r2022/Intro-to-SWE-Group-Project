using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal abstract class Profile
    {
        public string username { get; set; }
        public string password { get; set; }
        public string Name {  get; set; }
        private List<Order> Orders { get; set; }
        public Profile(string user, string pass)
        {
            username = user;
            password = pass;
            Orders = new List<Order>();
        }

        public void CreateOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine("Order created successfully.");
        }

        public void DeleteOrder(int orderID)
        {
            var order = Orders.FirstOrDefault(o => o.OrderId == orderID);
            if (order != null)
            {
                Orders.Remove(order);
                Console.WriteLine("Order deleted successfully.");
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        public void EditOrder(int orderID, Order updatedOrder)
        {
            var order = Orders.FirstOrDefault(o => o.OrderId == orderID);
            if (order != null)
            {
                order.OrderDetails = updatedOrder.OrderDetails;
                order.OrderDate = updatedOrder.OrderDate;
                // Update other necessary fields
                Console.WriteLine("Order updated successfully.");
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        public void ViewOrders()
        {
            if (Orders.Count > 0)
            {
                foreach (var order in Orders)
                {
                    Console.WriteLine($"Order ID: {order.OrderId}, Details: {order.OrderDetails}, Date: {order.OrderDate}");
                }
            }
            else
            {
                Console.WriteLine("No orders found.");
            }
        }
    }
}
