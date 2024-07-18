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
    public partial class Form1 : Form
    {
        private loginscreen loginscreen1;
        public Form1()
        {
            InitializeComponent();
            loginscreen1 = new loginscreen();
            loginscreen1.FormClosed += Loginscreen_FormClosed;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ///this is the login button

            loginscreen1.Show();

            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Loginscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
