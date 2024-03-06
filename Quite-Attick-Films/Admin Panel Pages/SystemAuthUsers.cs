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

namespace Quite_Attick_Films.Admin_Panel_Pages
{
    public partial class SystemAuthUsers : KryptonForm
    {
        public SystemAuthUsers()
        {
            InitializeComponent();
            EmployeeList();
            UserList();
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

        private void UserList()
        {
            string query = "SELECT UserName, UserEmail, UserNiC, UserPassword FROM SystemAuthTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    UserDGV.DataSource = dataTable;
                    UserDGV.Refresh();
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
            txtPassword.Text = "";
            txtNIC.Text = "";
        }

        private void EmployeeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = EmployeeDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes 
                txtName.Text = selectedRow.Cells["EmployeeName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["EmployeeEmail"].Value.ToString();
               //  txtContact.Text = selectedRow.Cells["EmployeeContactNO"].Value.ToString();
                txtNIC.Text = selectedRow.Cells["EmployeeNIC"].Value.ToString();
               //  txtAddress.Text = selectedRow.Cells["EmployeeAddress"].Value.ToString();
                // CBGend.Text = selectedRow.Cells["EmployeeGender"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO SystemAuthTbl (UserName, UserEmail, UserNiC, UserPassword) VALUES (@UName, @UEmail, @UNic, @UPass)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@UName", txtName.Text);
                    cmd.Parameters.AddWithValue("@UEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@UNic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@UPass", txtPassword.Text);
                    

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added!");
                }

                // Refresh the User list display
                UserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding User: {ex.Message}");
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
                if (UserDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a User to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this User?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string UNic = UserDGV.SelectedRows[0].Cells["UserNiC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM SystemAuthTbl WHERE UserNiC = @UNic", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@UNic", SqlDbType.VarChar).Value = UNic;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully!");
                }

                // Refresh the Part list display
                UserList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting User: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear_Data();
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
    }
}
