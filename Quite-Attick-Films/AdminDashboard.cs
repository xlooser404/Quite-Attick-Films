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
using Quite_Attick_Films.Admin_Panel_Pages;
using Quite_Attick_Films.Pages;

namespace Quite_Attick_Films
{
    public partial class AdminDashboard : KryptonForm
    {
        public AdminDashboard()
        {
            InitializeComponent();
            DisplayProductionCount();
            DisplayProducersCount();
            DisplayOrdersCount();
        }
        private void DisplayProductionCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM ProductionTbl"; // Assuming your production Table is named 'ProductionTbl'
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int proCount = (int)cmd.ExecuteScalar();
                        lblProduction.Text = "" + proCount; // Assuming your label is named 'lblProduction'
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Production count: {ex.Message}");
                // Consider logging the error for debugging
            }
        }


        private void DisplayProducersCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM ProducerTbl"; // Assuming your Producer table is named 'ProducerTbl'
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int proDuCount = (int)cmd.ExecuteScalar();
                        lblProducers.Text = "" + proDuCount; // Assuming your label is named 'lblProducers'
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Producers count: {ex.Message}");
                // Consider logging the error for debugging
            }
        }

        private void DisplayOrdersCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM OrderTbl"; // Assuming your Order table is named 'OrderTbl'
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int proDuCount = (int)cmd.ExecuteScalar();
                        lblOrders.Text = "" + proDuCount; // Assuming your label is named 'lblOrders'
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Orders count: {ex.Message}");
                // Consider logging the error for debugging
            }
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productions productions = new Productions();
            productions.Show();
        }

        private void btnProducers_Click(object sender, EventArgs e)
        {
            this.Hide();
            producers producers = new producers();
            producers.Show();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            this.Hide();
            Property property = new Property();
            property.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff staff = new staff();
            staff.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();   
            orders.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments payments = new Payments();
            payments.Show();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location location = new Location();
            location.Show();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemAuthUsers users = new SystemAuthUsers();
            users.Show();
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

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
