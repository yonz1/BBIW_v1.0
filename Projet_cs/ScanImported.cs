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
//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Drawing.Text;




namespace Projet_cs
{
    public partial class ScanImported : Form
    {
        public ScanImported()
        {
            InitializeComponent();
            listBox_import.Items.Add("Imported file path : " + "\n");
            Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
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

                foreach (var item in listbox_result.Items)
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

            if (ofd_transfer.ShowDialog() == DialogResult.OK)
            {
                listBox_import.Items.Add(ofd_transfer.FileName);
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
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
                while ((ln = file.ReadLine()) != null) {
                    listbox_result.Items.Add(ln);
                    counter++;

                }
                file.Close();
            }
            System.DateTime Date_F = DateTime.Now;
            listbox_result.Items.Add("Scan finished at :" + Date_F);
            
            
        }

        public void run_cmd(object command)
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


        private void Showactionbtn_Click(object sender, EventArgs e)
        {
            if (removebtn.Visible)
            {
                listBox_action.Items.Clear();
                Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                listBox_action.Hide();
                removebtn.Hide();
                Quarantine.Hide();
            }
            else 
            {
                Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                listBox_action.BringToFront();
                listBox_action.Show();
                removebtn.BringToFront();
                removebtn.Show();
                Quarantine.BringToFront();
                Quarantine.Show();
                readdb();
            }

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            string str = listBox_action.SelectedItem.ToString();
            listBox_action.Items.Remove(listBox_action.SelectedItem);
            //object command = "del " + str;
            try
            {
                File.Delete(str);
                MessageBox.Show("Succes");
            }
            catch (ArgumentException) { MessageBox.Show("Argument"); }
            //catch (IOException) { MessageBox.Show("Execption IO "); }
            catch (NotSupportedException) { MessageBox.Show("notsupported"); }
            catch (UnauthorizedAccessException) { MessageBox.Show("unautorized"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("toolong"); }
            catch (IOException) { MessageBox.Show("IOexep"); }
            //run_cmd(command);
        }
        private void readdb()
        {
            string conSource = "Data Source=C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\result_imported_actions.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select * from result_scan_actions ";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                //string myread = reader.GetString(0);
                listBox_action.Items.Add(reader.GetString(1));
            }
            connection.Close();
        }
        
    }
}
