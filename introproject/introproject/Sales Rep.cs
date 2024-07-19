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

        public Sales_Rep(string user, string pass, string name) : base(user, pass) 
        {
            username = user;
            password = pass;
            Name = name;
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
            string path = "C:\\Users\\uzowi\\source\\repos\\Profile-SalesRep-Customer\\ListofCustomers\\";

            try
            {
                

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
            StreamReader load = null;
            string path = "C:\\Users\\uzowi\\source\\repos\\Profile-SalesRep-Customer\\ListofCustomers\\";

            try
            {
                if (File.Exists(path))
                {
                    using (load = new StreamReader(path))
                    {
                        string loadFile;
                        customers.Clear();

                        while ((loadFile = load.ReadLine()) != null)
                        {
                            var content = loadFile.Split(',');

                            if (content.Length == 4)
                            {
                                customers.Add(new Customer(content[0], content[1], Convert.ToInt32(content[2]), content[3]));
                            }
                            else
                            {
                                Console.WriteLine("File does not exist.");
                            }
                        }
                    }
                }
            }
            catch (IOException i)
            {
                Console.WriteLine($"An error occured. {i.Message}");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Something went wrong. {e.Message}");
            }
        }


    }
}
