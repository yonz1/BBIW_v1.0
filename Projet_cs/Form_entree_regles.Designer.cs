namespace Projet_cs
{
    partial class Form_entree_regles
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.icon_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.Icon_maximize = new FontAwesome.Sharp.IconPictureBox();
            this.Icon_exit = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.importfilbtn = new FontAwesome.Sharp.IconButton();
            this.Clearbtn = new FontAwesome.Sharp.IconButton();
            this.Save_filebtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(26, 133);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1033, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icon_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_minimize.ForeColor = System.Drawing.Color.PowderBlue;
            this.icon_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.icon_minimize.IconColor = System.Drawing.Color.PowderBlue;
            this.icon_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_minimize.IconSize = 25;
            this.icon_minimize.Location = new System.Drawing.Point(919, 4);
            this.icon_minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(25, 26);
            this.icon_minimize.TabIndex = 7;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click_1);
            // 
            // Icon_maximize
            // 
            this.Icon_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Icon_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_maximize.ForeColor = System.Drawing.Color.LightGreen;
            this.Icon_maximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.Icon_maximize.IconColor = System.Drawing.Color.LightGreen;
            this.Icon_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_maximize.IconSize = 26;
            this.Icon_maximize.Location = new System.Drawing.Point(964, 4);
            this.Icon_maximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Icon_maximize.Name = "Icon_maximize";
            this.Icon_maximize.Size = new System.Drawing.Size(29, 26);
            this.Icon_maximize.TabIndex = 6;
            this.Icon_maximize.TabStop = false;
            this.Icon_maximize.Click += new System.EventHandler(this.Icon_maximize_Click_1);
            // 
            // Icon_exit
            // 
            this.Icon_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Icon_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_exit.ForeColor = System.Drawing.Color.LightCoral;
            this.Icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Icon_exit.IconColor = System.Drawing.Color.LightCoral;
            this.Icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_exit.IconSize = 26;
            this.Icon_exit.Location = new System.Drawing.Point(1016, 4);
            this.Icon_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Icon_exit.Name = "Icon_exit";
            this.Icon_exit.Size = new System.Drawing.Size(43, 26);
            this.Icon_exit.TabIndex = 5;
            this.Icon_exit.TabStop = false;
            this.Icon_exit.Click += new System.EventHandler(this.Icon_exit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.importfilbtn);
            this.panel1.Controls.Add(this.Clearbtn);
            this.panel1.Controls.Add(this.Save_filebtn);
            this.panel1.Controls.Add(this.Icon_maximize);
            this.panel1.Controls.Add(this.icon_minimize);
            this.panel1.Controls.Add(this.Icon_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 85);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_mousedown);
            // 
            // importfilbtn
            // 
            this.importfilbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importfilbtn.FlatAppearance.BorderSize = 0;
            this.importfilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importfilbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.importfilbtn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.importfilbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.importfilbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.importfilbtn.IconSize = 30;
            this.importfilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importfilbtn.Location = new System.Drawing.Point(661, 15);
            this.importfilbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importfilbtn.Name = "importfilbtn";
            this.importfilbtn.Size = new System.Drawing.Size(179, 44);
            this.importfilbtn.TabIndex = 11;
            this.importfilbtn.Text = "Import file";
            this.importfilbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importfilbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importfilbtn.UseVisualStyleBackColor = true;
            this.importfilbtn.Click += new System.EventHandler(this.importfilbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Clearbtn.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Clearbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Clearbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clearbtn.IconSize = 30;
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.Location = new System.Drawing.Point(428, 15);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(179, 44);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Save_filebtn
            // 
            this.Save_filebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_filebtn.FlatAppearance.BorderSize = 0;
            this.Save_filebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_filebtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Save_filebtn.IconChar = FontAwesome.Sharp.IconChar.HardDrive;
            this.Save_filebtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Save_filebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save_filebtn.IconSize = 30;
            this.Save_filebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_filebtn.Location = new System.Drawing.Point(204, 15);
            this.Save_filebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_filebtn.Name = "Save_filebtn";
            this.Save_filebtn.Size = new System.Drawing.Size(179, 44);
            this.Save_filebtn.TabIndex = 10;
            this.Save_filebtn.Text = "Save file";
            this.Save_filebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save_filebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_filebtn.UseVisualStyleBackColor = true;
            this.Save_filebtn.Click += new System.EventHandler(this.Save_filebtn_Click);
            // 
            // Form_entree_regles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_entree_regles";
            this.Text = "Form_entree_regles";
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconPictureBox icon_minimize;
        private FontAwesome.Sharp.IconPictureBox Icon_maximize;
        private FontAwesome.Sharp.IconPictureBox Icon_exit;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Save_filebtn;
        private FontAwesome.Sharp.IconButton importfilbtn;
        private FontAwesome.Sharp.IconButton Clearbtn;
    }
}