namespace DBapplication.Admin_Menu
{
    partial class AdminEquipmentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEquipmentMenu));
            this.panelselect = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMaintain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBoxEquipmentID = new System.Windows.Forms.ComboBox();
            this.buttonmaint = new System.Windows.Forms.Button();
            this.panelbuy = new System.Windows.Forms.Panel();
            this.SupplierID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMaintain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelbuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelselect
            // 
            this.panelselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panelselect.Location = new System.Drawing.Point(170, 184);
            this.panelselect.Margin = new System.Windows.Forms.Padding(0);
            this.panelselect.Name = "panelselect";
            this.panelselect.Size = new System.Drawing.Size(7, 54);
            this.panelselect.TabIndex = 69;
            this.panelselect.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.buttonManage);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 375);
            this.panel1.TabIndex = 68;
            // 
            // buttonManage
            // 
            this.buttonManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonManage.FlatAppearance.BorderSize = 0;
            this.buttonManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManage.Font = new System.Drawing.Font("Arial", 9.75F);
            this.buttonManage.Location = new System.Drawing.Point(76, 240);
            this.buttonManage.Margin = new System.Windows.Forms.Padding(1);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(100, 54);
            this.buttonManage.TabIndex = 21;
            this.buttonManage.Text = "Maintain";
            this.buttonManage.UseVisualStyleBackColor = false;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.buttonAdd.Location = new System.Drawing.Point(76, 184);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 54);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Buy";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Equipment Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 130);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panelMaintain
            // 
            this.panelMaintain.Controls.Add(this.label2);
            this.panelMaintain.Controls.Add(this.dataGridView2);
            this.panelMaintain.Controls.Add(this.comboBoxEquipmentID);
            this.panelMaintain.Controls.Add(this.buttonmaint);
            this.panelMaintain.Location = new System.Drawing.Point(253, 29);
            this.panelMaintain.Name = "panelMaintain";
            this.panelMaintain.Size = new System.Drawing.Size(466, 314);
            this.panelMaintain.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Equipment ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(209, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 51;
            // 
            // comboBoxEquipmentID
            // 
            this.comboBoxEquipmentID.FormattingEnabled = true;
            this.comboBoxEquipmentID.Location = new System.Drawing.Point(41, 126);
            this.comboBoxEquipmentID.Name = "comboBoxEquipmentID";
            this.comboBoxEquipmentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipmentID.TabIndex = 49;
            // 
            // buttonmaint
            // 
            this.buttonmaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonmaint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmaint.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonmaint.Location = new System.Drawing.Point(177, 240);
            this.buttonmaint.Name = "buttonmaint";
            this.buttonmaint.Size = new System.Drawing.Size(115, 40);
            this.buttonmaint.TabIndex = 48;
            this.buttonmaint.Text = "Maintain";
            this.buttonmaint.UseVisualStyleBackColor = false;
            this.buttonmaint.Click += new System.EventHandler(this.buttonmaint_Click);
            // 
            // panelbuy
            // 
            this.panelbuy.Controls.Add(this.SupplierID);
            this.panelbuy.Controls.Add(this.label3);
            this.panelbuy.Controls.Add(this.txtModel);
            this.panelbuy.Controls.Add(this.dataGridView1);
            this.panelbuy.Controls.Add(this.comboBoxSupplier);
            this.panelbuy.Controls.Add(this.buttonbuy);
            this.panelbuy.Location = new System.Drawing.Point(253, 29);
            this.panelbuy.Name = "panelbuy";
            this.panelbuy.Size = new System.Drawing.Size(466, 314);
            this.panelbuy.TabIndex = 53;
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSize = true;
            this.SupplierID.Location = new System.Drawing.Point(3, 89);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(56, 13);
            this.SupplierID.TabIndex = 54;
            this.SupplierID.Text = "SupplierID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(67, 155);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 51;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(62, 86);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(105, 21);
            this.comboBoxSupplier.TabIndex = 50;
            // 
            // buttonbuy
            // 
            this.buttonbuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonbuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuy.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonbuy.Location = new System.Drawing.Point(177, 240);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(115, 40);
            this.buttonbuy.TabIndex = 49;
            this.buttonbuy.Text = "$";
            this.buttonbuy.UseVisualStyleBackColor = false;
            this.buttonbuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminEquipmentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.panelselect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMaintain);
            this.Controls.Add(this.panelbuy);
            this.Name = "AdminEquipmentMenu";
            this.Size = new System.Drawing.Size(799, 375);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMaintain.ResumeLayout(false);
            this.panelMaintain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelbuy.ResumeLayout(false);
            this.panelbuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelselect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMaintain;
        private System.Windows.Forms.Button buttonmaint;
        private System.Windows.Forms.ComboBox comboBoxEquipmentID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelbuy;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label SupplierID;
        private System.Windows.Forms.Label label3;
    }
}
