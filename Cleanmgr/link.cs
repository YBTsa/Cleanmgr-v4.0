using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleanmgr
{
    public partial class link : Form
    {
        public link()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.hide_link = true;
                Properties.Settings.Default.Save();
                if (checkBox2.Checked)
                {
                    Process.Start("explorer.exe", "https://youngbat.us.kg/cleanmgr");
                }
                cleanmgrm cmgr1 = new cleanmgrm();
                this.Close();
                cmgr1.Activate();
            }
            else
            {
                if (checkBox2.Checked)
                {
                    Process.Start("explorer.exe", "https://youngbat.us.kg/cleanmgr");
                }
                cleanmgrm cmgr = new cleanmgrm();
                this.Close();
                cmgr.Activate();
            }
        }
    }
}
