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
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Threading;
using System.Data.SQLite;
using System.Diagnostics;

namespace Projet_cs
{
    public partial class FormMemory : Form
    {
        public FormMemory()
        {
            InitializeComponent();
            listBox_import_pids.Items.Add("Imported PIDs : ");
            Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
        }

        private void FormMemory_Load(object sender, EventArgs e)
        {

        }

        private void Scan_Click(object sender, EventArgs e)
        {
            listbox_result_pids.Items.Clear();
            System.DateTime Date_S = DateTime.Now;
            listbox_result_pids.Items.Add("Scan started at :" + Date_S);
            string pids = listBox_import_pids.GetItemText(listBox_import_pids.SelectedItem);
            object command = "python3 C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\Scan.py  --memory --add --pid " + pids;
            run_cmd(command);
            using (StreamReader file = new StreamReader("../../scan_p.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    listbox_result_pids.Items.Add(ln);
                    counter++;
                }
                file.Close();
            }
            System.DateTime Date_F = DateTime.Now;
            listbox_result_pids.Items.Add("Scan finished at :" + Date_F);
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

        private void Scan_removed_Click(object sender, EventArgs e)
        {
            listbox_result_pids.Items.Clear();
            System.DateTime Date_S = DateTime.Now;
            listbox_result_pids.Items.Add("Scan started at :" + Date_S);
            string pids = listBox_import_pids.GetItemText(listBox_import_pids.SelectedItem);
            object command = "python3 C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\Scan.py  --memory --remove --pid " + pids;
            run_cmd(command);
            using (StreamReader file = new StreamReader("../../scan_p.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    listbox_result_pids.Items.Add(ln);
                    counter++;
                }
                file.Close();
            }
            System.DateTime Date_F = DateTime.Now;
            listbox_result_pids.Items.Add("Scan finished at :" + Date_F);
        }

        private void Scan_all_Click(object sender, EventArgs e)
        {
            listbox_result_pids.Items.Clear();
            System.DateTime Date_S = DateTime.Now;
            listbox_result_pids.Items.Add("Scan started at :" + Date_S);
            string pids = listBox_import_pids.GetItemText(listBox_import_pids.SelectedItem);
            object command = "python3 C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\Scan.py  --memory";
            run_cmd(command);
            using (StreamReader file = new StreamReader("../../scan_p.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    listbox_result_pids.Items.Add(ln);
                    counter++;
                }
                file.Close();
            }
            System.DateTime Date_F = DateTime.Now;
            listbox_result_pids.Items.Add("Scan finished at :" + Date_F);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            listBox_import_pids.Items.Remove(listBox_import_pids.SelectedItem);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox_import_pids.Items.Clear(); 
            listBox_import_pids.Items.Add("Imported PIDs : ");
        }

        private void Add_file_Click(object sender, EventArgs e)
        {
            string imported_pids = textBox_import.Text;
            textBox_import.Clear();
            listBox_import_pids.Items.Add(imported_pids);
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

                foreach (var item in listbox_result_pids.Items)
                {
                    Savefile.WriteLine(item.ToString());
                }
                Savefile.Close();
                MessageBox.Show("Programm saved");

            }
        }

        private void Showactionbtn_Click_1(object sender, EventArgs e)
        {
            if (Killbtn.Visible)
            {
                Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                listBox_action.Hide();
                Killbtn.Hide();
                Quarantine.Hide();
            }
            else
            {
                Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                listBox_action.BringToFront();
                listBox_action.Show();
                Killbtn.BringToFront();
                Killbtn.Show();
                Quarantine.BringToFront();
                Quarantine.Show();
                readdb();
            }
        }
        private void readdb()
        {
            listBox_action.Items.Clear();
            string conSource = "Data Source=C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select * from result_scan_actions_process";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox_action.Items.Add(reader.GetString(0));
            }
            connection.Close();
        }

        private void Killbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = listBox_action.SelectedItem.ToString();
                Process proc = Process.GetProcessById(System.Convert.ToInt16(str));
                proc.Kill();
                listBox_action.Items.Remove(listBox_action.SelectedItem);
                string conSource = "Data Source=C:\\Users\\basti\\Desktop\\Projet_cs_4\\Projet_cs\\result2.db";
                var connection = new SQLiteConnection(conSource);
                connection.Open();
                string query = "DELETE from result_scan_actions_process WHERE pids='" + str + "';";
                var command = new SQLiteCommand(query, connection);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detected");
            }
        }
    }
}
