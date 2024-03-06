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
    public partial class empPayment : KryptonForm
    {
        public empPayment()
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
            txtCliName.Text = "";
            txtOrdCode.Text = "";
            txtPrice.Text = "";
            txtNIC.Text = "";
            txtDescript.Text = "";
            Paytype.SelectedItem = 0;
        }

        private void FillClientName(string clientNIC)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT ClientName FROM ClientTbl WHERE ClientNIC = @ClientNIC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClientNIC", clientNIC);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCliName.Text = reader["ClientName"].ToString();
                    }
                    else
                    {
                        txtCliName.Text = "Client Not Found";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching client name: " + ex.Message);
            }
        }

        private void OrderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow selectedRow = OrderDGV.Rows[e.RowIndex];

                // Retrieve data from the row's cells and assign to textboxes 

                // txtOrdName.Text = selectedRow.Cells["OrderName"].Value.ToString();
                txtOrdCode.Text = selectedRow.Cells["OrderCode"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["OrderPrice"].Value.ToString();
                txtNIC.Text = selectedRow.Cells["ClientNIC"].Value.ToString();
                txtDescript.Text = selectedRow.Cells["Description"].Value.ToString();
                // Ordtype.Text = selectedRow.Cells["OrderType"].Value.ToString();

                // Fill Client Name from ClientTbl
                string clientNIC = selectedRow.Cells["ClientNIC"].Value.ToString();
                FillClientName(clientNIC);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtCliName.Text) ||
                    string.IsNullOrEmpty(txtOrdCode.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    string.IsNullOrEmpty(txtDescript.Text) ||
                    Paytype.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Open database connection
                Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl (ClientName, OrderCode, OrderPrice, PaymentType, ClientNIC, OrderDescription) VALUES (@CliName, @OrdCode, @OrdPrice, @PayType, @ClientNIC, @OrdDescript)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@CliName", txtCliName.Text);
                    cmd.Parameters.AddWithValue("@OrdCode", txtOrdCode.Text);
                    cmd.Parameters.AddWithValue("@OrdPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@ClientNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@OrdDescript", txtDescript.Text);
                    cmd.Parameters.AddWithValue("@PayType", Paytype.SelectedItem.ToString());

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Payments: {ex.Message}");
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
