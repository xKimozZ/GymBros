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
    public partial class MemberAnnouncements : UserControl
    {
        Controller controllerObj;
        public MemberAnnouncements()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable announcments = controllerObj.GetStaffAnnouncements();
            dataGridView1.DataSource = announcments;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable announcments = controllerObj.GetStaffAnnouncements();
            dataGridView1.DataSource = announcments;
            dataGridView1.Refresh();
        }
    }
}
