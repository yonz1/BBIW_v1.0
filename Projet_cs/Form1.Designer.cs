namespace Projet_cs
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.About = new FontAwesome.Sharp.IconButton();
            this.Pre_defined_Scan = new FontAwesome.Sharp.IconButton();
            this.Memory_Scan = new FontAwesome.Sharp.IconButton();
            this.Imported_Scan = new FontAwesome.Sharp.IconButton();
            this.SQLite_console = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.Icon_maximize = new FontAwesome.Sharp.IconPictureBox();
            this.Icon_exit = new FontAwesome.Sharp.IconPictureBox();
            this.TitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.About);
            this.panelMenu.Controls.Add(this.Pre_defined_Scan);
            this.panelMenu.Controls.Add(this.Memory_Scan);
            this.panelMenu.Controls.Add(this.Imported_Scan);
            this.panelMenu.Controls.Add(this.SQLite_console);
            this.panelMenu.Controls.Add(this.Dashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 657);
            this.panelMenu.TabIndex = 0;
            // 
            // About
            // 
            this.About.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.Gainsboro;
            this.About.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.About.IconColor = System.Drawing.Color.Gainsboro;
            this.About.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.About.IconSize = 32;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Location = new System.Drawing.Point(0, 597);
            this.About.Margin = new System.Windows.Forms.Padding(2);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.About.Size = new System.Drawing.Size(245, 60);
            this.About.TabIndex = 6;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Pre_defined_Scan
            // 
            this.Pre_defined_Scan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pre_defined_Scan.FlatAppearance.BorderSize = 0;
            this.Pre_defined_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pre_defined_Scan.ForeColor = System.Drawing.Color.Gainsboro;
            this.Pre_defined_Scan.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.Pre_defined_Scan.IconColor = System.Drawing.Color.Gainsboro;
            this.Pre_defined_Scan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pre_defined_Scan.IconSize = 32;
            this.Pre_defined_Scan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pre_defined_Scan.Location = new System.Drawing.Point(0, 411);
            this.Pre_defined_Scan.Margin = new System.Windows.Forms.Padding(2);
            this.Pre_defined_Scan.Name = "Pre_defined_Scan";
            this.Pre_defined_Scan.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.Pre_defined_Scan.Size = new System.Drawing.Size(245, 60);
            this.Pre_defined_Scan.TabIndex = 5;
            this.Pre_defined_Scan.Text = "Pre-defined Scan";
            this.Pre_defined_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pre_defined_Scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pre_defined_Scan.UseVisualStyleBackColor = true;
            this.Pre_defined_Scan.Click += new System.EventHandler(this.Pre_defined_Scan_Click);
            // 
            // Memory_Scan
            // 
            this.Memory_Scan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Memory_Scan.FlatAppearance.BorderSize = 0;
            this.Memory_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Memory_Scan.ForeColor = System.Drawing.Color.Gainsboro;
            this.Memory_Scan.IconChar = FontAwesome.Sharp.IconChar.Memory;
            this.Memory_Scan.IconColor = System.Drawing.Color.Gainsboro;
            this.Memory_Scan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Memory_Scan.IconSize = 32;
            this.Memory_Scan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Memory_Scan.Location = new System.Drawing.Point(0, 351);
            this.Memory_Scan.Margin = new System.Windows.Forms.Padding(2);
            this.Memory_Scan.Name = "Memory_Scan";
            this.Memory_Scan.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.Memory_Scan.Size = new System.Drawing.Size(245, 60);
            this.Memory_Scan.TabIndex = 4;
            this.Memory_Scan.Text = "Memory Scan";
            this.Memory_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Memory_Scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Memory_Scan.UseVisualStyleBackColor = true;
            this.Memory_Scan.Click += new System.EventHandler(this.Memory_Scan_Click);
            // 
            // Imported_Scan
            // 
            this.Imported_Scan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Imported_Scan.FlatAppearance.BorderSize = 0;
            this.Imported_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imported_Scan.ForeColor = System.Drawing.Color.Gainsboro;
            this.Imported_Scan.IconChar = FontAwesome.Sharp.IconChar.NfcSymbol;
            this.Imported_Scan.IconColor = System.Drawing.Color.Gainsboro;
            this.Imported_Scan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Imported_Scan.IconSize = 32;
            this.Imported_Scan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imported_Scan.Location = new System.Drawing.Point(0, 291);
            this.Imported_Scan.Margin = new System.Windows.Forms.Padding(2);
            this.Imported_Scan.Name = "Imported_Scan";
            this.Imported_Scan.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.Imported_Scan.Size = new System.Drawing.Size(245, 60);
            this.Imported_Scan.TabIndex = 3;
            this.Imported_Scan.Text = "Imported Scan";
            this.Imported_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imported_Scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imported_Scan.UseVisualStyleBackColor = true;
            this.Imported_Scan.Click += new System.EventHandler(this.Imported_Scan_Click);
            // 
            // SQLite_console
            // 
            this.SQLite_console.Dock = System.Windows.Forms.DockStyle.Top;
            this.SQLite_console.FlatAppearance.BorderSize = 0;
            this.SQLite_console.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQLite_console.ForeColor = System.Drawing.Color.Gainsboro;
            this.SQLite_console.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.SQLite_console.IconColor = System.Drawing.Color.Gainsboro;
            this.SQLite_console.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SQLite_console.IconSize = 32;
            this.SQLite_console.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLite_console.Location = new System.Drawing.Point(0, 231);
            this.SQLite_console.Margin = new System.Windows.Forms.Padding(2);
            this.SQLite_console.Name = "SQLite_console";
            this.SQLite_console.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.SQLite_console.Size = new System.Drawing.Size(245, 60);
            this.SQLite_console.TabIndex = 2;
            this.SQLite_console.Text = "SQL console";
            this.SQLite_console.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLite_console.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SQLite_console.UseVisualStyleBackColor = true;
            this.SQLite_console.Click += new System.EventHandler(this.SQLite_console_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard.IconSize = 32;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 171);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.Dashboard.Size = new System.Drawing.Size(245, 60);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(245, 171);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.icon_minimize);
            this.panel1.Controls.Add(this.Icon_maximize);
            this.panel1.Controls.Add(this.Icon_exit);
            this.panel1.Controls.Add(this.TitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(245, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 75);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.icon_minimize.IconSize = 19;
            this.icon_minimize.Location = new System.Drawing.Point(695, 3);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(19, 21);
            this.icon_minimize.TabIndex = 4;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
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
            this.Icon_maximize.IconSize = 21;
            this.Icon_maximize.Location = new System.Drawing.Point(733, 3);
            this.Icon_maximize.Name = "Icon_maximize";
            this.Icon_maximize.Size = new System.Drawing.Size(22, 21);
            this.Icon_maximize.TabIndex = 3;
            this.Icon_maximize.TabStop = false;
            this.Icon_maximize.Click += new System.EventHandler(this.Icon_maximize_Click);
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
            this.Icon_exit.IconSize = 21;
            this.Icon_exit.Location = new System.Drawing.Point(770, 3);
            this.Icon_exit.Name = "Icon_exit";
            this.Icon_exit.Size = new System.Drawing.Size(32, 21);
            this.Icon_exit.TabIndex = 2;
            this.Icon_exit.TabStop = false;
            this.Icon_exit.Click += new System.EventHandler(this.Icon_exit_Click);
            // 
            // TitleChildForm
            // 
            this.TitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleChildForm.AutoSize = true;
            this.TitleChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.TitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleChildForm.Location = new System.Drawing.Point(313, 32);
            this.TitleChildForm.Name = "TitleChildForm";
            this.TitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.TitleChildForm.TabIndex = 1;
            this.TitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(275, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(245, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(802, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.Clock);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(245, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(802, 573);
            this.panelDesktop.TabIndex = 3;
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.Gainsboro;
            this.Clock.Location = new System.Drawing.Point(234, 353);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(417, 108);
            this.Clock.TabIndex = 1;
            this.Clock.Text = "00:00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(266, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(353, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1047, 657);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton About;
        private FontAwesome.Sharp.IconButton Pre_defined_Scan;
        private FontAwesome.Sharp.IconButton Memory_Scan;
        private FontAwesome.Sharp.IconButton Imported_Scan;
        private FontAwesome.Sharp.IconButton SQLite_console;
        private FontAwesome.Sharp.IconButton Dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label TitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox icon_minimize;
        private FontAwesome.Sharp.IconPictureBox Icon_maximize;
        private FontAwesome.Sharp.IconPictureBox Icon_exit;
    }
}

