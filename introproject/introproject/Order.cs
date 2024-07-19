using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal class Order
    {
        public string Type { get; set; }
        public int ID {  get; set; }
        public string Address { get; set; }
        public string Recipient {  get; set; }

        List <Order> orders = new List <Order> ();
        public Order(string type, int id, string addy, string r)
        {
            Type = type;
            ID = id;
            Address = addy;
            Recipient = r;
        }



    }
}
