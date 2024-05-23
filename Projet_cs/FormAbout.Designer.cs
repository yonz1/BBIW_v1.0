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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.About_first = new System.Windows.Forms.ListBox();
            this.About_second = new System.Windows.Forms.ListBox();
            this.Credit1 = new System.Windows.Forms.Label();
            this.Credit2 = new System.Windows.Forms.Label();
            this.Credit3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.About_first.ItemHeight = 16;
            this.About_first.Location = new System.Drawing.Point(33, 30);
            this.About_first.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.About_first.Name = "About_first";
            this.About_first.Size = new System.Drawing.Size(449, 448);
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
            this.About_second.ItemHeight = 16;
            this.About_second.Location = new System.Drawing.Point(491, 30);
            this.About_second.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.About_second.Name = "About_second";
            this.About_second.Size = new System.Drawing.Size(521, 448);
            this.About_second.TabIndex = 1;
            this.About_second.SelectedIndexChanged += new System.EventHandler(this.About_second_SelectedIndexChanged);
            // 
            // Credit1
            // 
            this.Credit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit1.AutoSize = true;
            this.Credit1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit1.Location = new System.Drawing.Point(30, 82);
            this.Credit1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credit1.Name = "Credit1";
            this.Credit1.Size = new System.Drawing.Size(125, 16);
            this.Credit1.TabIndex = 2;
            this.Credit1.Text = "Dos Santos Maceo ";
            // 
            // Credit2
            // 
            this.Credit2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit2.AutoSize = true;
            this.Credit2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit2.Location = new System.Drawing.Point(30, 125);
            this.Credit2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credit2.Name = "Credit2";
            this.Credit2.Size = new System.Drawing.Size(112, 16);
            this.Credit2.TabIndex = 3;
            this.Credit2.Text = "Boisson Matthieu ";
            // 
            // Credit3
            // 
            this.Credit3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Credit3.AutoSize = true;
            this.Credit3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit3.Location = new System.Drawing.Point(30, 169);
            this.Credit3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credit3.Name = "Credit3";
            this.Credit3.Size = new System.Drawing.Size(86, 16);
            this.Credit3.TabIndex = 4;
            this.Credit3.Text = "Pelle Bastien";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(650, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(362, 54);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit our website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1048, 657);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Credit3);
            this.Controls.Add(this.Credit2);
            this.Controls.Add(this.Credit1);
            this.Controls.Add(this.About_second);
            this.Controls.Add(this.About_first);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox About_first;
        private System.Windows.Forms.ListBox About_second;
        private System.Windows.Forms.Label Credit1;
        private System.Windows.Forms.Label Credit2;
        private System.Windows.Forms.Label Credit3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}