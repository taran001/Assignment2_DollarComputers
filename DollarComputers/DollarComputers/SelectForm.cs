using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //TODO : rename datagridview
            //TODO :Improve the design

            NextButton.Enabled = false;
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NextButton.Enabled = true;
            showSelectedItem();
        }

        private void showSelectedItem()
        {
            string manufacturer = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string model = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string cost = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SelectionTextBox.Text = manufacturer + " " + model + " Priced At: $" + double.Parse(cost).ToString("N"); 

        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
