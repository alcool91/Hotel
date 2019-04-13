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

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;
            if (!DataController.authenticateUser(userName, password))
            {
                lblFail.Enabled = true;
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Select();

            }
            else {
                Hide();
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.FormClosed += (s, args) => Close();
                homeScreen.ShowDialog();
                homeScreen.Focus();

            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
