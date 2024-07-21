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
    public partial class NewCustomerScreen : Form
    {
        private Dictionary<string, string> authorizedUsers;
        public NewCustomerScreen(Dictionary<string, string> users)
        {
            InitializeComponent();
            this.authorizedUsers = users;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string Address = AddressBox.Text;
            string PhoneNumber = PhoneNumberBox.Text;

            string username = $"{lastName} , {firstName}";
            if (authorizedUsers.ContainsKey(username))
            {
                MessageBox.Show("Customer already exists.");
            }
            else
            {
                authorizedUsers.Add(lastName, firstName);
            }
            FirstNameBox.Clear();
            LastNameBox.Clear();
            AddressBox.Clear();
            PhoneNumberBox.Clear();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            HomeScreen backHome = new HomeScreen(authorizedUsers);
            backHome.Show();
            this.Hide();
        }
    }
}
