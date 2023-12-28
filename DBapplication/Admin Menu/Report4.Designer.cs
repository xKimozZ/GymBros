namespace DBapplication.Admin_Menu
{
    partial class Report4
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gymBrosDBDataSet = new DBapplication.GymBrosDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DBapplication.GymBrosDBDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gymBrosDBDataSet
            // 
            this.gymBrosDBDataSet.DataSetName = "GymBrosDBDataSet";
            this.gymBrosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.Classes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gymBrosDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Report4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report4";
            this.Size = new System.Drawing.Size(799, 376);
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GymBrosDBDataSet gymBrosDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GymBrosDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}
