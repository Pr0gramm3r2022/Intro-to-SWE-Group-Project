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

        public Profile(string user, string pass)
        {
            username = user;
            password = pass;
        }

        public void CreateOrder()
        {

        }

        public void DeleteOrder()
        {

        }

        public void EditOrder()
        {

        }

        public void ViewOrders()
        {

        }
    }
}
