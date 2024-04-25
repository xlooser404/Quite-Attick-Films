using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films.Pages
{
    public partial class staff : KryptonForm
    {
        public staff()
        {
            InitializeComponent();
            StaffList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void StaffList()
        {
            string query = "SELECT StaffName, StaffEmail, StaffContact, StaffCode, StaffDepartment, Salary FROM StaffTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    StaffDGV.DataSource = dataTable;
                    StaffDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from StaffTbl where StaffCode ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            StaffDGV.DataSource = dataTable;
            StaffDGV.Refresh();
            Connection.Close();

        }

        //Clear Function 
        private void Clear_Data()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtCode.Text = "";
            txtDepartment.Text = "";
            txtsalery.Text = "";
        }

        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear_Data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtContact.Text) ||
                    string.IsNullOrEmpty(txtCode.Text) ||
                    string.IsNullOrEmpty(txtDepartment.Text) ||
                    string.IsNullOrEmpty(txtsalery.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO StaffTbl (StaffName, StaffEmail, StaffContact, StaffCode, StaffDepartment, Salary) VALUES (@staName, @staEmail, @staCode, @staDepa, @staSalery, @staContact)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@staName", txtName.Text);
                    cmd.Parameters.AddWithValue("@staEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@staContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@staCode", txtCode.Text);
                    cmd.Parameters.AddWithValue("@staDepa", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@staSalery", txtsalery.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Added!");
                }

                // Refresh the Staff list display
                StaffList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Staff: {ex.Message}");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (StaffDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Staff to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Staff?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string staCode = StaffDGV.SelectedRows[0].Cells["StaffCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM StaffTbl WHERE StaffCode = @empNIC", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@staCode", SqlDbType.VarChar).Value = staCode;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff deleted successfully!");
                }

                // Refresh the Staff list display
                StaffList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Staff: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        private void StaffDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = StaffDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes 
                txtName.Text = selectedRow.Cells["StaffName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["StaffEmail"].Value.ToString();
                txtContact.Text = selectedRow.Cells["StaffContact"].Value.ToString();
                txtCode.Text = selectedRow.Cells["StaffCode"].Value.ToString();
                txtDepartment.Text = selectedRow.Cells["StaffDepartment"].Value.ToString();
                txtsalery.Text = selectedRow.Cells["Salary"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (StaffDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Staff to update.");
                    return;
                }

                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtContact.Text) ||
                    string.IsNullOrEmpty(txtCode.Text) ||
                    string.IsNullOrEmpty(txtDepartment.Text) ||
                    string.IsNullOrEmpty(txtsalery.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Get model number of the selected Part
                string staCode = StaffDGV.SelectedRows[0].Cells["StaffCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE StaffTbl SET StaffName = @staName, StaffEmail = @staEmail, StaffContact = @staContact, StaffDepartment = @staDepa, Salary = @staSalery WHERE StaffCode = @staCode", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@staName", txtName.Text);
                    cmd.Parameters.AddWithValue("@staEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@staContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@staCode", staCode);
                    cmd.Parameters.AddWithValue("@staDepa", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@staSalery", txtsalery.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff updated successfully!");
                }

                // Refresh the Staff list display
                StaffList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Staff: {ex.Message}");
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
