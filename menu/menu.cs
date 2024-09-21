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

namespace menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                textBox1.Text = "";
                Process.Start("cleanmgr.exe");
            }
            else
            {
                if (textBox1.Text == "2")
                {
                    textBox1.Text = "";
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    dialog.Description = "Please choose save path:";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(dialog.SelectedPath))
                        {
                            MessageBox.Show("The path can't be null!", "Error");
                            return;
                        }
                        string path = dialog.SelectedPath;
                        File.Create(path + @"\info.txt").Dispose();
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.Arguments = "/c systeminfo>>" + path + @"\info.txt & exit";
                        p.StartInfo.UseShellExecute = false;
                        p.Start();
                        p.WaitForExit();
                        p.Close();
                        MessageBox.Show("Info is in info.txt", "Cleanmgr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (textBox1.Text == "3")
                    {
                        textBox1.Text = "";
                        Process.Start("cmd.exe", "/c shutdown -r -f -t 30 & exit");
                    }
                    else
                    {
                        if (textBox1.Text == "4")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Cleanmgr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "";
                        }
                    }
                }
            }
        }
    }
}
