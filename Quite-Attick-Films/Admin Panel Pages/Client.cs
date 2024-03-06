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
    public partial class Client : KryptonForm
    {
        public Client()
        {
            InitializeComponent();
            ClientList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void ClientList()
        {
            string query = "SELECT ClientName, ClientEmail, ClientContactNO, ClientGender, ClientNIC, ClientAddress FROM ClientTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    ClientDGV.DataSource = dataTable;
                    ClientDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from ClientTbl where ClientNIC ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ClientDGV.DataSource = dataTable;
            ClientDGV.Refresh();
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

        //  Clear data Lable Click Event
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
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ClientTbl (ClientName, ClientEmail, ClientContactNO, ClientGender, ClientNIC, ClientAddress) VALUES (@CliName, @CliEmail, @CliContact, @CliGend, @CliNIC, @CliAdd)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@CliName", txtName.Text);
                    cmd.Parameters.AddWithValue("@CliEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@CliContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@CliNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@CliAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CliGend", CBGend.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client Added!");
                }

                // Refresh the Client list display
                ClientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Client: {ex.Message}");
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

        //  Deelete Button Click Event 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (ClientDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Client to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Client?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string CliNIC = ClientDGV.SelectedRows[0].Cells["ClientNIC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ClientTbl WHERE ClientNIC = @CliNIC", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@CliNIC", SqlDbType.VarChar).Value = CliNIC;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client deleted successfully!");
                }

                // Refresh the Part list display
                ClientList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Client: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        // Data Grid View Cell Click Function 
        private void ClientDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = ClientDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes
                txtName.Text = selectedRow.Cells["ClientName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["ClientEmail"].Value.ToString();
                txtContact.Text = selectedRow.Cells["ClientContactNO"].Value.ToString();
                txtNIC.Text = selectedRow.Cells["ClientNIC"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["ClientAddress"].Value.ToString();
                CBGend.Text = selectedRow.Cells["ClientGender"].Value.ToString();
            }
        }

        //  Update button click Event 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (ClientDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Client to update.");
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
                string CliNIC = ClientDGV.SelectedRows[0].Cells["ClientNIC"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE ClientTbl SET ClientName = @CliName, ClientEmail = @CliEmail, ClientContactNO = @CliContact, ClientAddress = @CliAdd, ClientGender = @CliGend WHERE ClientNIC = @CliNIC", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@CliName", txtName.Text);
                    cmd.Parameters.AddWithValue("@CliEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@CliContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@CliNIC", CliNIC);
                    cmd.Parameters.AddWithValue("@CliAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CliGend", CBGend.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client updated successfully!");
                }

                // Refresh the Client list display
                ClientList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Client: {ex.Message}");
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

        //  Serach Button Function
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
