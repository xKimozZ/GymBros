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
    public partial class Report6 : UserControl
    {
        public Report6()
        {
            InitializeComponent();
            body_CompositionTableAdapter.Fill(gymBrosDBDataSet.Body_Composition);
            reportViewer1.RefreshReport();
        }
    }
}
