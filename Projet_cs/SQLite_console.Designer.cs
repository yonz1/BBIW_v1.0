namespace Projet_cs
{
    partial class SQLite_console
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
            this.listBox_import = new System.Windows.Forms.ListBox();
            this.textbox_entry = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_import
            // 
            this.listBox_import.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_import.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_import.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox_import.FormattingEnabled = true;
            this.listBox_import.ItemHeight = 20;
            this.listBox_import.Location = new System.Drawing.Point(40, 154);
            this.listBox_import.Name = "listBox_import";
            this.listBox_import.Size = new System.Drawing.Size(687, 324);
            this.listBox_import.TabIndex = 0;
            // 
            // textbox_entry
            // 
            this.textbox_entry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_entry.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textbox_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_entry.ForeColor = System.Drawing.Color.Gainsboro;
            this.textbox_entry.Location = new System.Drawing.Point(40, 84);
            this.textbox_entry.Name = "textbox_entry";
            this.textbox_entry.Size = new System.Drawing.Size(687, 26);
            this.textbox_entry.TabIndex = 1;
            // 
            // submitbtn
            // 
            this.submitbtn.FlatAppearance.BorderSize = 2;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.submitbtn.Location = new System.Drawing.Point(40, 116);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 2;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            // 
            // SQLite_console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.textbox_entry);
            this.Controls.Add(this.listBox_import);
            this.Name = "SQLite_console";
            this.Text = "FormImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_import;
        private System.Windows.Forms.TextBox textbox_entry;
        private System.Windows.Forms.Button submitbtn;
    }
}