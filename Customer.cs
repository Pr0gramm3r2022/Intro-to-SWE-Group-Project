using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal class Customer : Profile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Customer (string user, string pass, int id, string name) : base (user, pass)
        {
            username = user;
            password = pass;
            ID = id;
            Name = name;
        }

    }
}
