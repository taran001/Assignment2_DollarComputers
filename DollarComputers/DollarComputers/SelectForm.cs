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
        /// <summary>
        /// Application Name : DollarComputers
        /// Author : Taranpreet Singh
        /// ID : 301044958
        /// App Creation Date : 14 / 05 / 2019
        /// </summary>
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            
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
            //Set values for the selected index of data grid view.
            string manufacturer = ProductDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string model = ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string cost = ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString();
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
            P.ProductID = int.Parse(ProductDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            P.Condition = ProductDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            P.Cost = double.Parse(ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString());
            P.Platform = ProductDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            P.OS = ProductDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            P.Manufac = ProductDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            P.Model = ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            P.Memory = ProductDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            P.Lcd = ProductDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            P.Hdd = ProductDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            P.CpuBrand = ProductDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            P.CpuNumber = ProductDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            P.GpuType = ProductDataGridView.SelectedRows[0].Cells[19].Value.ToString();
            P.CpuType = ProductDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            P.CpuSpeed = ProductDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            P.Webcam = ProductDataGridView.SelectedRows[0].Cells[30].Value.ToString();
            
            ProductInfoForm PIF = new ProductInfoForm(P);
            PIF.Show();
        }

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NextButton.Enabled = true;
            showSelectedItem();
        }
    }
}
