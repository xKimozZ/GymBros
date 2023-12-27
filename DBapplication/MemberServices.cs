using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class MemberServices : UserControl
    {
        Controller controllerObj;
        DataTable services;
        DataTable classes;
        public MemberServices()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void MemberServices_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";

            services = controllerObj.GetAllServices();
            comboBox1.DisplayMember = "Service_Name";
            comboBox1.ValueMember = "Service_Name";
            comboBox1.DataSource = services;


            classes = controllerObj.GetAllClassTypes();
            comboBox2.DisplayMember = "Class_Type";
            comboBox2.ValueMember = "Class_Type";
            comboBox2.DataSource = classes;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedService = (string)comboBox1.SelectedValue;
            DataRow row = services.Rows.Find(selectedService);
            bool availability = Convert.ToBoolean(row["Availability"]);
            string description = row["Description"].ToString();
            int serviceMgrID = Convert.ToInt32(row["Service_Mgr_ID"]);

            int cost = controllerObj.TransactionAmount("Extra_Service_payment");
            string manname = controllerObj.FnameUser(serviceMgrID);
            label3.Text = $"Cost: {cost}, Availability: {availability}, Manager: {manname}";
            label4.Text = $"{description}";
        }
    }
}
