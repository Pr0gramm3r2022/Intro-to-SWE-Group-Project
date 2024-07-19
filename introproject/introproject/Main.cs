using System.Transactions;

namespace Profile_SalesRep_Customer
{
    internal class Main
    {
        private static Customer Current;

        private static Sales_Rep CurrentRep;

        /*static List <Customer> RegisteredCustomers(string path)
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                using (StreamReader sr = new StreamReader(path)) 
                {
                    string current;


                }

            }
            catch
            {

            }
        }
        */

        /*static List <Sales_Rep> RegisteredSalesReps(string path)
         {
            List<Sales_Rep> reps = new List<Sales_Rep>();

         }
         */

        static void CustomerLogin()
        {
            Current = null;

            List<Customer> list = new List<Customer>();

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
            
            List<Sales_Rep> sales_Reps = new List<Sales_Rep>();
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
