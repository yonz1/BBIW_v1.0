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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void About_first_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void About_second_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbiw5.wordpress.com");
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
