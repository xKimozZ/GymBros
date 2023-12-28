using DBapplication.Admin_Menu;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            MainMenu.Show();
            placeholderPanel.Hide();
        }
        private void buttonStaff_Click(object sender, EventArgs e)
        {
            ShowContent(new AdminStaffMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void ShowContent(Control content)
        {
            placeholderPanel.Controls.Clear();      // clear current content
            placeholderPanel.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill;          // fill placeholder area
            buttonBack.Enabled = true;
            buttonBack.Visible = true; 
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            placeholderPanel.Hide();
            MainMenu.Show();
            buttonBack.Enabled = false;
            buttonBack.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ShowContent(new ReportMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void buttonAnnouncement_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffAnnouncmentMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            ShowContent(new AdminClassesMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void buttonEquipment_Click(object sender, EventArgs e)
        {
            ShowContent(new AdminEquipmentMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            ShowContent(new AdminExtraMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }
    }
}
