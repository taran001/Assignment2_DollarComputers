using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        private Product P;

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        public ProductInfoForm(Product P)
        {
            InitializeComponent();
            this.P = P;

        }
        
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

            if (P != null)
            {
                this.ProductIdTextBox.Text = P.ProductID.ToString();
                this.ConditionTextBox.Text = P.Condition;
                this.CostTextBox.Text = P.Cost.ToString();
                this.PlatformTextBox.Text = P.Platform;
                this.OsTextBox.Text = P.OS;
                this.ManufacTextBox.Text = P.Manufac;
                this.ModelTextBox.Text = P.Model;
                this.MemoryTextBox.Text = P.Memory;
                this.LcdTextBox.Text = P.Lcd;
                this.hddTextBox.Text = P.Hdd;
                this.CpuBrandTextBox.Text = P.CpuBrand;
                this.CpuNumberTextBox.Text = P.CpuNumber;
                this.GpuTypeTextBox.Text = P.GpuType;
                this.CpuTypeTextBox.Text = P.CpuType;
                this.CpuSpeedTextBox.Text = P.CpuSpeed;
                this.WebcamTextBox.Text = P.Webcam;
                NextButton.Enabled = true;
            }
      }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the file.
            DialogResult responseDialogResult;
            // Begin in the project folder.
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Text Files | *.txt";
            // Display the File Open dialog box.
            responseDialogResult = openFileDialog1.ShowDialog();
            if (responseDialogResult != DialogResult.Cancel)
            { // User didn’t click the Cancel button.
              // Open the output file.
                try
                {
                    // Read entire file into a single string.
                    string
                    fileString = File.ReadAllText(openFileDialog1.FileName);
                    // Split the string into individual fields of a string array.
                    string[] values = fileString.Split('\n');
                    // Display the array in a list box.
                    ProductIdTextBox.Text = values[0];
                    ConditionTextBox.Text = values[1];
                    CostTextBox.Text = values[2];
                    PlatformTextBox.Text = values[3];
                    OsTextBox.Text = values[4];
                    ManufacTextBox.Text = values[5];
                    ModelTextBox.Text = values[6];
                    MemoryTextBox.Text = values[7];
                    LcdTextBox.Text = values[8];
                    hddTextBox.Text = values[9];
                    CpuBrandTextBox.Text = values[10];
                    CpuNumberTextBox.Text = values[11];
                    GpuTypeTextBox.Text = values[12];
                    CpuTypeTextBox.Text = values[13];
                    CpuSpeedTextBox.Text = values[14];
                    WebcamTextBox.Text = values[15];

                    NextButton.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("File or path not found or invalid.");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.FileName = "Product.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter S = new StreamWriter(saveFileDialog1.FileName))
                {
                    S.WriteLine(ProductIdTextBox.Text);
                    S.WriteLine(ConditionTextBox.Text);
                    S.WriteLine(CostTextBox.Text);
                    S.WriteLine(PlatformTextBox.Text);
                    S.WriteLine(OsTextBox.Text);
                    S.WriteLine(ManufacTextBox.Text);
                    S.WriteLine(ModelTextBox.Text);
                    S.WriteLine(MemoryTextBox.Text);
                    S.WriteLine(LcdTextBox.Text);
                    S.WriteLine(hddTextBox.Text);
                    S.WriteLine(CpuBrandTextBox.Text);
                    S.WriteLine(CpuNumberTextBox.Text);
                    S.WriteLine(GpuTypeTextBox.Text);
                    S.WriteLine(CpuTypeTextBox.Text);
                    S.WriteLine(CpuSpeedTextBox.Text);
                    S.WriteLine(WebcamTextBox.Text);

                }
            }
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm SF = new SelectForm();
            SF.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            P.ProductID= int.Parse(this.ProductIdTextBox.Text );
            P.Condition =this.ConditionTextBox.Text ;
            P.Cost = double.Parse(this.CostTextBox.Text);
            P.Platform = this.PlatformTextBox.Text ;
            P.OS = this.OsTextBox.Text;
            P.Manufac = this.ManufacTextBox.Text;
            P.Model = this.ModelTextBox.Text;
            P.Memory = this.MemoryTextBox.Text;
            P.Lcd = this.LcdTextBox.Text;
            P.Hdd = this.hddTextBox.Text;
            P.CpuBrand = this.CpuBrandTextBox.Text;
            P.CpuNumber = this.CpuNumberTextBox.Text;
            P.GpuType = this.GpuTypeTextBox.Text;
            P.CpuType = this.CpuTypeTextBox.Text;
            P.CpuSpeed = this.CpuSpeedTextBox.Text;
            P.Webcam = this.WebcamTextBox.Text;

            this.Hide();
            OrderForm O = new OrderForm(P);
            O.Show();
        }
    }
}
