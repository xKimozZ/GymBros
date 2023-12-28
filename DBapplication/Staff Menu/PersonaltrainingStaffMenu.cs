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
    public partial class PersonaltrainingStaffMenu : UserControl
    {
        public PersonaltrainingStaffMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ShowContent(Control content)
        {
            DisplayMenu.Controls.Clear(); // clear current content
            DisplayMenu.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill; // fill placeholder area

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowContent(new AddSession());
          
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffPTUpdate());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffPTView());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffUpdateBody());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowContent(new StaffCheckInPT());
        }
    }
}
