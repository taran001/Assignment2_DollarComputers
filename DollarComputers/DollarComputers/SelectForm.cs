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

        private void NextButton_Click(object sender, EventArgs e)
        {
            //TODO : Make this instance in Program.cs
            //TODO  : Make this code efficient
            this.Hide();
            Product P = new Product();
            P.ProductID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            P.Condition = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            P.Cost = double.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            P.Platform = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            P.OS = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            P.Manufac = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            P.Model = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            P.Memory = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            P.Lcd = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            P.Hdd = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            P.CpuBrand = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            P.CpuNumber = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            P.GpuType = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
            P.CpuType = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            P.CpuSpeed = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            P.Webcam = dataGridView1.SelectedRows[0].Cells[30].Value.ToString();
            
            ProductInfoForm PIF = new ProductInfoForm(P);
            PIF.Show();
        }
    }
}
