﻿namespace DBapplication
{
    partial class StaffES
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.serviceCombo = new System.Windows.Forms.ComboBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CheckIn_pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.memberCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckIn_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Select Service";
            // 
            // serviceCombo
            // 
            this.serviceCombo.FormattingEnabled = true;
            this.serviceCombo.Location = new System.Drawing.Point(98, 94);
            this.serviceCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceCombo.Name = "serviceCombo";
            this.serviceCombo.Size = new System.Drawing.Size(200, 21);
            this.serviceCombo.TabIndex = 109;
            this.serviceCombo.SelectedIndexChanged += new System.EventHandler(this.serviceCombo_SelectedIndexChanged);
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.check_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_btn.Location = new System.Drawing.Point(57, 60);
            this.check_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(154, 27);
            this.check_btn.TabIndex = 91;
            this.check_btn.Text = "Check In";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "Extra Services Menu";
            // 
            // CheckIn_pnl
            // 
            this.CheckIn_pnl.Controls.Add(this.label2);
            this.CheckIn_pnl.Controls.Add(this.memberCombo);
            this.CheckIn_pnl.Controls.Add(this.check_btn);
            this.CheckIn_pnl.Location = new System.Drawing.Point(14, 119);
            this.CheckIn_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckIn_pnl.Name = "CheckIn_pnl";
            this.CheckIn_pnl.Size = new System.Drawing.Size(284, 122);
            this.CheckIn_pnl.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Member Name";
            // 
            // memberCombo
            // 
            this.memberCombo.FormattingEnabled = true;
            this.memberCombo.Location = new System.Drawing.Point(83, 11);
            this.memberCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberCombo.Name = "memberCombo";
            this.memberCombo.Size = new System.Drawing.Size(200, 21);
            this.memberCombo.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Servie Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(328, 226);
            this.dataGridView1.TabIndex = 105;
            // 
            // StaffES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckIn_pnl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffES";
            this.Size = new System.Drawing.Size(646, 335);
            this.CheckIn_pnl.ResumeLayout(false);
            this.CheckIn_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serviceCombo;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel CheckIn_pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox memberCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
