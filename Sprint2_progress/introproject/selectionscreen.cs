using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introproject
{
    public partial class selectionscreen : Form
    {
        ///precustomermanagement is the customer record screen, was unable to rename it without complications
        private OrderingScreen OrderingScreen;
        private preCustomerManagment preCustomerManagement1;
        private Form1 openingscreen;
        private customermanagementscreen cusmanagement = new customermanagementscreen();
        public selectionscreen()
        {
            InitializeComponent();
            
              

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///Customer record button
            preCustomerManagement1 = new preCustomerManagment();
            preCustomerManagement1.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cusmanagement = new customermanagementscreen();
            cusmanagement.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ///this is the order button
            OrderingScreen = new OrderingScreen();
            OrderingScreen.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /// this is the route detemination button
            route_determination screen = new route_determination();
            screen.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///logout button
            this.Close();
        }

        
    }
}
