﻿namespace DBapplication
{
    partial class Reportuc
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
            this.gymBrosDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymBrosDBDataSet = new DBapplication.GymBrosDBDataSet();
            this.Financial_RecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Financial_RecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gymBrosDBDataSetBindingSource
            // 
            this.gymBrosDBDataSetBindingSource.DataSource = this.gymBrosDBDataSet;
            this.gymBrosDBDataSetBindingSource.Position = 0;
            // 
            // gymBrosDBDataSet
            // 
            this.gymBrosDBDataSet.DataSetName = "GymBrosDBDataSet";
            this.gymBrosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Financial_RecordsBindingSource
            // 
            this.Financial_RecordsBindingSource.DataMember = "Financial_Records";
            this.Financial_RecordsBindingSource.DataSource = this.gymBrosDBDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gymBrosDBDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(678, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reportuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportuc";
            this.Size = new System.Drawing.Size(678, 514);
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBrosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Financial_RecordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource gymBrosDBDataSetBindingSource;
        private GymBrosDBDataSet gymBrosDBDataSet;
        private System.Windows.Forms.BindingSource Financial_RecordsBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
