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
            listBox_lastimported.Items.Add("Last scanned files and PIDs : ");
            readdb_import();
            //readdb_chart();
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
            listBox_lastimported.Items.Clear();
            string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select * from result_scan_all";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox_lastimported.Items.Add(reader.GetString(0));
            }
            connection.Close();
        }
        private void readdb_chart()
        {
            listBox_lastimported.Items.Clear();
            string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = "select date from result_scan_test_manual2";
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart_scanned.Series[1].XValueMember = reader.GetString(0);
            }
            //query = "SELECT COUNT(offset) from result_scan_test_manual2";
            //command = new SQLiteCommand(query, connection);
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    chart_scanned.Series[0].YValueMembers = reader.GetString(0);
            //}
            connection.Close();
        }

    }
}
