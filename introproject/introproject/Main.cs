using System.Transactions;

namespace Profile_SalesRep_Customer
{
    internal class Main
    {
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
        static void CustomerLogin()
        {
            Customer login = null;

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
                    login = customer;
                }
            }
        }

        static void CustomerLogout() 
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
