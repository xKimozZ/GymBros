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
            comboBox2.DataSource = members;
            comboBox2.ValueMember = "User_ID";
            comboBox2.DisplayMember = "Fname";

            // Fill sessions ComboBox for the initially selected member
            UpdateSessionsComboBox(Convert.ToInt32(comboBox2.SelectedValue));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected member changes
            if (comboBox2.SelectedValue != null)
            {
                // Update sessions ComboBox based on the selected member
                if (comboBox2.SelectedValue is DataRowView dataRowView)
                {
                    // Access the actual value from the DataRowView
                    int memberId = Convert.ToInt32(dataRowView["User_ID"]);
                    MessageBox.Show(memberId.ToString());
                    UpdateSessionsComboBox(memberId);
                }
            }
        }


        private void UpdateSessionsComboBox(int memberId)
        {
            // Fill sessions ComboBox for the specified member
            DataTable sessions = controllerObj.GetSessionsForMember(memberId);
            comboBox1.DataSource = sessions;
            comboBox1.ValueMember = "Session_ID";
            comboBox1.DisplayMember = "Date";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Your existing code for the button click event
            int result = controllerObj.UpdateSessionCheckInStatus(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
            if (result == 1)
            {
                MessageBox.Show("Check-in completed successfully!");
            }
            else
            {
                MessageBox.Show("Error, please check the input and try again.");
            }
        }

        private void StaffCheckInPT_Load(object sender, EventArgs e)
        {
            // Add an event handler for the SelectedIndexChanged event of comboBox2
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }
    }
}
