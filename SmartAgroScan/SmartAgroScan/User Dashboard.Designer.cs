﻿namespace SmartAgroScan
{
    partial class User_Dashboard
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
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1045, 245);
            dataGridView1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1163, 496);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 37);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(908, 473);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 19;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // User_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 545);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Name = "User_Dashboard";
            Text = "User_Dashboard_for_ADMIN";
            Load += User_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBack;
        private Button button1;
    }
}