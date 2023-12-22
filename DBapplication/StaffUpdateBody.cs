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
    public partial class StaffUpdateBody : UserControl
    {
        Controller controllerObj;
        public StaffUpdateBody()
        {
            InitializeComponent();
            // fill members combobox
            controllerObj = new Controller();
            DataTable members = controllerObj.getNamesMembers();
            comboBox1.DataSource = members;
            comboBox1.ValueMember = "User_ID";
            comboBox1.DisplayMember = "Fname";
        }
        public bool ValidateBodyCompositionInput(int height, int weight, float musclePercentage, float bodyFatPercentage)
        {
            // Validate height and weight not negative
            if (height <= 0 || weight <= 0)
            {
                MessageBox.Show("Height and weight must be positive values.");
                return false;
            }

            // Validate muscle percentage and body fat percentage they are percentages between 0 and 100
            if (musclePercentage < 0 || musclePercentage > 100 || bodyFatPercentage < 0 || bodyFatPercentage > 100)
            {
                MessageBox.Show("Muscle percentage and body fat percentage must be between 0 and 100.");
                return false;
            }
            
            return true;
        }
        public bool AreAllTextBoxesNotEmpty(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show($"Please fill in all fields. {textBox.Name} is empty.");
                        return false;
                    }
                }
            }

         
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!AreAllTextBoxesNotEmpty(this)) return;
        
            float.TryParse(textBox3.Text, out float fatPercentage);
            float.TryParse(textBox3.Text, out float MusPercentage);

            if(!ValidateBodyCompositionInput(Convert.ToInt32( textBox1.Text) , Convert.ToInt32(textBox2.Text) , MusPercentage, fatPercentage )) return;
            
            int res = controllerObj.AddOrUpdateBodyComposition(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), MusPercentage,
                fatPercentage,textBox5.Text.ToString(), textBox6.Text.ToString());

            if (res == 1)
            {
                MessageBox.Show("Body Comp Updated successfully!");


            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
