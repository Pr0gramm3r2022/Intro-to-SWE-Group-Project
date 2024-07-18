using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal class InvalidLoginException : Exception
    {
        public InvalidLoginException(string message) : base(message) { }
    }
}
