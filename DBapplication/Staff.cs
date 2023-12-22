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
        public Staff()
        {
            InitializeComponent();
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
    }
}