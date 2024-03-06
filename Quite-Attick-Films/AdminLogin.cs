using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films
{
    public partial class AdminLogin : KryptonForm
    {
        public AdminLogin()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        // Sql Data Connection
        private SqlConnection Connection = new SqlConnection("Data Source=TUF-GAMING-F15\\SQLEXPRESS;Initial Catalog=\"Quite Attick Films\";Integrated Security=True;Encrypt=False");
        // Sql Data Connection
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from AdminTbl where UserName='" + txtUserName.Text + "'AND Password='" + txtPassword.Text + "'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.Close();
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error");
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }

        private void icoShowpass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0'; // Reveal password
                icoShowpass.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Mask password
                icoShowpass.Text = "Show Password";
            }
            txtPassword.Focus(); // Move focus to the password field
        }

        private void LnkClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xloozi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xloozi");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xloozi");
        }

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
