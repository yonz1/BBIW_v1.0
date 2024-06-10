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
            this.Credit1 = new System.Windows.Forms.Label();
            this.Credit2 = new System.Windows.Forms.Label();
            this.Credit3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Credit1
            // 
            this.Credit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Credit1.AutoSize = true;
            this.Credit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit1.Location = new System.Drawing.Point(346, 384);
            this.Credit1.Name = "Credit1";
            this.Credit1.Size = new System.Drawing.Size(173, 24);
            this.Credit1.TabIndex = 2;
            this.Credit1.Text = "Dos Santos Maceo ";
            // 
            // Credit2
            // 
            this.Credit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Credit2.AutoSize = true;
            this.Credit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit2.Location = new System.Drawing.Point(346, 418);
            this.Credit2.Name = "Credit2";
            this.Credit2.Size = new System.Drawing.Size(158, 24);
            this.Credit2.TabIndex = 3;
            this.Credit2.Text = "Boisson Matthieu ";
            // 
            // Credit3
            // 
            this.Credit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Credit3.AutoSize = true;
            this.Credit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Credit3.Location = new System.Drawing.Point(361, 453);
            this.Credit3.Name = "Credit3";
            this.Credit3.Size = new System.Drawing.Size(118, 24);
            this.Credit3.TabIndex = 4;
            this.Credit3.Text = "Pelle Bastien";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(275, 303);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(296, 44);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit our website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Credit3);
            this.Controls.Add(this.Credit2);
            this.Controls.Add(this.Credit1);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Credit1;
        private System.Windows.Forms.Label Credit2;
        private System.Windows.Forms.Label Credit3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}