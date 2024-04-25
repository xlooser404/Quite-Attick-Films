using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films.Pages
{
    public partial class Property : KryptonForm
    {
        public Property()
        {
            InitializeComponent();
            PropertyList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void PropertyList()
        {
            string query = "SELECT PropertyName, PropertyCode, PurchaseDate, PurchasePrice, RentalPrice, Status, Description FROM PropertyTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    PropertyDGV.DataSource = dataTable;
                    PropertyDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from PropertyTbl where PropertyCode ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            PropertyDGV.DataSource = dataTable;
            PropertyDGV.Refresh();
            Connection.Close();

        }

        //Clear Function 
        private void Clear_Data()
        {
            txtName.Text = "";
            txtCode.Text = "";
            txtPrice.Text = "";
            txtrentprice.Text = "";
            txtDescript.Text = "";
            CBStatus.SelectedItem = 0;
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
                    string.IsNullOrEmpty(txtCode.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text) ||
                    string.IsNullOrEmpty(txtrentprice.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    CBStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PropertyTbl (PropertyName, PropertyCode, PurchaseDate, PurchasePrice, RentalPrice, Status, Description) VALUES (@prpName, @prpCode, @purDate, @purPrice, @rntPrice, @prpStatus, @prpDescript)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@prpName", txtName.Text);
                    cmd.Parameters.AddWithValue("@prpCode", txtCode.Text);
                    cmd.Parameters.AddWithValue("@purPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@rntPrice", txtrentprice.Text);
                    cmd.Parameters.AddWithValue("@prpDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@prpStatus", CBStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@purDate", PurDate.Value.Date);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Property Added!");
                }

                // Refresh the Property list display
                PropertyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Property: {ex.Message}");
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

        // Data Delete Button click Event 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (PropertyDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Property to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Property?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string prpCode = PropertyDGV.SelectedRows[0].Cells["PropertyCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PropertyTbl WHERE PropertyCode = @prpCode", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@prpCode", SqlDbType.VarChar).Value = prpCode;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Property deleted successfully!");
                }

                // Refresh the Property list display
                PropertyList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Property: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        //  Data Grid View Function [Cell Content Click]
        private void PropertyDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = PropertyDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes   
                txtName.Text = selectedRow.Cells["PropertyName"].Value.ToString();
                txtCode.Text = selectedRow.Cells["PropertyCode"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["PurchasePrice"].Value.ToString();
                txtrentprice.Text = selectedRow.Cells["RentalPrice"].Value.ToString();
                txtDescript.Text = selectedRow.Cells["Description"].Value.ToString();
                CBStatus.Text = selectedRow.Cells["Status"].Value.ToString();
                PurDate.Text = selectedRow.Cells["PurchaseDate"].Value.ToString();
            }
        }

        //  Data Update Button Click Event 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (PropertyDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Property to update.");
                    return;
                }

                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtCode.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text) ||
                    string.IsNullOrEmpty(txtrentprice.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    CBStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Get model number of the selected Part
                string prpCode = PropertyDGV.SelectedRows[0].Cells["PropertyCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE PropertyTbl SET PropertyName = @prpName, PurchasePrice = @purPrice, RentalPrice = @rntPrice, Description = @prpDescript, Status = @prpStatus, PurchaseDate = @purDate WHERE PropertyCode = @prpCode", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@prpName", txtName.Text);
                    cmd.Parameters.AddWithValue("@prpCode", prpCode);
                    cmd.Parameters.AddWithValue("@purPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@rntPrice", txtrentprice.Text);
                    cmd.Parameters.AddWithValue("@prpDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@prpStatus", CBStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@purDate", PurDate.Value.Date);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Property updated successfully!");
                }
                // Refresh the Property list display
                PropertyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Property: {ex.Message}");
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

        // Search icon Click Event
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
