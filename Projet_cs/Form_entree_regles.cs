using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Projet_cs
{
    public partial class Form_entree_regles : Form
    {
        int n = 0;
        string currenttext = "test";
        public Form_entree_regles()
        {
            InitializeComponent();
            richTextBox1.Text = "import 'pe'\nimport 'hash'\nimport 'math'\n\nrule <put the name of your rule> {\n\n  meta:\n     <type your metasdata here>\n\n    strings:\n      <type the string you want to detect as malicious>\n\n conditions:\n       <put the condition for the the threat to be detected>\n\n}";
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void Icon_exit_Click_1(object sender, EventArgs e)
        {
            if (currenttext != richTextBox1.Text)
            {
                const string message = "You doesn't save your work. Are you sure to quit ?";
                const string caption = "Closing form";
                var result = System.Windows.Forms.MessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
    }

        private void Icon_maximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void icon_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Panel1_mousedown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Save_filebtn_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            path = path + "\\..\\..\\Rules"; 

            System.Windows.Forms.OpenFileDialog ofd_transfer = new System.Windows.Forms.OpenFileDialog
            {
                InitialDirectory = path,
                Title = " Browse File",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt) | *.txt | All file(*.*) | *.*;",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (ofd_transfer.ShowDialog() == DialogResult.OK)
            {
                string save_path = ofd_transfer.FileName;
                System.IO.StreamWriter Savefile = new System.IO.StreamWriter(save_path);

                foreach (var item in richTextBox1.Text)
                {
                    Savefile.Write(item.ToString());
                }
                Savefile.Close();
                System.Windows.MessageBox.Show("Your rules has been saved");
            }
            currenttext = richTextBox1.Text;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "import \"pe\"\nimport \"hash\"\nimport \"math\"\n\nrule <put the name of your rule> {\n\n  meta:\n     <type your metasdata here>\n\n    strings:\n      <type the string you want to detect as malicious>\n\n conditions:\n       <put the condition for the the threat to be detected>\n\n}";
        }

        private void importfilbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd_transfer = new System.Windows.Forms.OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = " Browse File",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt) | *.txt | All file(*.*) | *.*;",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (ofd_transfer.ShowDialog() == DialogResult.OK)
            {
                string path = ofd_transfer.FileName;
                string add = File.ReadAllText(path, System.Text.Encoding.UTF8);
                richTextBox1.Text = add;

            }
        }
    }

}
