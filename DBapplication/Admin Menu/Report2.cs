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

namespace DBapplication.Admin_Menu
{
    public partial class Report2 : UserControl
    {
        public Report2()
        {
            InitializeComponent();
            supplier_TransTableAdapter.Fill(gymBrosDBDataSet.Supplier_Trans);
            reportViewer1.RefreshReport();
        }
    }
}
