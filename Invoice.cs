using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck___Invoice_Classes
{
    internal abstract class Invoice
    {
        protected string companyName;
        protected string address;
        protected int invoiceNum;
        protected string faxNum;
        protected string product;
        protected string recepient;
        protected string description;

        protected Invoice(string name, string addy, int num, string p, string r) 
        {
            companyName = name;
            address = addy;
            invoiceNum = num;
            product = p;
            recepient = r;
        }

        protected void setFax(int num)
        {
            try
            {
                string sampleString = Convert.ToString(num);
                string s1;

            }
            catch
            {

            }
        }
    }
}
