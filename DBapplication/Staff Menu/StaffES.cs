using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
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
    public partial class StaffES : UserControl
    {
        Controller controllerObj;
        public StaffES()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllES();
            serviceCombo.DataSource = dt;
            serviceCombo.ValueMember = "Service_Name";
            serviceCombo.DisplayMember = "Service_Name";

            string extra_service = (serviceCombo.SelectedValue).ToString();
            DataTable members = controllerObj.getAttendingESMembers(extra_service);
            memberCombo.DataSource = members;
            memberCombo.ValueMember = "User_ID";
            memberCombo.DisplayMember = "Fname";

            dt = controllerObj.getAllESAttenders(extra_service);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            string extra_service = (serviceCombo.SelectedValue).ToString();
            int mem_id = Convert.ToInt32(memberCombo.SelectedValue);
            DateTime currentDate = DateTime.Now;
            DateTime subLen = controllerObj.getSubLenES(mem_id, extra_service);
            int num_of_attendances = controllerObj.getNumESAttendances(mem_id, extra_service) + 1;
            if (currentDate < subLen)
            {
                int r = controllerObj.updateNumESAttendances(mem_id, num_of_attendances, extra_service);
                if (r == 1) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
            }
            else
            {
                int r = controllerObj.dropES(mem_id, extra_service);
                MessageBox.Show("Please Renew Membership");
            }
            DataTable dt = controllerObj.getAllESAttenders(extra_service);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void serviceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            string extra_service = (serviceCombo.SelectedValue).ToString();
            DataTable members = controllerObj.getAttendingESMembers(extra_service);
            memberCombo.DataSource = members;
            memberCombo.ValueMember = "User_ID";
            memberCombo.DisplayMember = "Fname";
            DataTable dt = controllerObj.getAllESAttenders(extra_service);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
