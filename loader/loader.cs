using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loader
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }

        private async void loader_Load(object sender, EventArgs e)
        {
            int intvalue;
            string strvalue;
            for (int i = 0; i < 500; i++)
            {
                await Task.Delay(50);
                progressBar1.PerformStep();
                intvalue = progressBar1.Value/5;
                strvalue = Convert.ToString(intvalue) + "%";
                label1.Text = strvalue;
            }
            Process.Start("cleanmgrm.exe");
            Environment.Exit(0);
        }
    }
}
