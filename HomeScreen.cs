using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Final_Project
{
    public partial class HomeScreen : Form
    {
        private Dictionary<string, string> authorizedUsers;
        public HomeScreen(Dictionary<string, string> users)
        {
            InitializeComponent();
            authorizedUsers = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderScreen order = new OrderScreen(authorizedUsers);
            order.Show();
            this.Hide();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            NewCustomerScreen newCustomer = new NewCustomerScreen(authorizedUsers);
            newCustomer.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
