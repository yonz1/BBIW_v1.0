namespace Projet_cs
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.About_first = new System.Windows.Forms.ListBox();
            this.About_second = new System.Windows.Forms.ListBox();
            this.Credit1 = new System.Windows.Forms.Label();
            this.Credit2 = new System.Windows.Forms.Label();
            this.Credit3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // About_first
            // 
            this.About_first.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.About_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.About_first.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.About_first.ForeColor = System.Drawing.Color.Gainsboro;
            this.About_first.FormattingEnabled = true;
            this.About_first.Location = new System.Drawing.Point(25, 24);
            this.About_first.Name = "About_first";
            this.About_first.Size = new System.Drawing.Size(337, 364);
            this.About_first.TabIndex = 0;
            this.About_first.SelectedIndexChanged += new System.EventHandler(this.About_first_SelectedIndexChanged);
            // 
            // About_second
            // 
            this.About_second.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.About_second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.About_second.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.About_second.ForeColor = System.Drawing.Color.Gainsboro;
            this.About_second.FormattingEnabled = true;
            this.About_second.Location = new System.Drawing.Point(368, 24);
            this.About_second.Name = "About_second";
            this.About_second.Size = new System.Drawing.Size(391, 364);
            this.About_second.TabIndex = 1;
            // 
            // Credit1
            // 
            this.Credit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit1.AutoSize = true;
            this.Credit1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit1.Location = new System.Drawing.Point(311, 408);
            this.Credit1.Name = "Credit1";
            this.Credit1.Size = new System.Drawing.Size(101, 13);
            this.Credit1.TabIndex = 2;
            this.Credit1.Text = "Dos Santos Maceo ";
            // 
            // Credit2
            // 
            this.Credit2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit2.AutoSize = true;
            this.Credit2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit2.Location = new System.Drawing.Point(311, 443);
            this.Credit2.Name = "Credit2";
            this.Credit2.Size = new System.Drawing.Size(91, 13);
            this.Credit2.TabIndex = 3;
            this.Credit2.Text = "Boisson Matthieu ";
            // 
            // Credit3
            // 
            this.Credit3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit3.AutoSize = true;
            this.Credit3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit3.Location = new System.Drawing.Point(321, 475);
            this.Credit3.Name = "Credit3";
            this.Credit3.Size = new System.Drawing.Size(68, 13);
            this.Credit3.TabIndex = 4;
            this.Credit3.Text = "Pelle Bastien";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.Credit3);
            this.Controls.Add(this.Credit2);
            this.Controls.Add(this.Credit1);
            this.Controls.Add(this.About_second);
            this.Controls.Add(this.About_first);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox About_first;
        private System.Windows.Forms.ListBox About_second;
        private System.Windows.Forms.Label Credit1;
        private System.Windows.Forms.Label Credit2;
        private System.Windows.Forms.Label Credit3;
    }
}