using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introproject
{
    internal class Glass : Item
    {
        public Glass(double p, int a, string name) : base(p, a)
        {
            price = p;
            amount = a;
            Name = name;
        }
    }
}
