namespace DBapplication
{
    partial class StaffMaintenance
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
            this.label3 = new System.Windows.Forms.Label();
            this.dmgCombo = new System.Windows.Forms.ComboBox();
            this.rqust_desc = new System.Windows.Forms.RichTextBox();
            this.dmg_panel = new System.Windows.Forms.Panel();
            this.no_dmg_radio = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dmg_radio = new System.Windows.Forms.RadioButton();
            this.rprt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.equipCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dmg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Maintenance Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Damage Estimate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Request Description";
            // 
            // dmgCombo
            // 
            this.dmgCombo.FormattingEnabled = true;
            this.dmgCombo.Location = new System.Drawing.Point(140, 16);
            this.dmgCombo.Name = "dmgCombo";
            this.dmgCombo.Size = new System.Drawing.Size(148, 24);
            this.dmgCombo.TabIndex = 75;
            // 
            // rqust_desc
            // 
            this.rqust_desc.Location = new System.Drawing.Point(10, 69);
            this.rqust_desc.Name = "rqust_desc";
            this.rqust_desc.Size = new System.Drawing.Size(306, 97);
            this.rqust_desc.TabIndex = 76;
            this.rqust_desc.Text = "";
            // 
            // dmg_panel
            // 
            this.dmg_panel.Controls.Add(this.rqust_desc);
            this.dmg_panel.Controls.Add(this.label2);
            this.dmg_panel.Controls.Add(this.dmgCombo);
            this.dmg_panel.Controls.Add(this.label3);
            this.dmg_panel.Location = new System.Drawing.Point(23, 163);
            this.dmg_panel.Name = "dmg_panel";
            this.dmg_panel.Size = new System.Drawing.Size(345, 187);
            this.dmg_panel.TabIndex = 78;
            // 
            // no_dmg_radio
            // 
            this.no_dmg_radio.AutoSize = true;
            this.no_dmg_radio.Location = new System.Drawing.Point(192, 67);
            this.no_dmg_radio.Name = "no_dmg_radio";
            this.no_dmg_radio.Size = new System.Drawing.Size(153, 20);
            this.no_dmg_radio.TabIndex = 80;
            this.no_dmg_radio.TabStop = true;
            this.no_dmg_radio.Text = "Report No Damages";
            this.no_dmg_radio.UseVisualStyleBackColor = true;
            this.no_dmg_radio.CheckedChanged += new System.EventHandler(this.no_dmg_radio_CheckedChanged);
            // 
            // dmg_radio
            // 
            this.dmg_radio.AutoSize = true;
            this.dmg_radio.Location = new System.Drawing.Point(23, 67);
            this.dmg_radio.Name = "dmg_radio";
            this.dmg_radio.Size = new System.Drawing.Size(132, 20);
            this.dmg_radio.TabIndex = 81;
            this.dmg_radio.TabStop = true;
            this.dmg_radio.Text = "Report Damages";
            this.dmg_radio.UseVisualStyleBackColor = true;
            this.dmg_radio.CheckedChanged += new System.EventHandler(this.dmg_radio_CheckedChanged);
            // 
            // rprt
            // 
            this.rprt.Location = new System.Drawing.Point(23, 356);
            this.rprt.Name = "rprt";
            this.rprt.Size = new System.Drawing.Size(205, 33);
            this.rprt.TabIndex = 82;
            this.rprt.Text = "Generate Report";
            this.rprt.UseVisualStyleBackColor = true;
            this.rprt.Click += new System.EventHandler(this.rprt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Equimpent ID";
            // 
            // equipCombo
            // 
            this.equipCombo.FormattingEnabled = true;
            this.equipCombo.Location = new System.Drawing.Point(163, 123);
            this.equipCombo.Name = "equipCombo";
            this.equipCombo.Size = new System.Drawing.Size(148, 24);
            this.equipCombo.TabIndex = 84;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(438, 253);
            this.dataGridView1.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "Due Maintenance";
            // 
            // StaffMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipCombo);
            this.Controls.Add(this.rprt);
            this.Controls.Add(this.dmg_radio);
            this.Controls.Add(this.no_dmg_radio);
            this.Controls.Add(this.dmg_panel);
            this.Controls.Add(this.label4);
            this.Name = "StaffMaintenance";
            this.Size = new System.Drawing.Size(861, 412);
            this.dmg_panel.ResumeLayout(false);
            this.dmg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dmgCombo;
        private System.Windows.Forms.RichTextBox rqust_desc;
        private System.Windows.Forms.Panel dmg_panel;
        private System.Windows.Forms.RadioButton no_dmg_radio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton dmg_radio;
        private System.Windows.Forms.Button rprt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}
