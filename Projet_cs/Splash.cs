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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1_Tick(this, EventArgs.Empty);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            progressBar1.Visible = true;
            progressBar1.BackColor = Color.FromArgb(34, 33, 74);
            progressBar1.ForeColor = Color.FromArgb(172, 126, 241);
            progressBar1.Style = ProgressBarStyle.Blocks;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void Credit1_Click(object sender, EventArgs e)
        {

        }
    }
}
