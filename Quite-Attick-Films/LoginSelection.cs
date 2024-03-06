using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films
{
    public partial class LoginSelection : KryptonForm
    {
        public LoginSelection()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmloyeeLogin emloyeeLogin = new EmloyeeLogin(); 
            emloyeeLogin.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/xloozi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/xloozi");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/xloozi");
        }

        private void PBclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
