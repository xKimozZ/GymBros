namespace DBapplication
{
    partial class AdminStaffMenu
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
            this.panelAdAdmin = new System.Windows.Forms.Panel();
            this.buttonAddadmin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelStaffdel = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelManager = new System.Windows.Forms.Panel();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelAdAdmin.SuspendLayout();
            this.panelStaffdel.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdAdmin
            // 
            this.panelAdAdmin.Controls.Add(this.buttonAddadmin);
            this.panelAdAdmin.Controls.Add(this.label5);
            this.panelAdAdmin.Controls.Add(this.comboBox3);
            this.panelAdAdmin.Location = new System.Drawing.Point(272, 99);
            this.panelAdAdmin.Name = "panelAdAdmin";
            this.panelAdAdmin.Size = new System.Drawing.Size(365, 125);
            this.panelAdAdmin.TabIndex = 24;
            // 
            // buttonAddadmin
            // 
            this.buttonAddadmin.Location = new System.Drawing.Point(132, 69);
            this.buttonAddadmin.Name = "buttonAddadmin";
            this.buttonAddadmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAddadmin.TabIndex = 2;
            this.buttonAddadmin.Text = "Make Admin";
            this.buttonAddadmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(120, 24);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // panelStaffdel
            // 
            this.panelStaffdel.Controls.Add(this.buttonDel);
            this.panelStaffdel.Controls.Add(this.label3);
            this.panelStaffdel.Controls.Add(this.comboBox1);
            this.panelStaffdel.Location = new System.Drawing.Point(272, 99);
            this.panelStaffdel.Name = "panelStaffdel";
            this.panelStaffdel.Size = new System.Drawing.Size(365, 119);
            this.panelStaffdel.TabIndex = 23;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(132, 69);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAdmin.Location = new System.Drawing.Point(48, 271);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(85, 41);
            this.buttonAdmin.TabIndex = 22;
            this.buttonAdmin.Text = "Add Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonProfile.Location = new System.Drawing.Point(48, 217);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(85, 41);
            this.buttonProfile.TabIndex = 21;
            this.buttonProfile.Text = "Profile Manager";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRemove.Location = new System.Drawing.Point(48, 170);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(85, 41);
            this.buttonRemove.TabIndex = 20;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAdd.Location = new System.Drawing.Point(48, 123);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 41);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Staff Management";
            // 
            // panelManager
            // 
            this.panelManager.Controls.Add(this.comboBoxRoles);
            this.panelManager.Controls.Add(this.textBoxSalary);
            this.panelManager.Controls.Add(this.button1);
            this.panelManager.Controls.Add(this.buttonSalary);
            this.panelManager.Controls.Add(this.label4);
            this.panelManager.Controls.Add(this.comboBox2);
            this.panelManager.Location = new System.Drawing.Point(272, 99);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(365, 182);
            this.panelManager.TabIndex = 25;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(218, 84);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(128, 21);
            this.comboBoxRoles.TabIndex = 5;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(31, 84);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(116, 20);
            this.textBoxSalary.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change Role";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonSalary
            // 
            this.buttonSalary.Location = new System.Drawing.Point(25, 127);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(128, 23);
            this.buttonSalary.TabIndex = 2;
            this.buttonSalary.Text = "Change Salary";
            this.buttonSalary.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // AdminStaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAdAdmin);
            this.Controls.Add(this.panelStaffdel);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelManager);
            this.Name = "AdminStaffMenu";
            this.Size = new System.Drawing.Size(719, 376);
            this.panelAdAdmin.ResumeLayout(false);
            this.panelAdAdmin.PerformLayout();
            this.panelStaffdel.ResumeLayout(false);
            this.panelStaffdel.PerformLayout();
            this.panelManager.ResumeLayout(false);
            this.panelManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdAdmin;
        private System.Windows.Forms.Button buttonAddadmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panelStaffdel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
