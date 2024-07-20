using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_SalesRep_Customer
{
    internal class Sales_Rep : Profile
    {
        public List<Customer> customers = new List<Customer>();
        string internalDatabase = "AssignedCustomer.txt";
        string customerDatabase = "ListOfCustomers.txt";
        public Sales_Rep(string user, string pass, string name) : base(user, pass) 
        {
            username = user;
            password = pass;
            Name = name;
        }

        //Copies a customer's info from the server database to internal database
        public void AddCustomer()
        {
            StreamWriter writer = null;
            StreamReader reader = null;
            
            Console.Write("Enter customer ID: ");
            int input = Int32.Parse(Console.ReadLine());

            try
            {
                using(reader = new StreamReader(customerDatabase))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        var data = line.Split(',');

                        if (data.Length == 4)
                        {
                            if (input == Convert.ToInt32(data[3])) ;
                            {
                                using (writer = new StreamWriter(internalDatabase))
                                {
                                    foreach (Customer customer in customers)
                                    {
                                        if (input == customer.ID)
                                        {
                                            writer.WriteLine($"{customer.Name}, {customer.ID}, {customer.username}");
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
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

        // Goes into internal database to remove specified customer
        public void RemoveCustomer()
        {
            Console.Write("Enter customer ID: ");
            int input = Int32.Parse(Console.ReadLine());

            try
            {
                
                StreamReader sr = null;

                try
                {
                    using (sr = new StreamReader(internalDatabase))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null) 
                        {
                            var data = line.Split(',');

                            if (data.Length == 4)
                            {
                                if (input == Convert.ToInt32(data[3]));
                                {
                                    line.Remove(0, 4);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something went wrong. {e.Message}");
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

        // Saves the Customer to the internal database
        public void SaveCustomers()
        {
            StreamWriter save = null;
            try
            {
                using (save = new StreamWriter(internalDatabase)) 
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
        
        //Loads customer info from internal database into the customer list
        public void LoadCustomers()
        {
            StreamReader load = null;
            try
            {
                if (File.Exists(internalDatabase))
                {
                    using (load = new StreamReader(internalDatabase))
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
