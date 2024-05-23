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
            About_first.Items.Add("Ce projet à été créer par:");
            About_second.Items.Add("Cette application est composée de yara et de choses étranges ");
            About_second.Items.Add("Elle permet de decteter des virus ?");
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
    }
}
