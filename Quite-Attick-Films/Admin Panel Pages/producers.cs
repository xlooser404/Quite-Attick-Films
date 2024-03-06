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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Quite_Attick_Films.Pages
{
    public partial class producers : KryptonForm
    {
        public producers()
        {
            InitializeComponent();
            ProducersList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void ProducersList()
        {
            string query = "SELECT ProducerName, ProducerEmail, ProducerContact, ProducerGend, ProducerNIC, ProducerAddress FROM ProducerTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    ProducersDGV.DataSource = dataTable;
                    ProducersDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from ProducerTbl where ProducerNIC ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ProducersDGV.DataSource = dataTable;
            ProducersDGV.Refresh();
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

        //  Clear Data Link label Click Event
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
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ProducerTbl (ProducerName, ProducerEmail, ProducerContact, ProducerGend, ProducerNIC, ProducerAddress) VALUES (@pdsName, @pdsEmail, @pdsContact, @pdsGend, @pdsNIC, @pdsAdd)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@pdsName", txtName.Text);
                    cmd.Parameters.AddWithValue("@pdsEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pdsContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@pdsNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@pdsAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@pdsGend", CBGend.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producer Added!");
                }

                // Refresh the Producers list display
                ProducersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Producers: {ex.Message}");
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
                if (ProducersDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Producer to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Producer?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string pdsNIC = ProducersDGV.SelectedRows[0].Cells["ProducerNIC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ProducerTbl WHERE ProducerNIC = @pdsNIC", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@pdsNIC", SqlDbType.VarChar).Value = pdsNIC;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producer deleted successfully!");
                }

                // Refresh the Part list display
                ProducersList();
                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Producer: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        private void ProducersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = ProducersDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes
                txtName.Text = selectedRow.Cells["ProducerName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["ProducerEmail"].Value.ToString();
                txtContact.Text = selectedRow.Cells["ProducerContact"].Value.ToString();
                txtNIC.Text = selectedRow.Cells["ProducerNIC"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["ProducerAddress"].Value.ToString();
                CBGend.Text = selectedRow.Cells["ProducerGend"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (ProducersDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Producer to update.");
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
                string pdsNIC = ProducersDGV.SelectedRows[0].Cells["ProducerNIC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE ProducerTbl SET ProducerName = @pdsName, ProducerEmail = @pdsEmail, ProducerContact = @pdsContact, ProducerAddress = @pdsAdd, ProducerGend = @pdsGend WHERE ProducerNIC = @pdsNIC", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@pdsName", txtName.Text);
                    cmd.Parameters.AddWithValue("@pdsEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pdsContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@pdsNIC", pdsNIC);
                    cmd.Parameters.AddWithValue("@pdsAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@pdsGend", CBGend.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producer updated successfully!");
                }

                // Refresh the Producer list display
                ProducersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Production: {ex.Message}");
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
