using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck___Invoice_Classes
{
    internal abstract class Truck
    {
        protected int truckNum;
        protected string truckType;
        protected string deliveryType;

        protected Truck(int n, string t, string d) 
        {
            truckNum = n;
            truckType = t;
            deliveryType = d;
        }
    }
}
