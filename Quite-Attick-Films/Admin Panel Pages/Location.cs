using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films.Pages
{
    public partial class Location : KryptonForm
    {
        public Location()
        {
            InitializeComponent();
            LocatioList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void LocatioList()
        {
            string query = "SELECT LocationName, LocationCode, LocationFees, LocationType, LocationAddress, Description FROM LocationTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    LocationDGV.DataSource = dataTable;
                    LocationDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from LocationTbl where LocationCode ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            LocationDGV.DataSource = dataTable;
            LocationDGV.Refresh();
            Connection.Close();

        }

        //Clear Function 
        private void Clear_Data()
        {
            txtLocName.Text = "";
            txtLocCode.Text = "";
            txtFeez.Text = "";
            txtAddress.Text = "";
            txtDescript.Text = "";
            CBLtype.SelectedItem = 0;
        }
        // Clear data link lable click event 
        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear_Data();
        }

        //  Data add button click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtLocName.Text) ||
                    string.IsNullOrEmpty(txtLocCode.Text) ||
                    string.IsNullOrEmpty(txtFeez.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    CBLtype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO LocationTbl (LocationName, LocationCode, LocationFees, LocationType, LocationAddress, Description) VALUES (@LoName, @LoCode, @LoFees, @LoType, @LoAddress, @LoDescript)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@LoName", txtLocName.Text);
                    cmd.Parameters.AddWithValue("@LoCode", txtLocCode.Text);
                    cmd.Parameters.AddWithValue("@LoFees", txtFeez.Text);
                    cmd.Parameters.AddWithValue("@LoAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@LoDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@LoType", CBLtype.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location Added!");
                }

                // Refresh the Locations list display
                LocatioList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Location: {ex.Message}");
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

        //  Data Delete Button Click Event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (LocationDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Location to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Location?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string LoCode = LocationDGV.SelectedRows[0].Cells["LocationCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM LocationTbl WHERE LocationCode = @LoCode", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@LoCode", SqlDbType.VarChar).Value = LoCode;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location deleted successfully!");
                }

                // Refresh the Location list display
                LocatioList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Location: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        private void LocationDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = LocationDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes
                txtLocName.Text = selectedRow.Cells["LocationName"].Value.ToString();
                txtLocCode.Text = selectedRow.Cells["LocationCode"].Value.ToString();
                txtFeez.Text = selectedRow.Cells["LocationFees"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["LocationAddress"].Value.ToString();
                txtDescript.Text = selectedRow.Cells["Description"].Value.ToString();
                CBLtype.Text = selectedRow.Cells["LocationType"].Value.ToString();
            }
        }

        // Data Update Button Click 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (LocationDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Location to update.");
                    return;
                }

                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtLocName.Text) ||
                    string.IsNullOrEmpty(txtLocCode.Text) ||
                    string.IsNullOrEmpty(txtFeez.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    CBLtype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Get model number of the selected Part
                string LoCode = LocationDGV.SelectedRows[0].Cells["LocationCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE LocationTbl SET LocationName = @LoName, LocationFees = @LoFees, LocationAddress = @LoAddress, Description = @LoDescript, LocationType = @LoType WHERE LocationCode = @LoCode", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@LoName", txtLocName.Text);
                    cmd.Parameters.AddWithValue("@LoFees", txtFeez.Text);
                    cmd.Parameters.AddWithValue("@LoAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@LoCode", LoCode);
                    cmd.Parameters.AddWithValue("@LoDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@LoType", CBLtype.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location updated successfully!");
                }

                // Refresh the Location list display
                LocatioList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Location: {ex.Message}");
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
