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
    public partial class OrderScreen : Form
    {
        private Dictionary<string, string> authorizedUsers;
        public OrderScreen(Dictionary<string, string> users)
        {
            InitializeComponent();
            this.authorizedUsers = users;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderSubmitButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int orderID = rnd.Next(0, 1000000);
            int glassAmount = Int32.Parse(GlassQuantity.Text);
            int cansAmount = Int32.Parse(CanQuantity.Text);
            int ponyAmount = Int32.Parse(PonyKegQuantity.Text);
            int kegAmount = Int32.Parse(KegQuantity.Text);

            string CustomerName = EnterCustomerTextBox.Text;
            string Address = AddressTextBox.Text;

            int totalQuanity = glassAmount + cansAmount + ponyAmount + kegAmount;
            

            MessageBox.Show($"Total Amount: {totalQuanity} \n" +
                $"For: {CustomerName} \n" +
                $"To: {Address}");
            
            GlassQuantity.Clear();
            CanQuantity.Clear();
            PonyKegQuantity.Clear();
            KegQuantity.Clear();

            HomeScreen back = new HomeScreen(authorizedUsers);
            back.Show();
            this.Hide();
        }
    }
}
