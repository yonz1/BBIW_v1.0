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
            About_first.Items.Add("Ce projet à été créer par...");
            About_second.Items.Add("Cette application est composée de ... et permet de ....");
        }
    }
}
