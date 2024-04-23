namespace Projet_cs
{
    partial class ScanImported
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
            this.listbox_result = new System.Windows.Forms.ListBox();
            this.Add_file = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.Save_file = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.listBox_import = new System.Windows.Forms.ListBox();
            this.Scan_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_result
            // 
            this.listbox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_result.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listbox_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_result.ForeColor = System.Drawing.Color.Gainsboro;
            this.listbox_result.FormattingEnabled = true;
            this.listbox_result.ItemHeight = 20;
            this.listbox_result.Location = new System.Drawing.Point(40, 116);
            this.listbox_result.Name = "listbox_result";
            this.listbox_result.Size = new System.Drawing.Size(358, 180);
            this.listbox_result.TabIndex = 0;
            // 
            // Add_file
            // 
            this.Add_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_file.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Add_file.FlatAppearance.BorderSize = 2;
            this.Add_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_file.ForeColor = System.Drawing.Color.Gainsboro;
            this.Add_file.Location = new System.Drawing.Point(406, 321);
            this.Add_file.Margin = new System.Windows.Forms.Padding(2);
            this.Add_file.Name = "Add_file";
            this.Add_file.Size = new System.Drawing.Size(60, 24);
            this.Add_file.TabIndex = 2;
            this.Add_file.Text = "Add";
            this.Add_file.UseVisualStyleBackColor = true;
            this.Add_file.Click += new System.EventHandler(this.Add_file_Click);
            // 
            // Scan
            // 
            this.Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scan.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Scan.FlatAppearance.BorderSize = 2;
            this.Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan.ForeColor = System.Drawing.Color.Gainsboro;
            this.Scan.Location = new System.Drawing.Point(43, 321);
            this.Scan.Margin = new System.Windows.Forms.Padding(2);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(60, 24);
            this.Scan.TabIndex = 3;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Save_file
            // 
            this.Save_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_file.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Save_file.FlatAppearance.BorderSize = 2;
            this.Save_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_file.ForeColor = System.Drawing.Color.Gainsboro;
            this.Save_file.Location = new System.Drawing.Point(191, 321);
            this.Save_file.Margin = new System.Windows.Forms.Padding(2);
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(60, 24);
            this.Save_file.TabIndex = 4;
            this.Save_file.Text = "Save file";
            this.Save_file.UseVisualStyleBackColor = true;
            this.Save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.remove.FlatAppearance.BorderSize = 2;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.ForeColor = System.Drawing.Color.Gainsboro;
            this.remove.Location = new System.Drawing.Point(477, 321);
            this.remove.Margin = new System.Windows.Forms.Padding(2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(60, 24);
            this.remove.TabIndex = 5;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Clear.FlatAppearance.BorderSize = 2;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.Gainsboro;
            this.Clear.Location = new System.Drawing.Point(550, 321);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 24);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // listBox_import
            // 
            this.listBox_import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_import.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox_import.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_import.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox_import.FormattingEnabled = true;
            this.listBox_import.ItemHeight = 20;
            this.listBox_import.Location = new System.Drawing.Point(406, 116);
            this.listBox_import.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_import.Name = "listBox_import";
            this.listBox_import.Size = new System.Drawing.Size(358, 180);
            this.listBox_import.TabIndex = 7;
            // 
            // Scan_all
            // 
            this.Scan_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Scan_all.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Scan_all.FlatAppearance.BorderSize = 2;
            this.Scan_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan_all.ForeColor = System.Drawing.Color.Gainsboro;
            this.Scan_all.Location = new System.Drawing.Point(117, 321);
            this.Scan_all.Name = "Scan_all";
            this.Scan_all.Size = new System.Drawing.Size(60, 24);
            this.Scan_all.TabIndex = 8;
            this.Scan_all.Text = "Scan All";
            this.Scan_all.UseVisualStyleBackColor = true;
            this.Scan_all.Click += new System.EventHandler(this.Scan_all_Click);
            // 
            // ScanImported
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.Scan_all);
            this.Controls.Add(this.listBox_import);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.Add_file);
            this.Controls.Add(this.listbox_result);
            this.Name = "ScanImported";
            this.Text = "FormScanImported";
            this.Load += new System.EventHandler(this.ScanImported_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ListBox listbox_result;
        private System.Windows.Forms.Button Add_file;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Save_file;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ListBox listBox_import;
        private System.Windows.Forms.Button Scan_all;
    }
}