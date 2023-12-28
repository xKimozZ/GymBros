using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Admin_Menu
{
    public partial class Report7 : UserControl
    {
        public Report7()
        {
            InitializeComponent();
            equipmentTableAdapter.Fill(gymBrosDBDataSet.Equipment);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)gymBrosDBDataSet.Equipment));
            reportViewer1.RefreshReport();
        }
    }
}
