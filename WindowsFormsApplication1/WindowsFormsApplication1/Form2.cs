using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void gboxMain_Enter(object sender, EventArgs e)
        {

        }

        private void lblActvUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Please confirm logout:", "Logout", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                this.Close();
                Login f1 = new Login();
                f1.Show();
            }
            else if (logout == DialogResult.No)
            {
                
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
