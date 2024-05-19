using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projet_cs
{
    public partial class Form_add_rules : Form
    {
        public Form_add_rules()
        {
            InitializeComponent();
        }

        private void add_rules_button_child_Click(object sender, EventArgs e)
        {
            Form_entree_regles fe = new Form_entree_regles();
            fe.Show();
        }

        private void View_rules_button_Click(object sender, EventArgs e)
        {

        }

        private void Add_boxbtn_Click(object sender, EventArgs e)
        {

            string path = Directory.GetCurrentDirectory();
            path = path + "\\..\\..\\Rules\\";
            string rule = Rulenamebox.Text.ToString();
            path = path + rule + ".yar";
            if (File.Exists(path))
            {
                var result = MessageBox.Show("This File already exist, do you want to overwrite it ?", "Write new rules", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    write_to_file(path);
                }
                else { }
            }
            else
            {
                try
                {
                    MessageBox.Show(path);
                    FileStream fs = File.Create(path);
                    fs.Close();
                    write_to_file(path);
                }
                catch
                {
                    MessageBox.Show("Error occured, check your write permissions, or directory to write");
                }
            }

        }
        private void write_to_file(string path)
        {
            System.IO.StreamWriter Savefile = new System.IO.StreamWriter(path);
            try
            {
                string rule = Rulenamebox.Text.ToString();
                string metadata = Metadatabox.Text.ToString();
                string strings = Stringsbox.Text.ToString();
                string conditions = Conditionsbox.Text.ToString();
                string complete_rule = "import \"pe\"\nimport \"hash\"\nimport \"math\"\n\n" + "rule " + rule + "{\n   meta:\n         " + metadata + "\n\n   ";
                complete_rule = complete_rule + "strings:\n     " + strings + "\n\n   " + "conditions:\n       " + conditions + "\n}";
                Savefile.Write(complete_rule);
                Savefile.Close();
            }
            catch
            {
                MessageBox.Show("An error occured");
                Savefile.Close();
            }
        }
    }
}
