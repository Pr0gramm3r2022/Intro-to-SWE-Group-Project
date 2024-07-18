using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal class Sales_Rep : Profile
    {
        public List<Customer> customers = new List<Customer>();

        public Sales_Rep(string user, string pass) : base(user, pass) 
        {
            username = user;
            password = pass;
        }

        public void AddCustomer()
        {
            try
            {
                Console.Write("Enter customer ID: ");
                int input = Int32.Parse(Console.ReadLine());
                foreach (Customer customer in customers) 
                {
                    if(input != customer.ID)
                    {
                        customers.Add(customer);
                    }
                    else
                    {
                        Console.WriteLine("Customer already exists.");
                    }
                }

            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }           
        }
        public void RemoveCustomer()
        {
            try
            {
                Console.Write("Enter customer ID: ");
                int input = Int32.Parse(Console.ReadLine());
                foreach (Customer customer in customers)
                {
                    if (input == customer.ID)
                    {
                        customers.Remove(customer);
                    }
                    else
                    {
                        Console.WriteLine("Customer not found.");
                    }
                }
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SaveCustomers()
        {
            StreamWriter save = null;

            try
            {
                string path = "C:\\Users\\uzowi\\source\\repos\\Profile-SalesRep-Customer\\ListofCustomers\\";

                using (save = new StreamWriter(path)) 
                {
                    foreach (Customer c in customers)
                    {
                        save.WriteLine($"{c.ID}, {c.Name}");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong. {e.Message}");
            }
        }
        

        public void LoadCustomers()
        {
            
        }


    }
}
