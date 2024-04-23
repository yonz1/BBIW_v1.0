using Microsoft.Win32;
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
using System.Windows.Documents;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Threading;


namespace Projet_cs
{
    public partial class ScanImported : Form
    {
        public ScanImported()
        {
            InitializeComponent();
            listBox_import.Items.Add("Imported file path : " + "\n");
        }
        
        private void Save_file_Click(object sender, EventArgs e)
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
                string save_path = ofd_transfer.FileName;
                System.IO.StreamWriter Savefile = new System.IO.StreamWriter(save_path);

                foreach(var item in listbox_result.Items)
                {
                    Savefile.WriteLine(item.ToString());
                }
                Savefile.Close();
                MessageBox.Show("Programm saved");

            }
        }

        private void Add_file_Click(object sender, EventArgs e)
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

            if(ofd_transfer.ShowDialog() == DialogResult.OK)
            {
               listBox_import.Items.Add(ofd_transfer.FileName);
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
           // string path = listBox_import.GetItemText(listBox_import.SelectedItem);
            listbox_result.Items.Clear();
            System.DateTime Date_S = DateTime.Now;
            listbox_result.Items.Add("Scan started at :" + Date_S);
            string path = listBox_import.GetItemText(listBox_import.SelectedItem);
            object command = "python3 C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\Scan.py  --imported " + path;
            run_cmd(command);
            using (StreamReader file = new StreamReader("../../scan.txt"))
            {
                int counter = 0;
                string ln;
                while((ln = file.ReadLine()) != null) {
                    listbox_result.Items.Add(ln);
                    counter++;
                }
                file.Close();
            }
            System.DateTime Date_F = DateTime.Now;
            listbox_result.Items.Add("Scan finished at :" + Date_F);
        }

        private void run_cmd(object command)
        {
            System.Diagnostics.ProcessStartInfo procstatinfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + command);
            procstatinfo.UseShellExecute = false;
            procstatinfo.CreateNoWindow = true;
            procstatinfo.RedirectStandardOutput = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procstatinfo;
            proc.Start();
            proc.WaitForExit();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            listBox_import.Items.Remove(listBox_import.SelectedItem);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox_import.Items.Clear();
            listBox_import.Items.Add("Imported file path : " + "\n");
        }

        private void Scan_all_Click(object sender, EventArgs e)
        {

        }
        private void ScanImported_Load(object sender, EventArgs e)
        {

        }
    }
}
