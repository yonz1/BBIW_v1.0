namespace Projet_cs
{
    partial class FormMemory
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
            this.Scan_all = new System.Windows.Forms.Button();
            this.listBox_import_pids = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.Save_file = new System.Windows.Forms.Button();
            this.Scan_added = new System.Windows.Forms.Button();
            this.Add_file = new System.Windows.Forms.Button();
            this.listbox_result_pids = new System.Windows.Forms.ListBox();
            this.Scan_removed = new System.Windows.Forms.Button();
            this.textBox_import = new System.Windows.Forms.TextBox();
            this.Showactionbtn = new FontAwesome.Sharp.IconButton();
            this.Quarantine = new System.Windows.Forms.Button();
            this.Killbtn = new System.Windows.Forms.Button();
            this.listBox_action = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Scan_all
            // 
            this.Scan_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Scan_all.FlatAppearance.BorderSize = 2;
            this.Scan_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan_all.ForeColor = System.Drawing.Color.Gainsboro;
            this.Scan_all.Location = new System.Drawing.Point(171, 319);
            this.Scan_all.Name = "Scan_all";
            this.Scan_all.Size = new System.Drawing.Size(60, 24);
            this.Scan_all.TabIndex = 16;
            this.Scan_all.Text = "Scan All";
            this.Scan_all.UseVisualStyleBackColor = true;
            this.Scan_all.Click += new System.EventHandler(this.Scan_all_Click);
            // 
            // listBox_import_pids
            // 
            this.listBox_import_pids.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_import_pids.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox_import_pids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_import_pids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_import_pids.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox_import_pids.FormattingEnabled = true;
            this.listBox_import_pids.ItemHeight = 20;
            this.listBox_import_pids.Location = new System.Drawing.Point(406, 156);
            this.listBox_import_pids.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_import_pids.Name = "listBox_import_pids";
            this.listBox_import_pids.Size = new System.Drawing.Size(358, 140);
            this.listBox_import_pids.TabIndex = 15;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 2;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.Gainsboro;
            this.Clear.Location = new System.Drawing.Point(550, 319);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 24);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.FlatAppearance.BorderSize = 2;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.ForeColor = System.Drawing.Color.Gainsboro;
            this.remove.Location = new System.Drawing.Point(477, 319);
            this.remove.Margin = new System.Windows.Forms.Padding(2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(60, 24);
            this.remove.TabIndex = 13;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Save_file
            // 
            this.Save_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_file.FlatAppearance.BorderSize = 2;
            this.Save_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_file.ForeColor = System.Drawing.Color.Gainsboro;
            this.Save_file.Location = new System.Drawing.Point(236, 319);
            this.Save_file.Margin = new System.Windows.Forms.Padding(2);
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(60, 24);
            this.Save_file.TabIndex = 12;
            this.Save_file.Text = "Save file";
            this.Save_file.UseVisualStyleBackColor = true;
            this.Save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // Scan_added
            // 
            this.Scan_added.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Scan_added.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scan_added.FlatAppearance.BorderSize = 2;
            this.Scan_added.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan_added.ForeColor = System.Drawing.Color.Gainsboro;
            this.Scan_added.Location = new System.Drawing.Point(40, 318);
            this.Scan_added.Margin = new System.Windows.Forms.Padding(2);
            this.Scan_added.Name = "Scan_added";
            this.Scan_added.Size = new System.Drawing.Size(60, 24);
            this.Scan_added.TabIndex = 11;
            this.Scan_added.Text = "Added";
            this.Scan_added.UseVisualStyleBackColor = true;
            this.Scan_added.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Add_file
            // 
            this.Add_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_file.FlatAppearance.BorderSize = 2;
            this.Add_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_file.ForeColor = System.Drawing.Color.Gainsboro;
            this.Add_file.Location = new System.Drawing.Point(406, 319);
            this.Add_file.Margin = new System.Windows.Forms.Padding(2);
            this.Add_file.Name = "Add_file";
            this.Add_file.Size = new System.Drawing.Size(60, 24);
            this.Add_file.TabIndex = 10;
            this.Add_file.Text = "Add";
            this.Add_file.UseVisualStyleBackColor = true;
            this.Add_file.Click += new System.EventHandler(this.Add_file_Click);
            // 
            // listbox_result_pids
            // 
            this.listbox_result_pids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_result_pids.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listbox_result_pids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_result_pids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_result_pids.ForeColor = System.Drawing.Color.Gainsboro;
            this.listbox_result_pids.FormattingEnabled = true;
            this.listbox_result_pids.ItemHeight = 20;
            this.listbox_result_pids.Location = new System.Drawing.Point(40, 116);
            this.listbox_result_pids.Name = "listbox_result_pids";
            this.listbox_result_pids.Size = new System.Drawing.Size(358, 180);
            this.listbox_result_pids.TabIndex = 9;
            // 
            // Scan_removed
            // 
            this.Scan_removed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Scan_removed.FlatAppearance.BorderSize = 2;
            this.Scan_removed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan_removed.ForeColor = System.Drawing.Color.Gainsboro;
            this.Scan_removed.Location = new System.Drawing.Point(105, 319);
            this.Scan_removed.Name = "Scan_removed";
            this.Scan_removed.Size = new System.Drawing.Size(60, 24);
            this.Scan_removed.TabIndex = 17;
            this.Scan_removed.Text = "Removed";
            this.Scan_removed.UseVisualStyleBackColor = true;
            this.Scan_removed.Click += new System.EventHandler(this.Scan_removed_Click);
            // 
            // textBox_import
            // 
            this.textBox_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_import.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_import.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_import.Location = new System.Drawing.Point(404, 116);
            this.textBox_import.Name = "textBox_import";
            this.textBox_import.Size = new System.Drawing.Size(358, 26);
            this.textBox_import.TabIndex = 18;
            // 
            // Showactionbtn
            // 
            this.Showactionbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Showactionbtn.FlatAppearance.BorderSize = 2;
            this.Showactionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Showactionbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Showactionbtn.IconChar = FontAwesome.Sharp.IconChar.Ns8;
            this.Showactionbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Showactionbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Showactionbtn.IconSize = 30;
            this.Showactionbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Showactionbtn.Location = new System.Drawing.Point(602, 12);
            this.Showactionbtn.Name = "Showactionbtn";
            this.Showactionbtn.Size = new System.Drawing.Size(162, 44);
            this.Showactionbtn.TabIndex = 19;
            this.Showactionbtn.Text = "Show action";
            this.Showactionbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Showactionbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Showactionbtn.UseVisualStyleBackColor = true;
            this.Showactionbtn.Click += new System.EventHandler(this.Showactionbtn_Click_1);
            // 
            // Quarantine
            // 
            this.Quarantine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Quarantine.FlatAppearance.BorderSize = 2;
            this.Quarantine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quarantine.ForeColor = System.Drawing.Color.Gainsboro;
            this.Quarantine.Location = new System.Drawing.Point(498, 423);
            this.Quarantine.Name = "Quarantine";
            this.Quarantine.Size = new System.Drawing.Size(75, 23);
            this.Quarantine.TabIndex = 23;
            this.Quarantine.Text = "Quarantine";
            this.Quarantine.UseVisualStyleBackColor = true;
            this.Quarantine.Visible = false;
            // 
            // Killbtn
            // 
            this.Killbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Killbtn.FlatAppearance.BorderSize = 2;
            this.Killbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Killbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Killbtn.Location = new System.Drawing.Point(498, 394);
            this.Killbtn.Name = "Killbtn";
            this.Killbtn.Size = new System.Drawing.Size(75, 23);
            this.Killbtn.TabIndex = 22;
            this.Killbtn.Text = "Kill";
            this.Killbtn.UseVisualStyleBackColor = true;
            this.Killbtn.Visible = false;
            // 
            // listBox_action
            // 
            this.listBox_action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_action.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_action.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox_action.FormattingEnabled = true;
            this.listBox_action.ItemHeight = 20;
            this.listBox_action.Location = new System.Drawing.Point(33, 394);
            this.listBox_action.Name = "listBox_action";
            this.listBox_action.Size = new System.Drawing.Size(450, 124);
            this.listBox_action.TabIndex = 21;
            this.listBox_action.Visible = false;
            // 
            // FormMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.Quarantine);
            this.Controls.Add(this.Killbtn);
            this.Controls.Add(this.listBox_action);
            this.Controls.Add(this.Showactionbtn);
            this.Controls.Add(this.textBox_import);
            this.Controls.Add(this.Scan_removed);
            this.Controls.Add(this.Scan_all);
            this.Controls.Add(this.listBox_import_pids);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Scan_added);
            this.Controls.Add(this.Add_file);
            this.Controls.Add(this.listbox_result_pids);
            this.Name = "FormMemory";
            this.Text = "FormMemory";
            this.Load += new System.EventHandler(this.FormMemory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Scan_all;
        private System.Windows.Forms.ListBox listBox_import_pids;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button Save_file;
        private System.Windows.Forms.Button Scan_added;
        private System.Windows.Forms.Button Add_file;
        private System.Windows.Forms.ListBox listbox_result_pids;
        private System.Windows.Forms.Button Scan_removed;
        private System.Windows.Forms.TextBox textBox_import;
        private FontAwesome.Sharp.IconButton Showactionbtn;
        private System.Windows.Forms.Button Quarantine;
        private System.Windows.Forms.Button Killbtn;
        private System.Windows.Forms.ListBox listBox_action;
    }
}