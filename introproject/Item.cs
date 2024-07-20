using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introproject
{
    internal abstract class Item
    {
        public string Name {  get; set; }
        public double price {  get; set; }
        public int amount { get; set; }
        public double totalCost;
        public Item(double p, int a)
        {
            price = p;
            amount = a;
        }

        public double FindTotalCost(double price, int amount)
        {
            totalCost = price * amount;

            return totalCost;
        }
    }
}
