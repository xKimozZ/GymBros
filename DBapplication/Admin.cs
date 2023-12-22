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
            ShowContent(new Reportuc());
            placeholderPanel.Show();
            MainMenu.Hide();
        }
    }
}
