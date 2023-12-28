using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBapplication
{
    public partial class AddSession : UserControl
    {
        Controller controllerObj;
        public AddSession()
        {
            InitializeComponent();
            controllerObj = new Controller();

            // fill members combobox
            DataTable members = controllerObj.getNamesMembers();
            comboBox1.DataSource = members;
            comboBox1.ValueMember = "User_ID";
            comboBox1.DisplayMember = "Fname";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            
            
            int result = controllerObj.AddPrivateSession(Convert.ToInt32(comboBox1.SelectedValue),AppSession.UserId ,dateTimePicker1.Value, false);
            

            if (result == 1)
            {
                MessageBox.Show("Session added successfully!");
              

            }
            else
            {
                MessageBox.Show("Error, Please check the input and try again.");
            }
        }
    }
}
