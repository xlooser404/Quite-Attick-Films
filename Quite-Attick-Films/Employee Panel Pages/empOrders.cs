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

namespace Quite_Attick_Films.Employee_Panel_Pages
{
    public partial class empOrders : KryptonForm
    {
        public empOrders()
        {
            InitializeComponent();
            OrderList();
        }
        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection

        //Display Production Registration Details
        private void OrderList()
        {
            string query = "SELECT OrderName, OrderCode, OrderPrice, OrderType, ClientNIC, Description FROM OrderTbl";
            using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    OrderDGV.DataSource = dataTable;
                    OrderDGV.Refresh();
                }
            }

        }
        //Search Function
        private void TextboxFilter()
        {
            Connection.Open();
            string query = " SELECT * from OrderTbl where OrderCode ='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            OrderDGV.DataSource = dataTable;
            OrderDGV.Refresh();
            Connection.Close();

        }

        //Clear Function 
        private void Clear_Data()
        {
            txtOrdName.Text = "";
            txtOrdCode.Text = "";
            txtPrice.Text = "";
            txtNIC.Text = "";
            txtDescript.Text = "";
            Ordtype.SelectedItem = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtOrdName.Text) ||
                    string.IsNullOrEmpty(txtOrdCode.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    Ordtype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl (OrderName, OrderCode, OrderPrice, OrderType, ClientNIC, Description) VALUES (@OrdName, @OrdCode, @OrdPrice, @OrdType, @CLINic, @OrdDescript)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@OrdName", txtOrdName.Text);
                    cmd.Parameters.AddWithValue("@OrdCode", txtOrdCode.Text);
                    cmd.Parameters.AddWithValue("@OrdPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@CLINic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@OrdDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@OrdType", Ordtype.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added!");
                }

                // Refresh the Orders list display
                OrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Orders: {ex.Message}");
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
                if (OrderDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Order to delete.");
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Order?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Get the model number of the selected Part
                string OrdCode = OrderDGV.SelectedRows[0].Cells["OrderCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameter
                using (SqlCommand cmd = new SqlCommand("DELETE FROM OrderTbl WHERE OrderCode = @OrdCode", Connection))
                {
                    // Add parameter with appropriate data type
                    cmd.Parameters.Add("@OrdCode", SqlDbType.VarChar).Value = OrdCode;

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order deleted successfully!");
                }

                // Refresh the Location list display
                OrderList();

                // Clear Data in Text boxes
                Clear_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Orders: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }
        }

        private void OrderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = OrderDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes 
                txtOrdName.Text = selectedRow.Cells["OrderName"].Value.ToString();
                txtOrdCode.Text = selectedRow.Cells["OrderCode"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["OrderPrice"].Value.ToString();
                txtNIC.Text = selectedRow.Cells["ClientNIC"].Value.ToString();
                txtDescript.Text = selectedRow.Cells["Description"].Value.ToString();
                Ordtype.Text = selectedRow.Cells["OrderType"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (OrderDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Order to update.");
                    return;
                }

                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtOrdName.Text) ||
                    string.IsNullOrEmpty(txtOrdCode.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    Ordtype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Get model number of the selected Part
                string OrdCode = OrderDGV.SelectedRows[0].Cells["OrderCode"].Value.ToString();

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters       
                using (SqlCommand cmd = new SqlCommand("UPDATE EmployeeTbl SET OrderName = @OrdName, OrderPrice = @OrdPrice, ClientNIC = @CLINic, Description = @OrdDescript, OrderType = @OrdType WHERE OrderCode = @OrdCode", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@OrdName", txtOrdName.Text);
                    cmd.Parameters.AddWithValue("@OrdPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@CLINic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@OrdCode", OrdCode);
                    cmd.Parameters.AddWithValue("@OrdDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@OrdType", Ordtype.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order updated successfully!");
                }

                // Refresh the Location list display
                OrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Orders: {ex.Message}");
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

        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear_Data();
        }

        private void PBSearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            employeeDashboard.Show();
            this.Hide();
        }

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
