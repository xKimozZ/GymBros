namespace DBapplication
{
    partial class MemberBodyComp
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
            this.txtMuscle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            this.txtChronic = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMuscle
            // 
            this.txtMuscle.Location = new System.Drawing.Point(98, 174);
            this.txtMuscle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMuscle.Name = "txtMuscle";
            this.txtMuscle.Size = new System.Drawing.Size(90, 20);
            this.txtMuscle.TabIndex = 97;
            this.txtMuscle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMuscle_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 96;
            this.label9.Text = "Muscle %";
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Editbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Editbutton.Location = new System.Drawing.Point(214, 264);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(116, 41);
            this.Editbutton.TabIndex = 92;
            this.Editbutton.Text = "Edit Member";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // txtChronic
            // 
            this.txtChronic.Location = new System.Drawing.Point(393, 98);
            this.txtChronic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChronic.Name = "txtChronic";
            this.txtChronic.Size = new System.Drawing.Size(90, 20);
            this.txtChronic.TabIndex = 91;
            this.txtChronic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChronic_KeyPress);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(393, 60);
            this.txtType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(90, 20);
            this.txtType.TabIndex = 90;
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(98, 143);
            this.txtFat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(90, 20);
            this.txtFat.TabIndex = 88;
            this.txtFat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFat_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(98, 103);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(90, 20);
            this.txtWeight.TabIndex = 87;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(98, 63);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(90, 20);
            this.txtHeight.TabIndex = 86;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Body type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Chronic disease";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Body Fat %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Edit Data";
            // 
            // MemberBodyComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.txtMuscle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.txtChronic);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberBodyComp";
            this.Size = new System.Drawing.Size(590, 340);
            this.Load += new System.EventHandler(this.BodyComp_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BodyComp_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMuscle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.TextBox txtChronic;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
