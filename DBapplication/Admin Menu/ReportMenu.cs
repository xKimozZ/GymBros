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
    public partial class ReportMenu : UserControl
    {
        public ReportMenu()
        {
            InitializeComponent();
        }
        private void ShowReportUC(Control content)
        {
            panel2.Controls.Clear();      // clear current content
            panel2.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill;          // fill placeholder area
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowReportUC(new Reportsuc());
            panelselect.Visible = true;
            panelselect.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowReportUC(new Report2());
            panelselect.Visible = true;
            panelselect.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowReportUC(new Report3());
            panelselect.Visible = true;
            panelselect.Top = button3.Top;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ShowReportUC(new Report4());
            panelselect.Visible = true;
            panelselect.Top = button4.Top;
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }


    }
}
