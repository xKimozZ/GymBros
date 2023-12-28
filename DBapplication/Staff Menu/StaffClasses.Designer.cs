namespace DBapplication
{
    partial class StaffClasses
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.memberCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_radio = new System.Windows.Forms.RadioButton();
            this.CheckIn_pnl = new System.Windows.Forms.Panel();
            this.check_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckIn_radio = new System.Windows.Forms.RadioButton();
            this.updt_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.updt_panel = new System.Windows.Forms.Panel();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.CheckIn_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updt_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 87;
            this.label4.Text = "Classes Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Member Name";
            // 
            // memberCombo
            // 
            this.memberCombo.FormattingEnabled = true;
            this.memberCombo.Location = new System.Drawing.Point(111, 14);
            this.memberCombo.Name = "memberCombo";
            this.memberCombo.Size = new System.Drawing.Size(265, 24);
            this.memberCombo.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "New Date";
            // 
            // Update_radio
            // 
            this.Update_radio.AutoSize = true;
            this.Update_radio.Location = new System.Drawing.Point(177, 73);
            this.Update_radio.Name = "Update_radio";
            this.Update_radio.Size = new System.Drawing.Size(125, 20);
            this.Update_radio.TabIndex = 89;
            this.Update_radio.TabStop = true;
            this.Update_radio.Text = "Update Classes";
            this.Update_radio.UseVisualStyleBackColor = true;
            this.Update_radio.CheckedChanged += new System.EventHandler(this.Update_radio_CheckedChanged);
            // 
            // CheckIn_pnl
            // 
            this.CheckIn_pnl.Controls.Add(this.label2);
            this.CheckIn_pnl.Controls.Add(this.memberCombo);
            this.CheckIn_pnl.Controls.Add(this.check_btn);
            this.CheckIn_pnl.Location = new System.Drawing.Point(14, 139);
            this.CheckIn_pnl.Name = "CheckIn_pnl";
            this.CheckIn_pnl.Size = new System.Drawing.Size(379, 150);
            this.CheckIn_pnl.TabIndex = 88;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(3, 44);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(205, 33);
            this.check_btn.TabIndex = 91;
            this.check_btn.Text = "Check In";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Current Classes / Class Attenders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(438, 278);
            this.dataGridView1.TabIndex = 94;
            // 
            // CheckIn_radio
            // 
            this.CheckIn_radio.AutoSize = true;
            this.CheckIn_radio.Location = new System.Drawing.Point(14, 73);
            this.CheckIn_radio.Name = "CheckIn_radio";
            this.CheckIn_radio.Size = new System.Drawing.Size(139, 20);
            this.CheckIn_radio.TabIndex = 90;
            this.CheckIn_radio.TabStop = true;
            this.CheckIn_radio.Text = "Check In Members";
            this.CheckIn_radio.UseVisualStyleBackColor = true;
            this.CheckIn_radio.CheckedChanged += new System.EventHandler(this.CheckIn_radio_CheckedChanged);
            // 
            // updt_btn
            // 
            this.updt_btn.Location = new System.Drawing.Point(3, 111);
            this.updt_btn.Name = "updt_btn";
            this.updt_btn.Size = new System.Drawing.Size(205, 33);
            this.updt_btn.TabIndex = 96;
            this.updt_btn.Text = "Update";
            this.updt_btn.UseVisualStyleBackColor = true;
            this.updt_btn.Click += new System.EventHandler(this.updt_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 97;
            // 
            // updt_panel
            // 
            this.updt_panel.Controls.Add(this.timeBox);
            this.updt_panel.Controls.Add(this.label6);
            this.updt_panel.Controls.Add(this.label3);
            this.updt_panel.Controls.Add(this.updt_btn);
            this.updt_panel.Controls.Add(this.dateTimePicker1);
            this.updt_panel.Location = new System.Drawing.Point(14, 139);
            this.updt_panel.Name = "updt_panel";
            this.updt_panel.Size = new System.Drawing.Size(379, 150);
            this.updt_panel.TabIndex = 98;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(111, 50);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(265, 22);
            this.timeBox.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = "New Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Select Class";
            // 
            // classCombo
            // 
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Location = new System.Drawing.Point(125, 109);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(265, 24);
            this.classCombo.TabIndex = 100;
            this.classCombo.SelectedIndexChanged += new System.EventHandler(this.classCombo_SelectedIndexChanged);
            // 
            // StaffClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classCombo);
            this.Controls.Add(this.updt_panel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Update_radio);
            this.Controls.Add(this.CheckIn_pnl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CheckIn_radio);
            this.Name = "StaffClasses";
            this.Size = new System.Drawing.Size(861, 412);
            this.CheckIn_pnl.ResumeLayout(false);
            this.CheckIn_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updt_panel.ResumeLayout(false);
            this.updt_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox memberCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Update_radio;
        private System.Windows.Forms.Panel CheckIn_pnl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.RadioButton CheckIn_radio;
        private System.Windows.Forms.Button updt_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel updt_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeBox;
    }
}
