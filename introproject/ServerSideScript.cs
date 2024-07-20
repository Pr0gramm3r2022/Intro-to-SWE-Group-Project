using introproject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace Profile_SalesRep_Customer
{
    internal class MainScript
    {
        private static Customer Current;

        private static Sales_Rep CurrentRep;

        private static Order Order;

        static List <Customer> RegisteredCustomers(string path)
        {
            List<Customer> customers = new List<Customer>();
            

            try
            {
                using (StreamReader sr = new StreamReader(path)) 
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var customerData = line.Split(',');

                        if (customerData.Length == 4)
                        {
                            customers.Add(new Customer(customerData[0], customerData[1], Convert.ToInt32(customerData[2]), customerData[3]));
                        }
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong. " +  e.Message);
            }
            return customers;
        }
        

        static List <Sales_Rep> RegisteredSalesReps(string path)
         {
            List<Sales_Rep> reps = new List<Sales_Rep>();
            

            try
            {
                using (StreamReader streamReader = new StreamReader(path)) 
                {
                    string line;

                    while((line = streamReader.ReadLine()) != null)
                    {
                        var repData = line.Split(',');

                        if (repData.Length == 3)
                        {
                            reps.Add(new Sales_Rep(repData[0], repData[1], repData[2]));
                        }
                    }
                }

            }
            catch (Exception e) 
            {
                Console.WriteLine("Something went wrong. " + e.Message);
            }
            return reps;
         }
         

        static void CustomerLogin()
        {
            Current = null;

            List<Customer> list = RegisteredCustomers("ListOfCustomers.txt");

            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            foreach (Customer customer in list)
            {
                if (user != customer.username || pass != customer.password)
                {
                    throw new InvalidLoginException("Incorrect username or password!");
                }
                else if (user == customer.username && pass == customer.password)
                {
                    Current = customer;
                    break;
                }
            }
        }

        static void CustomerLogout() 
        {
            if (Current != null) 
            {
                Current = null;
                Console.WriteLine($"{Current.Name} has logged out.");
            }
            else
            {
                Console.WriteLine("No one is logged in.");
            }

        }

        static void SalesLogin()
        {
            CurrentRep = null;

            List<Sales_Rep> sales_Reps = RegisteredSalesReps("ListOfSalesReps.txt");
            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            foreach (Sales_Rep rep in sales_Reps)
            {
                if (user != rep.username || pass != rep.password)
                {
                    throw new InvalidLoginException("Incorrect username or password!");
                }
                else if(user == rep.username && pass == rep.password)
                {
                    CurrentRep = rep;
                    break;
                }
            }
        }

        static void SalesLogout()
        {
            if(CurrentRep != null)
            {
                CurrentRep = null;
                Console.WriteLine($"{CurrentRep.Name} has logged out.");
            }
            else
            {
                Console.WriteLine("No one is logged in.");
            }
        }

        public Order GenerateOrder()
        {
            Random rnd = new Random();
            int id = rnd.Next(0, 1000);
            bool done = false;
            List<Item> products = new List<Item>();
            while (!done)
            {
                Console.WriteLine("Select items below \n" +
                "1) Glass $2.50 \n" +
                "2) Can $1.75 \n" +
                "3) Pony Keg $4.50 \n" +
                "4) Keg $6.50 \n" +
                "5) Quit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Glass glass = new Glass(2.50, 1, "Glass of Anheuser-Busch");
                        products.Add(glass);
                    break;

                    case 2:
                        Cans can = new Cans(1.75, 1, "Can of Anheuser-Busch");
                        products.Add(can);
                    break;

                    case 3:
                        PonyKeg ponyKeg = new PonyKeg(4.50, 1, "Pony Keg of Anheuser-Busch");
                        products.Add(ponyKeg);
                    break;

                    case 4:
                        Keg keg = new Keg(6.50, 1, "Keg of Anheuser-Busch");
                        products.Add(keg);
                    break;

                    case 5:
                        done = true;
                    break;
                }
            }

            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Enter the address: ");
            
            string address = Console.ReadLine();

            Console.WriteLine("Enter the name of the recipient: ");

            string recipient = Console.ReadLine();

            string orderDetails = $"Address: {address} \n Recipient: {recipient} \n Products: {products}";

            Order = new Order(id, orderDetails, dateTime, products); 

            return Order;
        }

        static void ServerSideScript(string[] args)
        {
            
        }
    }
    

}
