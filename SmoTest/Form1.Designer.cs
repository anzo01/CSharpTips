﻿namespace SmoTest
{
    partial class Form1
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
            this.c_DoItButton = new System.Windows.Forms.Button();
            this.c_ListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c_Tables = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // c_DoItButton
            // 
            this.c_DoItButton.Location = new System.Drawing.Point(578, 9);
            this.c_DoItButton.Name = "c_DoItButton";
            this.c_DoItButton.Size = new System.Drawing.Size(75, 23);
            this.c_DoItButton.TabIndex = 1;
            this.c_DoItButton.Text = "Do It!";
            this.c_DoItButton.UseVisualStyleBackColor = true;
            this.c_DoItButton.Click += new System.EventHandler(this.c_DoItButton_Click);
            // 
            // c_ListBox
            // 
            this.c_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.c_ListBox.FormattingEnabled = true;
            this.c_ListBox.Location = new System.Drawing.Point(12, 38);
            this.c_ListBox.Name = "c_ListBox";
            this.c_ListBox.Size = new System.Drawing.Size(146, 381);
            this.c_ListBox.TabIndex = 2;
            this.c_ListBox.SelectedIndexChanged += new System.EventHandler(this.c_ListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(360, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 380);
            this.textBox1.TabIndex = 3;
            // 
            // c_Tables
            // 
            this.c_Tables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.c_Tables.FormattingEnabled = true;
            this.c_Tables.Location = new System.Drawing.Point(164, 38);
            this.c_Tables.Name = "c_Tables";
            this.c_Tables.Size = new System.Drawing.Size(190, 381);
            this.c_Tables.TabIndex = 4;
            this.c_Tables.SelectedIndexChanged += new System.EventHandler(this.c_Tables_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 430);
            this.Controls.Add(this.c_Tables);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.c_ListBox);
            this.Controls.Add(this.c_DoItButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c_DoItButton;
        private System.Windows.Forms.ListBox c_ListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox c_Tables;
    }
}

