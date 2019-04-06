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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
 
        private void gboxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;
            if (!DataController.authenticateUser(userName, password))
            {
                lblFail.Enabled = true;
                txtUser.Clear();
                txtPassword.Clear();

                /* To test login button and test transition from the login screen to the main screen, 
                 * uncomment code directly below, and comment out code in the IF and ELSE brackets.
                 */ 

                //this.Hide();
                //MainScreen f2 = new MainScreen();
                //f2.Show();
            }
            else {
                //Code to begin application here
                this.Hide();
                HomeScreen f2 = new HomeScreen();
                f2.Show();

            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
