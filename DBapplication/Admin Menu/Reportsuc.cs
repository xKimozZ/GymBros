using DBapplication.GymBrosDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Reportsuc : UserControl
    {
        public Reportsuc()
        {
            InitializeComponent();
            staff_TransTableAdapter.Fill(gymBrosDBDataSet.Staff_Trans);
            reportViewer1.RefreshReport();
        }
    }
}
