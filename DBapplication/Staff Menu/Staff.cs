﻿using System;
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
    public partial class Staff : Form
    {
        Controller controllerObj;
      public Staff()
        {

            InitializeComponent();
            controllerObj = new Controller();
            
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            buttonBack.Enabled = false;
            buttonBack.Visible = false;
        }
      
        private void ShowContent(Control content)
        {
            placeholderPanel.Controls.Clear(); // clear current content
            placeholderPanel.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill; // fill placeholder area
            buttonBack.Enabled = true;
            buttonBack.Visible = true;
        }

      
        private void placeholderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            ShowContent(new MemberManage());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            placeholderPanel.Hide();
            MainMenu.Show();
            buttonBack.Enabled = false;
            buttonBack.Visible = false;
        }

        private void EditMember_Click(object sender, EventArgs e)
        {
            ShowContent(new EditMember());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void EditStaffprofile_Click(object sender, EventArgs e)
        {
            ShowContent(new EditStaffOwnProfile());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void Announcment_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffAnnouncmentMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void PTButton_Click(object sender, EventArgs e)
        {
            string role = controllerObj.GetRoleByStaffId(AppSession.UserId);
            if (role.ToLower() != "trainer")
            {
                MessageBox.Show("Access denied, you are not a trainer");
            }
            else
            {

            ShowContent(new PersonaltrainingStaffMenu());
            placeholderPanel.Show();
            MainMenu.Hide();
            }
        }

        private void trans_Click(object sender, EventArgs e)
        {
            ShowContent(new Staff_Transactions());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void maintains_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffMaintenance());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void class_btn_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffClasses());
            placeholderPanel.Show();
            MainMenu.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffES());
            placeholderPanel.Show();
            MainMenu.Hide();
        }
    }
}
