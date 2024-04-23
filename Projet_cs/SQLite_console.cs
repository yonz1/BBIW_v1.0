using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_cs
{
    public partial class SQLite_console : Form
    {
        public SQLite_console()
        {
            InitializeComponent();
            listBox_import.Items.Add("Imported file path : " + "\n");
        }
    }

}
