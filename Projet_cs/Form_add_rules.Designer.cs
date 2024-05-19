namespace Projet_cs
{
    partial class Form_add_rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_rules));
            this.add_rules_button_child = new FontAwesome.Sharp.IconButton();
            this.View_rules_button = new FontAwesome.Sharp.IconButton();
            this.Rulenamebox = new System.Windows.Forms.RichTextBox();
            this.Metadatabox = new System.Windows.Forms.RichTextBox();
            this.Stringsbox = new System.Windows.Forms.RichTextBox();
            this.Conditionsbox = new System.Windows.Forms.RichTextBox();
            this.Add_boxbtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // add_rules_button_child
            // 
            this.add_rules_button_child.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_rules_button_child.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_rules_button_child.ForeColor = System.Drawing.Color.Gainsboro;
            this.add_rules_button_child.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.add_rules_button_child.IconColor = System.Drawing.Color.Gainsboro;
            this.add_rules_button_child.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_rules_button_child.IconSize = 40;
            this.add_rules_button_child.Location = new System.Drawing.Point(12, 30);
            this.add_rules_button_child.Name = "add_rules_button_child";
            this.add_rules_button_child.Size = new System.Drawing.Size(162, 43);
            this.add_rules_button_child.TabIndex = 0;
            this.add_rules_button_child.Text = "Add Rules";
            this.add_rules_button_child.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_rules_button_child.UseVisualStyleBackColor = true;
            this.add_rules_button_child.Click += new System.EventHandler(this.add_rules_button_child_Click);
            // 
            // View_rules_button
            // 
            this.View_rules_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_rules_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_rules_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.View_rules_button.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.View_rules_button.IconColor = System.Drawing.Color.Gainsboro;
            this.View_rules_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.View_rules_button.IconSize = 40;
            this.View_rules_button.Location = new System.Drawing.Point(191, 30);
            this.View_rules_button.Name = "View_rules_button";
            this.View_rules_button.Size = new System.Drawing.Size(162, 43);
            this.View_rules_button.TabIndex = 1;
            this.View_rules_button.Text = "View Rules";
            this.View_rules_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.View_rules_button.UseVisualStyleBackColor = true;
            this.View_rules_button.Click += new System.EventHandler(this.View_rules_button_Click);
            // 
            // Rulenamebox
            // 
            this.Rulenamebox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Rulenamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rulenamebox.ForeColor = System.Drawing.Color.Gainsboro;
            this.Rulenamebox.Location = new System.Drawing.Point(12, 117);
            this.Rulenamebox.MaximumSize = new System.Drawing.Size(744, 24);
            this.Rulenamebox.MinimumSize = new System.Drawing.Size(744, 24);
            this.Rulenamebox.Name = "Rulenamebox";
            this.Rulenamebox.Size = new System.Drawing.Size(744, 24);
            this.Rulenamebox.TabIndex = 2;
            this.Rulenamebox.Text = "";
            // 
            // Metadatabox
            // 
            this.Metadatabox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Metadatabox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Metadatabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metadatabox.ForeColor = System.Drawing.Color.Gainsboro;
            this.Metadatabox.Location = new System.Drawing.Point(12, 172);
            this.Metadatabox.MinimumSize = new System.Drawing.Size(744, 59);
            this.Metadatabox.Name = "Metadatabox";
            this.Metadatabox.Size = new System.Drawing.Size(744, 74);
            this.Metadatabox.TabIndex = 3;
            this.Metadatabox.Text = "";
            // 
            // Stringsbox
            // 
            this.Stringsbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stringsbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Stringsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stringsbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.Stringsbox.Location = new System.Drawing.Point(12, 263);
            this.Stringsbox.MinimumSize = new System.Drawing.Size(744, 118);
            this.Stringsbox.Name = "Stringsbox";
            this.Stringsbox.Size = new System.Drawing.Size(744, 118);
            this.Stringsbox.TabIndex = 4;
            this.Stringsbox.Text = "";
            // 
            // Conditionsbox
            // 
            this.Conditionsbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Conditionsbox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Conditionsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conditionsbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.Conditionsbox.Location = new System.Drawing.Point(12, 406);
            this.Conditionsbox.MinimumSize = new System.Drawing.Size(744, 59);
            this.Conditionsbox.Name = "Conditionsbox";
            this.Conditionsbox.Size = new System.Drawing.Size(744, 99);
            this.Conditionsbox.TabIndex = 5;
            this.Conditionsbox.Text = "";
            // 
            // Add_boxbtn
            // 
            this.Add_boxbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_boxbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_boxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_boxbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Add_boxbtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.Add_boxbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Add_boxbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add_boxbtn.IconSize = 40;
            this.Add_boxbtn.Location = new System.Drawing.Point(594, 30);
            this.Add_boxbtn.Name = "Add_boxbtn";
            this.Add_boxbtn.Size = new System.Drawing.Size(162, 43);
            this.Add_boxbtn.TabIndex = 6;
            this.Add_boxbtn.Text = "Add Rules";
            this.Add_boxbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_boxbtn.UseVisualStyleBackColor = true;
            this.Add_boxbtn.Click += new System.EventHandler(this.Add_boxbtn_Click);
            // 
            // Form_add_rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.Add_boxbtn);
            this.Controls.Add(this.Conditionsbox);
            this.Controls.Add(this.Stringsbox);
            this.Controls.Add(this.Metadatabox);
            this.Controls.Add(this.Rulenamebox);
            this.Controls.Add(this.View_rules_button);
            this.Controls.Add(this.add_rules_button_child);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_add_rules";
            this.Text = "Add Rules";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton add_rules_button_child;
        private FontAwesome.Sharp.IconButton View_rules_button;
        private System.Windows.Forms.RichTextBox Rulenamebox;
        private System.Windows.Forms.RichTextBox Metadatabox;
        private System.Windows.Forms.RichTextBox Stringsbox;
        private System.Windows.Forms.RichTextBox Conditionsbox;
        private FontAwesome.Sharp.IconButton Add_boxbtn;
    }
}