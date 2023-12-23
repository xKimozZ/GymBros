namespace DBapplication
{
    partial class Member
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
            this.MainMenu = new System.Windows.Forms.Panel();
            this.Payment = new System.Windows.Forms.Button();
            this.FitnessProgress = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.Announcements = new System.Windows.Forms.Button();
            this.ManageData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.placeholderPanel = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.Payment);
            this.MainMenu.Controls.Add(this.FitnessProgress);
            this.MainMenu.Controls.Add(this.Services);
            this.MainMenu.Controls.Add(this.Announcements);
            this.MainMenu.Controls.Add(this.ManageData);
            this.MainMenu.Controls.Add(this.label1);
            this.MainMenu.Location = new System.Drawing.Point(51, 71);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(796, 286);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(634, 101);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(141, 40);
            this.Payment.TabIndex = 8;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // FitnessProgress
            // 
            this.FitnessProgress.Location = new System.Drawing.Point(479, 102);
            this.FitnessProgress.Name = "FitnessProgress";
            this.FitnessProgress.Size = new System.Drawing.Size(126, 41);
            this.FitnessProgress.TabIndex = 7;
            this.FitnessProgress.Text = "Fitness Progress";
            this.FitnessProgress.UseVisualStyleBackColor = true;
            this.FitnessProgress.Click += new System.EventHandler(this.FitnessProgress_Click);
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(316, 101);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(126, 41);
            this.Services.TabIndex = 6;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Announcements
            // 
            this.Announcements.Location = new System.Drawing.Point(159, 102);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(129, 41);
            this.Announcements.TabIndex = 6;
            this.Announcements.Text = "Announcements";
            this.Announcements.UseVisualStyleBackColor = true;
            this.Announcements.Click += new System.EventHandler(this.Announcements_Click);
            // 
            // ManageData
            // 
            this.ManageData.Location = new System.Drawing.Point(12, 102);
            this.ManageData.Name = "ManageData";
            this.ManageData.Size = new System.Drawing.Size(115, 40);
            this.ManageData.TabIndex = 5;
            this.ManageData.Text = "Manage Data";
            this.ManageData.UseVisualStyleBackColor = true;
            this.ManageData.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members";
            // 
            // placeholderPanel
            // 
            this.placeholderPanel.Location = new System.Drawing.Point(16, 15);
            this.placeholderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.placeholderPanel.Name = "placeholderPanel";
            this.placeholderPanel.Size = new System.Drawing.Size(861, 412);
            this.placeholderPanel.TabIndex = 7;
            this.placeholderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.placeholderPanel_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(27, 434);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 40);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.placeholderPanel);
            this.Controls.Add(this.buttonBack);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button FitnessProgress;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button Announcements;
        private System.Windows.Forms.Button ManageData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel placeholderPanel;
        private System.Windows.Forms.Button buttonBack;
    }
}