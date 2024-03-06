using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Quite_Attick_Films
{
    public partial class LoadingScreen : KryptonForm
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            ProgBar.Increment(2);
            if (ProgBar.Value == 100)
            {
                Timer.Enabled = false;
                LoginSelection loginSelection = new LoginSelection();
                loginSelection.Show();
                this.Hide();
            }
        }
    }
}
