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
    public partial class loginscreen : Form
    {
        public loginscreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///login button
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "a" && password == "p")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                selectionscreen selectionscreen = new selectionscreen();
                selectionscreen.Show();
                Form1 form = new Form1();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///back button
            this.Close();
          
        }

       
    }
}
