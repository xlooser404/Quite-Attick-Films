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
using Quite_Attick_Films.Employee_Panel_Pages;
using Quite_Attick_Films.Pages;

namespace Quite_Attick_Films
{
    public partial class EmployeeDashboard : KryptonForm
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
            DisplayClientCount();
            DisplaypayCount();
        }

        private void DisplayClientCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM ClientTbl"; // Assuming your Client Table is named 'ClientTbl'
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int cliCount = (int)cmd.ExecuteScalar();
                        lblClients.Text = "" + cliCount; // Assuming your label is named 'lblClients'
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Clients count: {ex.Message}");
                // Consider logging the error for debugging
            }
        }


        private void DisplaypayCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM PaymentTbl"; // Assuming your Payments table is named 'PaymentTbl'
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int payCount = (int)cmd.ExecuteScalar();
                        lblPayments.Text = "" + payCount; // Assuming your label is named 'lblPayments'
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Payments count: {ex.Message}");
                // Consider logging the error for debugging
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            empClient empClient = new empClient();
            empClient.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            empOrders empOrders = new empOrders();
            empOrders.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            empPayment empPayment = new empPayment();
            empPayment.Show();
            this.Hide();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            empProperty empProperty = new empProperty();
            empProperty.Show();
            this.Hide();
        }

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginSelection loginSelection = new LoginSelection();
            loginSelection.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginSelection loginSelection = new LoginSelection();
            loginSelection.Show();
        }
    }
}
