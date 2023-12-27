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
    public partial class StaffMaintenance : UserControl
    {
        Controller controllerObj;
        public StaffMaintenance()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getEquimpent();
            equipCombo.DataSource = dt;
            equipCombo.ValueMember = "Equipment_ID";
            equipCombo.DisplayMember = "Model";
            int[] values = { 1, 3, 5 };
            dmgCombo.DataSource = values;
            no_dmg_radio.Checked = true;
            DateTime currentDate = DateTime.Now;
            dt = controllerObj.getStaffRequiredMaintain(currentDate);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void rprt_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int equimpent_id = Convert.ToInt32(equipCombo.SelectedValue);
            DateTime currentDate = DateTime.Now;
            DateTime nextMonth = currentDate.AddMonths(1);
            if (dmg_radio.Checked)
            {
                int reporter_id = AppSession.UserId;
                int dmg_estimate = Convert.ToInt32(dmgCombo.SelectedValue);
                string desc = rqust_desc.Text.ToString();
                if (desc == "")
                {
                    MessageBox.Show("You must add a description");
                }
                else
                {
                    int r = 0;
                    r += controllerObj.generateMaintenanceRequest(reporter_id, equimpent_id, currentDate, dmg_estimate, desc, "Pending");
                    r += controllerObj.updateEquimpentMaintenanceDate(equimpent_id, nextMonth);
                    if (r == 2) MessageBox.Show("Success");
                    else MessageBox.Show("Fail");
                }
            }
            else
            {
                int r = 0;
                r += controllerObj.updateEquimpentMaintenanceDate(equimpent_id, nextMonth);
                if (r == 1) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
            }

            DataTable dt = controllerObj.getStaffRequiredMaintain(currentDate);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void no_dmg_radio_CheckedChanged(object sender, EventArgs e)
        {
            dmg_panel.Hide();
        }

        private void dmg_radio_CheckedChanged(object sender, EventArgs e)
        {
            dmg_panel.Show();
        }
    }
}
