namespace Projet_cs
{
    partial class FormPre_defined
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
            this.Fastbtn = new System.Windows.Forms.Button();
            this.Longbtn = new System.Windows.Forms.Button();
            this.Completebtn = new System.Windows.Forms.Button();
            this.listBox_result_predef = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Fastbtn
            // 
            this.Fastbtn.FlatAppearance.BorderSize = 2;
            this.Fastbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fastbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Fastbtn.Location = new System.Drawing.Point(81, 81);
            this.Fastbtn.Name = "Fastbtn";
            this.Fastbtn.Size = new System.Drawing.Size(75, 23);
            this.Fastbtn.TabIndex = 0;
            this.Fastbtn.Text = "Fast Scan";
            this.Fastbtn.UseVisualStyleBackColor = true;
            this.Fastbtn.Click += new System.EventHandler(this.Fastbtn_Click);
            // 
            // Longbtn
            // 
            this.Longbtn.FlatAppearance.BorderSize = 2;
            this.Longbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Longbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Longbtn.Location = new System.Drawing.Point(81, 122);
            this.Longbtn.Name = "Longbtn";
            this.Longbtn.Size = new System.Drawing.Size(75, 23);
            this.Longbtn.TabIndex = 1;
            this.Longbtn.Text = "Long Scan";
            this.Longbtn.UseVisualStyleBackColor = true;
            this.Longbtn.Click += new System.EventHandler(this.Longbtn_Click);
            // 
            // Completebtn
            // 
            this.Completebtn.FlatAppearance.BorderSize = 2;
            this.Completebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completebtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Completebtn.Location = new System.Drawing.Point(81, 163);
            this.Completebtn.Name = "Completebtn";
            this.Completebtn.Size = new System.Drawing.Size(75, 23);
            this.Completebtn.TabIndex = 2;
            this.Completebtn.Text = "Complete";
            this.Completebtn.UseVisualStyleBackColor = true;
            // 
            // listBox_result_predef
            // 
            this.listBox_result_predef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_result_predef.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox_result_predef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_result_predef.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox_result_predef.FormattingEnabled = true;
            this.listBox_result_predef.ItemHeight = 20;
            this.listBox_result_predef.Location = new System.Drawing.Point(190, 81);
            this.listBox_result_predef.Name = "listBox_result_predef";
            this.listBox_result_predef.Size = new System.Drawing.Size(407, 344);
            this.listBox_result_predef.TabIndex = 3;
            this.listBox_result_predef.SelectedIndexChanged += new System.EventHandler(this.listBox_result_predef_SelectedIndexChanged);
            // 
            // FormPre_defined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.listBox_result_predef);
            this.Controls.Add(this.Completebtn);
            this.Controls.Add(this.Longbtn);
            this.Controls.Add(this.Fastbtn);
            this.Name = "FormPre_defined";
            this.Text = "FormPre_defined";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fastbtn;
        private System.Windows.Forms.Button Longbtn;
        private System.Windows.Forms.Button Completebtn;
        private System.Windows.Forms.ListBox listBox_result_predef;
    }
}