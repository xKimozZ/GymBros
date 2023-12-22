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
    public partial class Reportuc : UserControl
    {
        public Reportuc()
        {
            InitializeComponent();
            reportViewer1.RefreshReport();
        }

    }
}
