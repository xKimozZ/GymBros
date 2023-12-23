namespace DBapplication
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.buttonBack = new System.Windows.Forms.Button();
            this.placeholderPanel = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.PTButton = new System.Windows.Forms.Button();
            this.Announcment = new System.Windows.Forms.Button();
            this.EditStaffprofile = new System.Windows.Forms.Button();
            this.EditMember = new System.Windows.Forms.Button();
            this.AddMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();

            this.trans = new System.Windows.Forms.Button();

            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 420);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 40);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // placeholderPanel
            // 
            this.placeholderPanel.Location = new System.Drawing.Point(1, 1);
            this.placeholderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.placeholderPanel.Name = "placeholderPanel";
            this.placeholderPanel.Size = new System.Drawing.Size(861, 412);
            this.placeholderPanel.TabIndex = 4;
            this.placeholderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.placeholderPanel_Paint);
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.trans);
            this.MainMenu.Controls.Add(this.PTButton);
            this.MainMenu.Controls.Add(this.Announcment);
            this.MainMenu.Controls.Add(this.EditStaffprofile);
            this.MainMenu.Controls.Add(this.EditMember);
            this.MainMenu.Controls.Add(this.AddMember);
            this.MainMenu.Controls.Add(this.label1);
            this.MainMenu.Location = new System.Drawing.Point(36, 57);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(796, 286);
            this.MainMenu.TabIndex = 5;
            // 
            // PTButton
            // 
            this.PTButton.Location = new System.Drawing.Point(634, 101);
            this.PTButton.Name = "PTButton";
            this.PTButton.Size = new System.Drawing.Size(141, 40);
            this.PTButton.TabIndex = 8;
            this.PTButton.Text = "Personal Training";
            this.PTButton.UseVisualStyleBackColor = true;

            this.PTButton.Click += new System.EventHandler(this.PTButton_Click);

            // 
            // Announcment
            // 
            this.Announcment.Location = new System.Drawing.Point(479, 102);
            this.Announcment.Name = "Announcment";
            this.Announcment.Size = new System.Drawing.Size(126, 41);
            this.Announcment.TabIndex = 7;
            this.Announcment.Text = "Announcment";
            this.Announcment.UseVisualStyleBackColor = true;
            this.Announcment.Click += new System.EventHandler(this.Announcment_Click);
            // 
            // EditStaffprofile
            // 
            this.EditStaffprofile.Location = new System.Drawing.Point(316, 101);
            this.EditStaffprofile.Name = "EditStaffprofile";
            this.EditStaffprofile.Size = new System.Drawing.Size(126, 41);
            this.EditStaffprofile.TabIndex = 6;
            this.EditStaffprofile.Text = "Edit My Profile";
            this.EditStaffprofile.UseVisualStyleBackColor = true;
            this.EditStaffprofile.Click += new System.EventHandler(this.EditStaffprofile_Click);
            // 
            // EditMember
            // 
            this.EditMember.Location = new System.Drawing.Point(159, 102);
            this.EditMember.Name = "EditMember";
            this.EditMember.Size = new System.Drawing.Size(129, 41);
            this.EditMember.TabIndex = 6;
            this.EditMember.Text = "Edit Member";
            this.EditMember.UseVisualStyleBackColor = true;
            this.EditMember.Click += new System.EventHandler(this.EditMember_Click);
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(12, 102);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(115, 40);
            this.AddMember.TabIndex = 5;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Menu";
            // 
            // trans
            // 
            this.trans.Location = new System.Drawing.Point(12, 207);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(115, 40);
            this.trans.TabIndex = 9;
            this.trans.Text = "Transactions";
            this.trans.UseVisualStyleBackColor = true;
            this.trans.Click += new System.EventHandler(this.trans_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 472);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.placeholderPanel);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel placeholderPanel;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.Button EditMember;
        private System.Windows.Forms.Button EditStaffprofile;
        private System.Windows.Forms.Button PTButton;
        private System.Windows.Forms.Button Announcment;
        private System.Windows.Forms.Button trans;
    }
}


