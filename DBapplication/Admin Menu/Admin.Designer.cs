namespace DBapplication
{
    partial class Admin
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAnnouncement = new System.Windows.Forms.Button();
            this.buttonEquipment = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.buttonExtra = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.placeholderPanel = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(33, 408);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 28);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.label2);
            this.MainMenu.Controls.Add(this.buttonAnnouncement);
            this.MainMenu.Controls.Add(this.buttonEquipment);
            this.MainMenu.Controls.Add(this.buttonStaff);
            this.MainMenu.Controls.Add(this.buttonClasses);
            this.MainMenu.Controls.Add(this.buttonExtra);
            this.MainMenu.Controls.Add(this.buttonReports);
            this.MainMenu.Location = new System.Drawing.Point(33, 26);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(719, 376);
            this.MainMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Main Menu";
            // 
            // buttonAnnouncement
            // 
            this.buttonAnnouncement.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAnnouncement.Location = new System.Drawing.Point(22, 303);
            this.buttonAnnouncement.Name = "buttonAnnouncement";
            this.buttonAnnouncement.Size = new System.Drawing.Size(109, 55);
            this.buttonAnnouncement.TabIndex = 5;
            this.buttonAnnouncement.Text = "Announcements";
            this.buttonAnnouncement.UseVisualStyleBackColor = false;
            this.buttonAnnouncement.Click += new System.EventHandler(this.buttonAnnouncement_Click);
            // 
            // buttonEquipment
            // 
            this.buttonEquipment.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEquipment.Location = new System.Drawing.Point(22, 152);
            this.buttonEquipment.Name = "buttonEquipment";
            this.buttonEquipment.Size = new System.Drawing.Size(109, 46);
            this.buttonEquipment.TabIndex = 4;
            this.buttonEquipment.Text = "Equipment";
            this.buttonEquipment.UseVisualStyleBackColor = false;
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonStaff.Location = new System.Drawing.Point(22, 48);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(109, 46);
            this.buttonStaff.TabIndex = 3;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonClasses.Location = new System.Drawing.Point(22, 256);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(109, 46);
            this.buttonClasses.TabIndex = 2;
            this.buttonClasses.Text = "Classes";
            this.buttonClasses.UseVisualStyleBackColor = false;
            // 
            // buttonExtra
            // 
            this.buttonExtra.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonExtra.Location = new System.Drawing.Point(22, 204);
            this.buttonExtra.Name = "buttonExtra";
            this.buttonExtra.Size = new System.Drawing.Size(109, 46);
            this.buttonExtra.TabIndex = 1;
            this.buttonExtra.Text = "Extra Services";
            this.buttonExtra.UseVisualStyleBackColor = false;
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonReports.Location = new System.Drawing.Point(22, 100);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(109, 46);
            this.buttonReports.TabIndex = 0;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(696, 410);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(56, 26);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // placeholderPanel
            // 
            this.placeholderPanel.Location = new System.Drawing.Point(33, 27);
            this.placeholderPanel.Name = "placeholderPanel";
            this.placeholderPanel.Size = new System.Drawing.Size(719, 375);
            this.placeholderPanel.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(798, 460);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.placeholderPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button buttonAnnouncement;
        private System.Windows.Forms.Button buttonEquipment;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonClasses;
        private System.Windows.Forms.Button buttonExtra;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel placeholderPanel;
    }
}