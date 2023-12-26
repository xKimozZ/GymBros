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
    public partial class StaffPTUpdate : UserControl
    {
        Controller controllerObj;
        public StaffPTUpdate()
        {
            InitializeComponent();
            controllerObj = new Controller();

            // Fill members ComboBox
            DataTable members = controllerObj.getNamesMembers();
            MemberBox.DataSource = members;
            MemberBox.ValueMember = "User_ID";
            MemberBox.DisplayMember = "Fname";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
         
            int result = controllerObj.UpdatePrivateSession(Convert.ToInt32(Sessionbox.SelectedValue), dateTimePicker1.Value, false,Convert.ToInt32( MemberBox.SelectedValue));


            if (result == 1)
            {
                MessageBox.Show("Session added successfully!");


            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }

    

        
        private void UpdateSessionsComboBox(int memberId)
        {

            // Fill sessions ComboBox for the specified member
            DataTable sessions = controllerObj.GetSessionsByMemberAndStaff(memberId, AppSession.UserId);
            Sessionbox.DataSource = sessions;
            Sessionbox.ValueMember = "Session_ID";
            Sessionbox.DisplayMember = "Date";
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

