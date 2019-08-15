using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        /// <summary>
        /// Application Name : DollarComputers
        /// Author : Taranpreet Singh
        /// ID : 301044958
        /// App Creation Date : 14 / 05 / 2019
        /// </summary>
        public StartForm()
        {
            Thread T = new Thread(new ThreadStart(StartSplash));
            T.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            T.Abort();
            

        }

        private void StartSplash()
        {
            Application.Run(new SplashScreen());    
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm SF = new SelectForm();
            SF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm PIF = new ProductInfoForm();
            PIF.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
