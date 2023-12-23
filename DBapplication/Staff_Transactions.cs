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
    public partial class Staff_Transactions : UserControl
    {
        Controller controllerObj;
        public Staff_Transactions()
        {
            InitializeComponent();
            controllerObj = new Controller();
            // fill members combobox
            DataTable members = controllerObj.getNamesMembers();
            memberCombo.DataSource = members;
            memberCombo.ValueMember = "User_ID";
            memberCombo.DisplayMember = "User_ID";
        }

        private void own_trans_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            
            string date1_str = textBox1.Text.ToString();
            string date2_str = textBox2.Text.ToString();
            DateTime date1;
            DateTime date2;
            bool check_date = false;
            DataTable staff_trans;

            if (DateTime.TryParse(date1_str, out date1) && date2_str == "")
            {
                check_date = true;
            }
            else if (date1_str == "" && DateTime.TryParse(date2_str, out date2))
            {
                check_date = true;
            }
            else if (DateTime.TryParse(date1_str, out date1) && DateTime.TryParse(date2_str, out date2))
            {
                check_date = true;
            }

            if (check_date)
            {
                staff_trans = controllerObj.GetStaffOwnTransactions(date1_str, date2_str, AppSession.UserId);
                dataGridView1.DataSource = staff_trans;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Date Values Or Leave Only One Empty");
            }
        }

        private void mem_trans_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            string date1_str = textBox3.Text.ToString();
            string date2_str = textBox4.Text.ToString();
            DateTime date1;
            DateTime date2;
            bool check_date = false;
            DataTable staff_trans;

            if (DateTime.TryParse(date1_str, out date1) && date2_str == "")
            {
                check_date = true;
            }
            else if (date1_str == "" && DateTime.TryParse(date2_str, out date2))
            {
                check_date = true;
            }
            else if (DateTime.TryParse(date1_str, out date1) && DateTime.TryParse(date2_str, out date2))
            {
                check_date = true;
            }

            if (check_date)
            {
                staff_trans = controllerObj.GetMemberTransactions(date1_str, date2_str, Convert.ToInt32(memberCombo.SelectedValue));
                dataGridView1.DataSource = staff_trans;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Date Values Or Leave Only One Empty");
            }
        }
    }
}
