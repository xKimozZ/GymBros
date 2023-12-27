namespace DBapplication.Admin_Menu
{
    partial class Report3
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gymBrosDBDataSet = new DBapplication.GymBrosDBDataSet();
            this.maintainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintainsTableAdapter = new DBapplication.GymBrosDBDataSetTableAdapters.MaintainsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.maintainsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.Maintenance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // gymBrosDBDataSet
            // 
            this.gymBrosDBDataSet.DataSetName = "GymBrosDBDataSet";
            this.gymBrosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintainsBindingSource
            // 
            this.maintainsBindingSource.DataMember = "Maintains";
            this.maintainsBindingSource.DataSource = this.gymBrosDBDataSet;
            // 
            // maintainsTableAdapter
            // 
            this.maintainsTableAdapter.ClearBeforeFill = true;
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report3";
            this.Size = new System.Drawing.Size(799, 376);
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource maintainsBindingSource;
        private GymBrosDBDataSet gymBrosDBDataSet;
        private GymBrosDBDataSetTableAdapters.MaintainsTableAdapter maintainsTableAdapter;
    }
}
