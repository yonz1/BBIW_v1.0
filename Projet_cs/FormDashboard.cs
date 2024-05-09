using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace Projet_cs
{
    public partial class FormDashboard : Form
    {
        DateTime today = DateTime.Today;
        private readonly string connectionString;
        public FormDashboard()
        {
            InitializeComponent();
            listBox_lastimported.Items.Clear();
            listBox_lastimported.Items.Add("Last scanned files and PIDs : ");
            readdb_import();
            readdb_chart();
                        string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            //chart_scanned.Series[1].YValueMembers = "3";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void readdb_import()
        {
            int i = 0;
            string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select * from result_scan_all";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ( i != 15)
                { 
                listBox_lastimported.Items.Add(reader.GetString(0));
                }
                else
                {
                    return;
                }
                i++;
            }
            connection.Close();
        }
        private void readdb_chart()
        {
            string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select date from result_scan_test_manual2";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            List<string> Date = new List<string>();
            while (reader.Read())
            {
                string date = reader.GetString(0);
                if (Date.Count == 0)
                {
                    Date.Add(date);
                }
                else
                {
                    if (!Date.Contains(date))
                    {
                        Date.Add(date);
                    }
                }
            }

            foreach (var item in Date)
            {
                //chart_scanned.Series[0].Points.AddXY(item, 2000);
                string val = "'" + item + "'";
                query = "SELECT COUNT(date) FROM result_scan_test_manual2 WHERE date=" + val;
                command = new SQLiteCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Yvalue = reader.GetInt16(0);
                    chart_scanned.Series[0].Points.AddXY(item, Yvalue);
                }
            }
            /*try
            {
                for (int i = 0; i < Date.Count; i++)
                {
                    MessageBox.Show(System.Convert.ToString(Date));
                    chart_scanned.Series["0"].Points.AddXY(Date[i], i);
                }
            }
            

            catch { MessageBox.Show("error"); }*/

            connection.Close();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
