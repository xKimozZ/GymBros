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
    public partial class AdminStaffMenu : UserControl
    {
        public AdminStaffMenu()
        {
            InitializeComponent();
            panelStaffdel.Hide();
            panelManager.Hide();
            panelAdAdmin.Hide();
            panelAdd.Hide();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            panelManager.Hide();
            panelAdAdmin.Hide();
            panelAdd.Hide();
            panelStaffdel.Show();
            labelID.Visible = true;
            comboBoxID.Visible = true;
            comboBoxID.Enabled = true;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            panelStaffdel.Hide();
            panelAdAdmin.Hide();
            panelAdd.Hide();
            panelManager.Show();
            labelID.Visible = true;
            comboBoxID.Visible = true;
            comboBoxID.Enabled = true;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            panelStaffdel.Hide();
            panelManager.Hide();
            panelAdd.Hide();
            panelAdAdmin.Show();
            labelID.Visible = true;
            comboBoxID.Visible = true;
            comboBoxID.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelStaffdel.Hide();
            panelManager.Hide();
            panelAdAdmin.Hide();
            panelAdd.Show();
            labelID.Visible = false;
            comboBoxID.Visible = false;
            comboBoxID.Enabled = false;
        }
    }
}
