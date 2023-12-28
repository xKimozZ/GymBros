namespace DBapplication
{
    partial class StaffUpdateBody
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.musclePercentage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fatPercentageBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bodyType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.disease = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(90, 61);
            this.Height.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(92, 20);
            this.Height.TabIndex = 1;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(90, 92);
            this.Weight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(92, 20);
            this.Weight.TabIndex = 4;
            this.Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " Muscle_Prcntg";
            // 
            // musclePercentage
            // 
            this.musclePercentage.Location = new System.Drawing.Point(90, 120);
            this.musclePercentage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.musclePercentage.Name = "musclePercentage";
            this.musclePercentage.Size = new System.Drawing.Size(92, 20);
            this.musclePercentage.TabIndex = 6;
            this.musclePercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musclePercentage_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BodyFat_Prcntg";
            // 
            // fatPercentageBox
            // 
            this.fatPercentageBox.Location = new System.Drawing.Point(90, 149);
            this.fatPercentageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fatPercentageBox.Name = "fatPercentageBox";
            this.fatPercentageBox.Size = new System.Drawing.Size(92, 20);
            this.fatPercentageBox.TabIndex = 8;
            this.fatPercentageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatPercentage_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Body_Type";
            // 
            // bodyType
            // 
            this.bodyType.Location = new System.Drawing.Point(90, 182);
            this.bodyType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bodyType.Name = "bodyType";
            this.bodyType.Size = new System.Drawing.Size(92, 20);
            this.bodyType.TabIndex = 10;
            this.bodyType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bodyType_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(209, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update Body Comp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chronic_Disease";
            // 
            // disease
            // 
            this.disease.Location = new System.Drawing.Point(89, 213);
            this.disease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(92, 20);
            this.disease.TabIndex = 13;
            this.disease.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disease_KeyPress);
            // 
            // StaffUpdateBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.disease);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bodyType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fatPercentageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.musclePercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffUpdateBody";
            this.Size = new System.Drawing.Size(416, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musclePercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fatPercentageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bodyType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox disease;
    }
}
