﻿namespace DBapplication
{
    partial class MemberManage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.AddMember = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add New Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Emergency Contact";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Contact info";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(128, 97);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(90, 20);
            this.txtFname.TabIndex = 26;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(128, 137);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(90, 20);
            this.txtLname.TabIndex = 27;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLname_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(128, 177);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(90, 20);
            this.txtPass.TabIndex = 28;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(433, 90);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(30, 20);
            this.txtAge.TabIndex = 31;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(433, 123);
            this.txtContactInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(90, 20);
            this.txtContactInfo.TabIndex = 32;
            this.txtContactInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactInfo_KeyPress);
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(433, 161);
            this.txtEmergencyContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(90, 20);
            this.txtEmergencyContact.TabIndex = 33;
            this.txtEmergencyContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmergencyContact_KeyPress);
            // 
            // AddMember
            // 
            this.AddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.AddMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddMember.Location = new System.Drawing.Point(100, 269);
            this.AddMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(116, 41);
            this.AddMember.TabIndex = 34;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = false;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(286, 128);
            this.dataGridView1.TabIndex = 35;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(128, 221);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 36;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(190, 219);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 37;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // MemberManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddMember);
            this.Controls.Add(this.txtEmergencyContact);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberManage";
            this.Size = new System.Drawing.Size(646, 389);
            this.Load += new System.EventHandler(this.MemberManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
    }
}
