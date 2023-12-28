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
    public partial class StaffAnnouncmentMenu : UserControl
    {
        Controller controllerObj;

        public StaffAnnouncmentMenu()
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

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            } ;
            int result = controllerObj.SendAnnouncement(AppSession.UserId,richTextBox1.Text);
            if (result == 1)
            {
                MessageBox.Show("Annoucment sent successfully!");
                DataTable announcments = controllerObj.GetStaffAnnouncements();
                dataGridView1.DataSource = announcments;
                dataGridView1.Refresh();

            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
