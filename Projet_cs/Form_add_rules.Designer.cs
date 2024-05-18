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
            this.SuspendLayout();
            // 
            // add_rules_button_child
            // 
            this.add_rules_button_child.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_rules_button_child.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_rules_button_child.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_rules_button_child.ForeColor = System.Drawing.Color.Gainsboro;
            this.add_rules_button_child.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.add_rules_button_child.IconColor = System.Drawing.Color.Gainsboro;
            this.add_rules_button_child.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_rules_button_child.Location = new System.Drawing.Point(302, 178);
            this.add_rules_button_child.Name = "add_rules_button_child";
            this.add_rules_button_child.Size = new System.Drawing.Size(173, 61);
            this.add_rules_button_child.TabIndex = 0;
            this.add_rules_button_child.Text = "Add Rules";
            this.add_rules_button_child.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_rules_button_child.UseVisualStyleBackColor = true;
            this.add_rules_button_child.Click += new System.EventHandler(this.add_rules_button_child_Click);
            // 
            // View_rules_button
            // 
            this.View_rules_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.View_rules_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_rules_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_rules_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.View_rules_button.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.View_rules_button.IconColor = System.Drawing.Color.Gainsboro;
            this.View_rules_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.View_rules_button.Location = new System.Drawing.Point(302, 288);
            this.View_rules_button.Name = "View_rules_button";
            this.View_rules_button.Size = new System.Drawing.Size(173, 61);
            this.View_rules_button.TabIndex = 1;
            this.View_rules_button.Text = "View Rules";
            this.View_rules_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.View_rules_button.UseVisualStyleBackColor = true;
            this.View_rules_button.Click += new System.EventHandler(this.View_rules_button_Click);
            // 
            // Form_add_rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 534);
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
    }
}