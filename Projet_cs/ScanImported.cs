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
using System.Runtime.InteropServices.WindowsRuntime;




namespace Projet_cs
{
    public partial class ScanImported : Form
    {
        SortedList<byte, int> slTimeSymbolAppears;
        SortedList<byte, double> slEntropy;
        double dblEntropy;
        bool blnUsed;
        int iSize;
        public ScanImported()
        {
            InitializeComponent();
            listBox_import.Items.Add("Imported file path : " + "\n");
            Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
        }

        public int Size2
        {
            get
            {
                return iSize;
            }
            private set
            {
                iSize = value;
            }
        }
        public int Unique
        {
            get
            {
                return slTimeSymbolAppears.Count;
            }
        }
        public double Entropy
        {
            get
            {
                return GetEntropy();
            }
        }
        public Dictionary<byte, int> Distribution
        { 
            get
            {
                return SortedDistribution();
            }
        }
        public Dictionary<byte, double> Probability
        {
            get
            {
                return SortedProbability();
            }
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
            ShannonEntropy(path);
            object command = "python3 ..\\..\\Scan.py --imported " + path;
            run_cmd(command);
            using (StreamReader file = new StreamReader("..\\..\\scan_i.txt"))
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
            Cursor.Current = Cursors.WaitCursor;
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
                string conSource = "Data Source=..\\..\\result2.db";
                var connection = new SQLiteConnection(conSource);
                connection.Open();
                string query = "DELETE from result_scan_actions WHERE file=" + str;
                var command = new SQLiteCommand(query, connection);
                connection.Close();
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
            listBox_action.Items.Clear();
            string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select * from result_scan_actions";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox_action.Items.Add(reader.GetString(0));
            }
            connection.Close();
        }

        // Debut du calcul de l'entropie
        public byte GreatestDistribution()
        {
            return slTimeSymbolAppears.Keys[0];
        }

        public byte GreatestProbability()
        {
            return slEntropy.Keys[0];
        }

        public double SymbolDistribution(byte bSymbol)
        {
            return slTimeSymbolAppears[bSymbol];
        }

        public double SymbolEntropy(byte bSymbol)
        {
            return slEntropy[bSymbol];
        }

        public Dictionary<byte, int> SortedDistribution()
        {

            List<Tuple<int, byte>> lstEntries = new
               List<Tuple<int, byte>>();

            foreach (KeyValuePair<byte, int> e in slTimeSymbolAppears)
            {
                lstEntries.Add(new Tuple<int, byte>(e.Value, e.Key));
            }
            lstEntries.Sort();
            lstEntries.Reverse();
            Dictionary<byte, int> dicResult = new
               Dictionary<byte, int>();
            foreach (Tuple<int, byte> e in lstEntries)
            {
                dicResult.Add(e.Item2, e.Item1);
            }
            return dicResult;

        }

        public Dictionary<byte, double> SortedProbability()
        {

            List<Tuple<double, byte>> lstEntries = new
               List<Tuple<double, byte>>();
            foreach (KeyValuePair<byte, double> e in slEntropy)
            {
                lstEntries.Add(new Tuple<double, byte>(e.Value, e.Key));
            }
            lstEntries.Sort();
            lstEntries.Reverse();
            Dictionary<byte, double> dicResult = new
               Dictionary<byte, double>();

            foreach (Tuple<double, byte> e in lstEntries)
            {
                dicResult.Add(e.Item2, e.Item1);
            }
            return dicResult;
        }

        public double GetEntropy()
        {
            if (!blnUsed)
            {
                return dblEntropy;
            }
            dblEntropy = 0;
            slEntropy = new SortedList<byte, double>();
            foreach (KeyValuePair<byte, int> e in slTimeSymbolAppears)
            {
                slEntropy.Add(e.Key, (double)slTimeSymbolAppears[e.Key] /
                   (double)iSize);
            }
            foreach (KeyValuePair<byte, double> e in slEntropy)
            {
                dblEntropy += e.Value * Math.Log((1 / e.Value), 2);
            }
            blnUsed = false;
            listbox_result.Items.Add("The selected file entropy is : " + System.Convert.ToString(dblEntropy));
            if (dblEntropy > 3.5 &&  dblEntropy < 5)
            {
                listbox_result.Items.Add("This file has the entropy of standard english text\n");
            }
            if (dblEntropy > 7.5)
            {
                listbox_result.Items.Add("This file has the entropy of a compressed or encrypted file\n");
            }
            if (dblEntropy < 3.5)
            {
                listbox_result.Items.Add("This file has the entropy of a normal file\n");
            }
            return dblEntropy;
        }

        public void GetBytes(byte[] bBytes)
        {
            if (bBytes.Length < 1 || bBytes == null)
            {

                return;

            }
            blnUsed = true;
            iSize += bBytes.Length;
            foreach (byte bt in bBytes)
            {
                if (!slTimeSymbolAppears.ContainsKey(bt))
                {
                    slTimeSymbolAppears.Add(bt, 1);
                    continue;
                }
                slTimeSymbolAppears[bt]++;
            }
        }

        public void GetBytes(string strBytes)
        {
            GetBytes(StringToByteArray(strBytes));
        }

        byte[] StringToByteArray(string strInput)
        {
            char[] c = strInput.ToCharArray();
            IEnumerable<byte> b = c.Cast<byte>();
            return b.ToArray();
        }

        void Clear2()
        {
            blnUsed = true;
            dblEntropy = 0;
            iSize = 0;
            slTimeSymbolAppears = new SortedList<byte, int>();
            slEntropy = new SortedList<byte, double>();
        }

        public void ShannonEntropy(string fileName)
        {
            Clear2();
            if (File.Exists(fileName))
            {
                GetBytes(File.ReadAllBytes(fileName));
                GetEntropy();
                SortedDistribution();
            }
        }

        public void ShannonEntropy_c()
        {
            Clear2();
            return;
        }
    }
}
