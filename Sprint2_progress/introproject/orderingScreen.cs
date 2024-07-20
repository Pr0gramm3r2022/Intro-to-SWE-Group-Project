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
    public partial class OrderingScreen : Form
    {
        public OrderingScreen()
        {
            InitializeComponent();
        }
        private void AcmeLego(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void orderingScreen_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ///search button for the item search
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /// data grid
        }

        private void OrderDetailText_TextChanged(object sender, EventArgs e)
        {
            ///just a label
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ///the back button
            this.Close();
        }

        private void NewOrderText_TextChanged(object sender, EventArgs e)
        {
            ///meant to be just a label
        }

        private void CustomerSelectorMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemSearchText_TextChanged(object sender, EventArgs e)
        {
            ///meant to be just a label
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ///this is the selection for products drop down
        }

        private void InventorySearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///the inventory seach box
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order submitted successfully!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
