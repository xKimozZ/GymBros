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
    public partial class StaffCheckInPT : UserControl
    {
        Controller controllerObj;

        public StaffCheckInPT()
        {
            InitializeComponent();
            controllerObj = new Controller();

            // Fill members ComboBox
            DataTable members = controllerObj.getNamesMembers();
            MemberBox.DataSource = members;
            MemberBox.ValueMember = "User_ID";
            MemberBox.DisplayMember = "Fname";
            sessionLbl.Visible = false;
            SessionBox.Visible = false;
            //// Fill sessions ComboBox for the initially selected member
            //UpdateSessionsComboBox(Convert.ToInt32(comboBox2.SelectedValue));
        }



        private void UpdateSessionsComboBox(int memberId)
        {

            // Fill sessions ComboBox for the specified member
            DataTable sessions = controllerObj.GetSessionsByMemberAndStaff(memberId,AppSession.UserId);
            SessionBox.DataSource = sessions;
            SessionBox.ValueMember = "Session_ID";
            SessionBox.DisplayMember = "Date";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Your existing code for the button click event
            int result = controllerObj.UpdateSessionCheckInStatus(Convert.ToInt32(SessionBox.SelectedValue), Convert.ToInt32(MemberBox.SelectedValue));
            if (result == 1)
            {
                MessageBox.Show("Check-in completed successfully!");
            }
            else
            {
                MessageBox.Show("Error, please check the input and try again.");
            }
        }

        private void memberPick_Click(object sender, EventArgs e)
        {
            UpdateSessionsComboBox(Convert.ToInt32(MemberBox.SelectedValue));
            sessionLbl.Visible = true;
            SessionBox.Visible = true;
        }

        private void MemberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessionLbl.Visible = false;
            SessionBox.Visible = false;
        }
    }
}
