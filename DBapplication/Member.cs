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
    public partial class Member : Form
    {
        public Member(int ID)
        {
            InitializeComponent();
            //AppSession.Login(ID, "John");
        }

        private void placeholderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowContent(Control content)
        {
            placeholderPanel.Controls.Clear(); // clear current content
            placeholderPanel.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill; // fill placeholder area
            buttonBack.Enabled = true;
            buttonBack.Visible = true;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            buttonBack.Enabled = false;
            buttonBack.Visible = false;
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            ShowContent(new MemberData());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            placeholderPanel.Hide();
            MainMenu.Show();
            buttonBack.Enabled = false;
            buttonBack.Visible = false;
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            ShowContent(new MemberAnnouncements());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffAnnouncmentMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void FitnessProgress_Click(object sender, EventArgs e)
        {
            ShowContent(new BodyComp());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            ShowContent(new MemberPay());
            placeholderPanel.Show();
            MainMenu.Hide();
        }
    }
}
