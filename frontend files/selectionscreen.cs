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
        private CustomerRecord record;
        private Form1 openingscreen;
        private customermanagementscreen cusmanagement = new customermanagementscreen();
        public selectionscreen()
        {
            InitializeComponent();
            record = new CustomerRecord();
            record.FormClosed += CustomerRecord_FormClosed;
              

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///Customer record button
           
            record.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customermanagementscreen customermanagementscreen = new customermanagementscreen();
            customermanagementscreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            route_determination screen = new route_determination();
            screen.Show();
           Form1.ActiveForm.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///logout button
            this.Close();
        }
        private void CustomerRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Show the selection form is closed
        }
    }
}
