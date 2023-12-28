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
    public partial class StaffPTView : UserControl
    {
        Controller controllerObj;
        public StaffPTView()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable Sessions = controllerObj.GetStaffAttendance(AppSession.UserId);
            dataGridView1.DataSource = Sessions;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable Sessions = controllerObj.GetStaffAttendance(AppSession.UserId);
            dataGridView1.DataSource = Sessions;
            dataGridView1.Refresh();
        }
    }
}
