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
            this.anger_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.anger_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.label3);
            this.MainMenu.Controls.Add(this.anger_panel);
            this.MainMenu.Controls.Add(this.Payment);
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
            this.Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.Payment.Location = new System.Drawing.Point(634, 101);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(147, 63);
            this.Payment.TabIndex = 8;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // FitnessProgress
            // 
            this.FitnessProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.FitnessProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitnessProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.FitnessProgress.Location = new System.Drawing.Point(471, 41);
            this.FitnessProgress.Name = "FitnessProgress";
            this.FitnessProgress.Size = new System.Drawing.Size(132, 64);
            this.FitnessProgress.TabIndex = 7;
            this.FitnessProgress.Text = "Fitness Progress";
            this.FitnessProgress.UseVisualStyleBackColor = false;
            this.FitnessProgress.Click += new System.EventHandler(this.FitnessProgress_Click);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.Services.Location = new System.Drawing.Point(308, 40);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(132, 64);
            this.Services.TabIndex = 6;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Announcements
            // 
            this.Announcements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.Announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Announcements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.Announcements.Location = new System.Drawing.Point(151, 41);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(135, 64);
            this.Announcements.TabIndex = 6;
            this.Announcements.Text = "Announcements";
            this.Announcements.UseVisualStyleBackColor = false;
            this.Announcements.Click += new System.EventHandler(this.Announcements_Click);
            // 
            // ManageData
            // 
            this.ManageData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.ManageData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.ManageData.Location = new System.Drawing.Point(4, 41);
            this.ManageData.Name = "ManageData";
            this.ManageData.Size = new System.Drawing.Size(121, 63);
            this.ManageData.TabIndex = 5;
            this.ManageData.Text = "Manage Data";
            this.ManageData.UseVisualStyleBackColor = false;
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
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(27, 434);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 40);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // anger_panel
            // 
            this.anger_panel.Controls.Add(this.FitnessProgress);
            this.anger_panel.Controls.Add(this.Services);
            this.anger_panel.Controls.Add(this.Announcements);
            this.anger_panel.Controls.Add(this.ManageData);
            this.anger_panel.Location = new System.Drawing.Point(8, 61);
            this.anger_panel.Name = "anger_panel";
            this.anger_panel.Size = new System.Drawing.Size(609, 149);
            this.anger_panel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(286, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 36);
            this.label3.TabIndex = 95;
            this.label3.Text = "PAY UP RIGHT NOW";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.placeholderPanel);
            this.Controls.Add(this.buttonBack);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.anger_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel anger_panel;
        private System.Windows.Forms.Label label3;
    }
}