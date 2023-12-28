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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBack.Enabled = false;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(33, 408);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 28);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.MainMenu.Controls.Add(this.pictureBox1);
            this.MainMenu.Controls.Add(this.label2);
            this.MainMenu.Controls.Add(this.buttonAnnouncement);
            this.MainMenu.Controls.Add(this.buttonEquipment);
            this.MainMenu.Controls.Add(this.buttonStaff);
            this.MainMenu.Controls.Add(this.buttonClasses);
            this.MainMenu.Controls.Add(this.buttonExtra);
            this.MainMenu.Controls.Add(this.buttonReports);
            this.MainMenu.Location = new System.Drawing.Point(0, 27);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 374);
            this.MainMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(280, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Main Menu";
            // 
            // buttonAnnouncement
            // 
            this.buttonAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnouncement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnouncement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonAnnouncement.Location = new System.Drawing.Point(480, 212);
            this.buttonAnnouncement.Name = "buttonAnnouncement";
            this.buttonAnnouncement.Size = new System.Drawing.Size(138, 110);
            this.buttonAnnouncement.TabIndex = 5;
            this.buttonAnnouncement.Text = "Announcements";
            this.buttonAnnouncement.UseVisualStyleBackColor = false;
            this.buttonAnnouncement.Click += new System.EventHandler(this.buttonAnnouncement_Click);
            // 
            // buttonEquipment
            // 
            this.buttonEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonEquipment.Location = new System.Drawing.Point(480, 71);
            this.buttonEquipment.Name = "buttonEquipment";
            this.buttonEquipment.Size = new System.Drawing.Size(138, 110);
            this.buttonEquipment.TabIndex = 4;
            this.buttonEquipment.Text = "Equipment";
            this.buttonEquipment.UseVisualStyleBackColor = false;
            this.buttonEquipment.Click += new System.EventHandler(this.buttonEquipment_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonStaff.Location = new System.Drawing.Point(154, 71);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(138, 110);
            this.buttonStaff.TabIndex = 3;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonClasses.Location = new System.Drawing.Point(154, 212);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(138, 110);
            this.buttonClasses.TabIndex = 2;
            this.buttonClasses.Text = "Classes";
            this.buttonClasses.UseVisualStyleBackColor = false;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // buttonExtra
            // 
            this.buttonExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonExtra.Location = new System.Drawing.Point(317, 212);
            this.buttonExtra.Name = "buttonExtra";
            this.buttonExtra.Size = new System.Drawing.Size(138, 110);
            this.buttonExtra.TabIndex = 1;
            this.buttonExtra.Text = "Extra Services";
            this.buttonExtra.UseVisualStyleBackColor = false;
            this.buttonExtra.Click += new System.EventHandler(this.buttonExtra_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonReports.Location = new System.Drawing.Point(317, 71);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(138, 110);
            this.buttonReports.TabIndex = 0;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(741, -3);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 30);
            this.buttonExit.TabIndex = 28;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // placeholderPanel
            // 
            this.placeholderPanel.Location = new System.Drawing.Point(0, 27);
            this.placeholderPanel.Name = "placeholderPanel";
            this.placeholderPanel.Size = new System.Drawing.Size(799, 375);
            this.placeholderPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(512, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 38);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(798, 446);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}