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

namespace DBapplication.Admin_Menu
{
    public partial class AdminEquipmentMenu : UserControl
    {
        Controller controllerObj;
        public AdminEquipmentMenu()
        {
            controllerObj = new Controller();
            InitializeComponent();
            panelMaintain.Hide();
            panelbuy.Hide();
            LoadPendinRequests();
            LoadSuppliers();
        }
        private void LoadPendinRequests()
        {
            DataTable Equipment = controllerObj.GetPendingMaintenanceRequests();
            comboBoxEquipmentID.DisplayMember = "Equipment_ID";
            comboBoxEquipmentID.ValueMember = "Equipment_ID";
            comboBoxEquipmentID.DataSource = Equipment;
            dataGridView2.DataSource = Equipment;
            dataGridView2.Refresh();
        }
        private void LoadSuppliers()
        {
            DataTable Supplier = controllerObj.GetAllSuppliers();
            comboBoxSupplier.DisplayMember = "Supplier_ID";
            comboBoxSupplier.ValueMember = "Supplier_ID";
            comboBoxSupplier.DataSource = Supplier;
            dataGridView1.DataSource = Supplier;
            dataGridView1.Refresh();
        }
        private void buttonmaint_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            if (comboBoxEquipmentID.Text == "")   // Validation part
            {
                MessageBox.Show("No Equipment selected");
                return;
            }

            int equipmentId = Convert.ToInt32(comboBoxEquipmentID.Text);

            // Call the GetSupplierIdByEquipmentId method to get the supplier ID
            int supplierId = controllerObj.GetSupplierIdByEquipmentId(equipmentId);

            if (supplierId == -1)  // -1 indicates an error or an invalid value
            {
                MessageBox.Show("Error retrieving supplier ID. Please check the input and try again.");
                return;
            }

            // Call the GetDmgEstimateByEquipmentId method to get the current damage estimate
            int dmgEstimate = controllerObj.GetDmgEstimateByEquipmentId(equipmentId);

            if (dmgEstimate == -1)  // -1 indicates an error or an invalid value
            {
                MessageBox.Show("Error retrieving damage estimate. Please check the input and try again.");
                return;
            }

            // Determine the transaction type based on the damage estimate
            string transactionType;

            switch (dmgEstimate)
            {
                case 1:
                    transactionType = "Low_severity_maintenance";
                    break;
                case 3:
                    transactionType = "Mid_severity_maintenance";
                    break;
                case 5:
                    transactionType = "High_severity_maintenance";
                    break;
                default:
                    MessageBox.Show("Invalid damage estimate. Please check the input and try again.");
                    return;
            }

            // Insert into Supplier_Trans table
            int insertResult = controllerObj.InsertSupplierTransaction(supplierId, transactionType);

            if (insertResult == 1)
            {
                // Update the status of the equipment to 'Good'
                int updateResult = controllerObj.UpdateEquipmentStatus(equipmentId, "Good");

                if (updateResult == 1)
                {
                    // Update the Status in the Equipment table
                    int completeResult = controllerObj.UpdateEquipmentMaintenanceStatus(equipmentId, "Complete");

                    if (completeResult == 1)
                    {
                        // Delete the record from the Maintains table
                        int deleteResult = controllerObj.DeleteMaintainsRecord(equipmentId);

                        if (deleteResult == 1)
                        {
                            MessageBox.Show($"Transaction inserted successfully! Transaction Type: {transactionType}" +
                                $"\nEquipment status updated to 'Good'" +
                                $"\nMaintenance marked as 'Complete'\nRecord deleted from Maintains table");
                            LoadPendinRequests();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting record from Maintains table. Please check the input and try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error updating equipment maintenance status. Please check the input and try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Error updating equipment status. Please check the input and try again.");
                }
            }
            else
            {
                MessageBox.Show("Error inserting transaction. Please check the input and try again.");
            }
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            panelMaintain.Show();
            panelbuy.Hide();
            panelselect.Visible = true;
            panelselect.Top = buttonmaint.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            // Validate model input
            string model = txtModel.Text.Trim();
            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Please enter a valid model for the equipment.");
                return;
            }

            int supplierId;

            // Validate supplier selection
            if (!int.TryParse(comboBoxSupplier.SelectedValue?.ToString(), out supplierId))
            {
                MessageBox.Show("Please select a valid supplier from the list.");
                return;
            }

            // add a new equipment
            int result = controllerObj.InsertEquipment(model, DateTime.Now, supplierId);

            if (result == 1)
            {
                MessageBox.Show("Equipment bought successfully!");
            }
            else
            {
                MessageBox.Show("Error buying equipment. Please check the input and try again.");
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelMaintain.Hide();
            panelbuy.Show();
            panelselect.Visible = true;
            panelselect.Top = buttonAdd.Top;
        }
    }
}

