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
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films.Pages
{
    public partial class Productions : KryptonForm
    {
        public Productions()
        {
            InitializeComponent();
            ProductionDetails();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void ProductionDetails()
        {
            string query = "SELECT ProductionTitle, Description, ProductionType, ProductionCode, ProductionNoDates, ProductionBudget FROM ProductionTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    productionDGV.DataSource = dataTable;
                    productionDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from ProductionTbl where ProductionCode ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            productionDGV.DataSource = dataTable;
            productionDGV.Refresh();
            Connection.Close();

        }

        //Clear Function 
        private void Clear_Data()
        {
            txtProdTitle.Text = "";
            txtDecription.Text = "";
            txtCode.Text = "";
            txtBudget.Text = "";
            txtDuration.Text = "";
            txtType.Text = "";
        }

        // Data Add Button Function
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtProdTitle.Text) ||
                    string.IsNullOrEmpty(txtDecription.Text) ||
                    string.IsNullOrEmpty(txtCode.Text) ||
                    string.IsNullOrEmpty(txtBudget.Text) ||
                    string.IsNullOrEmpty(txtDuration.Text) ||
                    string.IsNullOrEmpty(txtType.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ProductionTbl (ProductionTitle, Description, ProductionType, ProductionCode, ProductionNoDates, ProductionBudget) VALUES (@proTitile, @proDescription, @proType, @proCode, @proDates, @proBudgets)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@proTitile", txtProdTitle.Text);
                    cmd.Parameters.AddWithValue("@proDescription", txtDecription.Text);
                    cmd.Parameters.AddWithValue("@proType", txtType.Text);
                    cmd.Parameters.AddWithValue("@proCode", txtCode.Text);
                    cmd.Parameters.AddWithValue("@proDates", txtDuration.Text);
                    cmd.Parameters.AddWithValue("@proBudgets", txtBudget.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Production Added!");
                }

                // Refresh the Productions list display
                ProductionDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Productions: {ex.Message}");
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

        // Delete Button Click Event 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (productionDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Production to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Production?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string proCode = productionDGV.SelectedRows[0].Cells["ProductionCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ProductionTbl WHERE ProductionCode = @proCode", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@proCode", SqlDbType.VarChar).Value = proCode;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Production deleted successfully!");
                }

                // Refresh the Part list display
                ProductionDetails();
                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Production: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        private void productionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = productionDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes
                txtProdTitle.Text = selectedRow.Cells["ProductionTitle"].Value.ToString();
                txtDecription.Text = selectedRow.Cells["Description"].Value.ToString();
                txtType.Text = selectedRow.Cells["ProductionType"].Value.ToString();
                txtCode.Text = selectedRow.Cells["ProductionCode"].Value.ToString();
                txtDuration.Text = selectedRow.Cells["ProductionNoDates"].Value.ToString();
                txtBudget.Text = selectedRow.Cells["ProductionBudget"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (productionDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Production to update.");
                    return;
                }

                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtProdTitle.Text) ||
                    string.IsNullOrEmpty(txtDecription.Text) ||
                    string.IsNullOrEmpty(txtCode.Text) ||
                    string.IsNullOrEmpty(txtBudget.Text) ||
                    string.IsNullOrEmpty(txtDuration.Text) ||
                    string.IsNullOrEmpty(txtType.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Get model number of the selected Part
                string proCode = productionDGV.SelectedRows[0].Cells["ProductionCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("UPDATE ProductionTbl SET ProductionTitle = @proTitile, Description = @proDescription, ProductionType = @proType, ProductionNoDates = @proDates, ProductionBudget = @proBudgets WHERE ProductionCode = @proCode", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@proTitile", txtProdTitle.Text);
                    cmd.Parameters.AddWithValue("@proDescription", txtDecription.Text);
                    cmd.Parameters.AddWithValue("@proType", txtType.Text);
                    cmd.Parameters.AddWithValue("@proCode", proCode);
                    cmd.Parameters.AddWithValue("@proDates", txtDuration.Text);
                    cmd.Parameters.AddWithValue("@proBudgets", txtBudget.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Production updated successfully!");
                }

                // Refresh the Production list display
                ProductionDetails();
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
        //  Search Button 
        private void PBSearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        //  Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        //  Close Button 
        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear_Data();
        }
    }
}