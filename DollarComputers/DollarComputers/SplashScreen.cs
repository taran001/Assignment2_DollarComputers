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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            //TODO: Add Icon
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);

        }
    }
}
