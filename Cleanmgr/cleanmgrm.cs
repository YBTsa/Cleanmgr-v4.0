using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleanmgr
{
    public partial class cleanmgrm : Form
    {
        public cleanmgrm()
        {
            InitializeComponent();
        }
            public string temp = System.IO.Path.GetTempPath();
        private void cleanup_Click(object sender, EventArgs e)
        {
                try
                {
                    DirectoryInfo d1 = new DirectoryInfo(temp);
                    d1.Delete(true);
                }
                catch { }
                Process process = new Process();
                process.StartInfo.FileName = "normal.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
                process.Close();
                MessageBox.Show("Finished!", "Cleanmgr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void next_Click(object sender, EventArgs e)
        {
                Process.Start("menu.exe");
                Environment.Exit(0);
        }
        private void cleanmgrm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.hide_link == false)
            {
                link link = new link();
                this.Hide();
                link.ShowDialog();
            }
        }
    }
}
