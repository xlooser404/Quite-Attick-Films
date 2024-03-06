using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films.Pages
{
    public partial class Employee : KryptonForm
    {
        public Employee()
        {
            InitializeComponent();
            EmployeeList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void EmployeeList()
        {
            string query = "SELECT EmployeeName, EmployeeEmail, EmployeeContactNO, EmployeeGender, EmployeeNIC, EmployeeAddress FROM EmployeeTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    EmployeeDGV.DataSource = dataTable;
                    EmployeeDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from EmployeeTbl where EmployeeNIC ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            EmployeeDGV.DataSource = dataTable;
            EmployeeDGV.Refresh();
            Connection.Close();

        }

        //Clear Function 
        private void Clear_Data()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtNIC.Text = "";
            txtAddress.Text = "";
            CBGend.SelectedItem = 0;
        }

        // Clear data Lable Click Event
        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear_Data();
        }

        //  Add Button Click Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtContact.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text) ||
                    CBGend.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeTbl (EmployeeName, EmployeeEmail, EmployeeContactNO, EmployeeGender, EmployeeNIC, EmployeeAddress) VALUES (@empName, @empEmail, @empContact, @empGend, @empNIC, @empAdd)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@empName", txtName.Text);
                    cmd.Parameters.AddWithValue("@empEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@empContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@empNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@empAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@empGend", CBGend.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added!");
                }

                // Refresh the Employee list display
                EmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Employee: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }

            // Clear form fields for the next entry
            Clear_Data();
        }

        // Data Delete Button Click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (EmployeeDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Employee to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string empNIC = EmployeeDGV.SelectedRows[0].Cells["EmployeeNIC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeTbl WHERE EmployeeNIC = @empNIC", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@empNIC", SqlDbType.VarChar).Value = empNIC;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully!");
                }

                // Refresh the Part list display
                EmployeeList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Employee: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        // Data Grid View Cell Click Function 
        private void EmployeeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = EmployeeDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes 
                txtName.Text = selectedRow.Cells["EmployeeName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["EmployeeEmail"].Value.ToString();
                txtContact.Text = selectedRow.Cells["EmployeeContactNO"].Value.ToString();
                txtNIC.Text = selectedRow.Cells["EmployeeNIC"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["EmployeeAddress"].Value.ToString();
                CBGend.Text = selectedRow.Cells["EmployeeGender"].Value.ToString();
            }
        }

        //  Update button click Event 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (EmployeeDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Employee to update.");
                    return;
                }

                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtContact.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text) ||
                    CBGend.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Get model number of the selected Part
                string empNIC = EmployeeDGV.SelectedRows[0].Cells["EmployeeNIC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeTbl SET EmployeeName = @empName, EmployeeEmail = @empEmail, EmployeeContactNO = @empContact, EmployeeAddress = @empAdd, EmployeeGender = @empGend WHERE EmployeeNIC = @empNIC", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@empName", txtName.Text);
                    cmd.Parameters.AddWithValue("@empEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@empContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@empNIC", empNIC);
                    cmd.Parameters.AddWithValue("@empAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@empGend", CBGend.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully!");
                }

                // Refresh the Employee list display
                EmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Employee: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }

            // Clear form fields for the next entry
            Clear_Data();
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
