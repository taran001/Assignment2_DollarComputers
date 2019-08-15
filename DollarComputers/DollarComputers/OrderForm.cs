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
    public partial class OrderForm : Form
    {
        private Product P;

        public OrderForm()
        {
            InitializeComponent();
            
        }

        public OrderForm(Product P)
        {
            InitializeComponent();
            this.P = P;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Taranpreet Singh \n ver. 0.0.1 \n www.dollarscomputer.com \n +1(31) 11 3122 42 ");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextBox.Text = P.Condition;
            PlatformTextBox.Text = P.Platform;
            ManufacTextBox.Text = P.Manufac;
            ModelTextBox.Text = P.Model;

            SpecsListBox.Items.Clear();
            SpecsListBox.Items.Add(P.Lcd);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.Memory);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.CpuBrand);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.CpuType);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.CpuNumber);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.CpuSpeed);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.Hdd);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.GpuType);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.Webcam);
            SpecsListBox.Items.Add("");
            SpecsListBox.Items.Add(P.OS);
            

            // Calculating Sales Tax 13 % and Total
            PriceTextBox.Text = P.Cost.ToString() ;
            SalesTaxTextBox.Text = ((P.Cost / 100) * 13).ToString();
            TotalTextBox.Text = (((P.Cost / 100) * 13) + P.Cost).ToString();

            int randomImage = new Random().Next(1, 4);
            ProductImageBox.Load(@"" + randomImage + ".jpg");
            

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selection is printing...");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm PF = new ProductInfoForm(P);
            PF.Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Thanks for doing bussiness with us \n your order will be placed in 7/ 10 days...", "Thank You !",MessageBoxButtons.OKCancel);
            if(R == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
