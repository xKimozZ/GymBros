using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

     
        private void MemberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberBox.SelectedValue != null)
            {
                // Update sessions ComboBox based on the selected member
                int memberId;
                if (MemberBox.SelectedValue is DataRowView dataRowView)
                {
                    // Access the actual value from the DataRowView
                    memberId = Convert.ToInt32(dataRowView["User_ID"]);
                }
                else
                {
                    // If not a DataRowView, directly convert the value
                    memberId = Convert.ToInt32(MemberBox.SelectedValue);
                }

                UpdateSessionsComboBox(memberId);
            }
          
        }
    }
}
