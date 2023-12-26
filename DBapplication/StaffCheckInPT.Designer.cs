namespace DBapplication
{
    partial class StaffCheckInPT
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
            this.checkin = new System.Windows.Forms.Button();
            this.SessionBox = new System.Windows.Forms.ComboBox();
            this.sessionLbl = new System.Windows.Forms.Label();
            this.MemLbl = new System.Windows.Forms.Label();
            this.MemberBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(86, 117);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(75, 23);
            this.checkin.TabIndex = 0;
            this.checkin.Text = "Check in";
            this.checkin.UseVisualStyleBackColor = true;
            this.checkin.Click += new System.EventHandler(this.button1_Click);
            // 
            // SessionBox
            // 
            this.SessionBox.FormattingEnabled = true;
            this.SessionBox.Location = new System.Drawing.Point(67, 79);
            this.SessionBox.Name = "SessionBox";
            this.SessionBox.Size = new System.Drawing.Size(121, 24);
            this.SessionBox.TabIndex = 2;
            // 
            // sessionLbl
            // 
            this.sessionLbl.AutoSize = true;
            this.sessionLbl.Location = new System.Drawing.Point(5, 82);
            this.sessionLbl.Name = "sessionLbl";
            this.sessionLbl.Size = new System.Drawing.Size(56, 16);
            this.sessionLbl.TabIndex = 4;
            this.sessionLbl.Text = "Session";
            // 
            // MemLbl
            // 
            this.MemLbl.AutoSize = true;
            this.MemLbl.Location = new System.Drawing.Point(4, 20);
            this.MemLbl.Name = "MemLbl";
            this.MemLbl.Size = new System.Drawing.Size(57, 16);
            this.MemLbl.TabIndex = 6;
            this.MemLbl.Text = "Member";
            // 
            // MemberBox
            // 
            this.MemberBox.FormattingEnabled = true;
            this.MemberBox.Location = new System.Drawing.Point(66, 17);
            this.MemberBox.Name = "MemberBox";
            this.MemberBox.Size = new System.Drawing.Size(121, 24);
            this.MemberBox.TabIndex = 5;
            this.MemberBox.SelectedIndexChanged += new System.EventHandler(this.MemberBox_SelectedIndexChanged);
            // 
            // StaffCheckInPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemLbl);
            this.Controls.Add(this.MemberBox);
            this.Controls.Add(this.sessionLbl);
            this.Controls.Add(this.SessionBox);
            this.Controls.Add(this.checkin);
            this.Name = "StaffCheckInPT";
            this.Size = new System.Drawing.Size(528, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.ComboBox SessionBox;
        private System.Windows.Forms.Label sessionLbl;
        private System.Windows.Forms.Label MemLbl;
        private System.Windows.Forms.ComboBox MemberBox;
    }
}
