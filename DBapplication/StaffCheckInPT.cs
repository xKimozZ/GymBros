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

           

            // fill sessions combobox
            DataTable Sessions = controllerObj.GetSessionsByStaff(AppSession.UserId);
            comboBox1.DataSource = Sessions;
            comboBox1.ValueMember = "Session_ID";
            comboBox1.DisplayMember = "Date";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result =controllerObj.UpdateSessionCheckInStatus(Convert.ToInt32(comboBox1.SelectedValue));
            if (result == 1)
            {
                MessageBox.Show("Check in completed successfully!");
            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
