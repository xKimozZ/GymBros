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
    public partial class BodyComp : UserControl
    {
        Controller controllerObj;
        public BodyComp()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMuscle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            if (txtHeight.Text == "" || txtWeight.Text == "" || txtMuscle.Text == "" || txtFat.Text == "" || txtType.Text == "")//validation part
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            int height = Convert.ToInt32(txtHeight.Text);
            int weight = Convert.ToInt32(txtWeight.Text);
            float fat    = Convert.ToSingle(txtFat.Text);
            float muscle = Convert.ToSingle(txtMuscle.Text);
            string type = txtType.Text.Trim();
            string chronic = txtChronic.Text.Trim();

            if (chronic == "")
                chronic = "None";

            float comp = fat + muscle;
            // Validate body compositon
            if (muscle < 0 || muscle > 100)
            {
                MessageBox.Show("Invalid muscle. Please enter positive value between 0 and 100.");
                return;
            }
            if (fat < 0 || fat > 100)
            {
                MessageBox.Show("Invalid fat. Please enter positive value between 0 and 100.");
                return;
            }
            if (comp > 100)
            {
                MessageBox.Show("Invalid composition. Please review your input.");
                return;
            }


            int SessionID = 101; //Temporary.

            // Call the EditMember function with validated input
            int check  = controllerObj.CheckCompExist(SessionID);
            int result;

            if (check != 0) 
                result = controllerObj.UpdateComp(SessionID, height, weight, fat, muscle, type, chronic);
                    else
                result = controllerObj.InsertComp(SessionID, height, weight, fat, muscle, type, chronic);
            // Check the result and provide appropriate feedback to the user
            if (result == 1)
            {
                MessageBox.Show("Member editted successfully!");
                dataGridView1.DataSource = controllerObj.getNamesMembers();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }

        private void BodyComp_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt;
            int sessionID = 101;
            dt = controllerObj.getBodyComp(sessionID);
            txtHeight.Text = dt.Rows[0].Field<int>("Height").ToString();
            txtWeight.Text = dt.Rows[0].Field<int>("Weight").ToString();
            txtFat.Text = dt.Rows[0].Field<double>("BodyFat_Prcntg").ToString();
            txtMuscle.Text = dt.Rows[0].Field<double>("Muscle_Prcntg").ToString();
            txtType.Text = dt.Rows[0].Field<string>("Body_Type");
            txtChronic.Text = dt.Rows[0].Field<string>("Chronic_Disease");
        }
    }
}
