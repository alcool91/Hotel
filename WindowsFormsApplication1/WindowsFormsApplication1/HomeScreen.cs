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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            lblActvUser.Text = "User: " + DataController.user;
        }

        private void gboxMain_Enter(object sender, EventArgs e)
        {

        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Please confirm logout:", "Logout", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                Hide();
                Login login = new Login();
                login.FormClosed += (s, args) => Close();
                login.ShowDialog();
                login.Focus();
            }
            else if (logout == DialogResult.No)
            {
                
            }
        }

        private void btnResOpts_Click(object sender, EventArgs e)
        {
            Hide();
            ResOpts resOpts = new ResOpts();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();

        }

        private void btnEmpAct_Click(object sender, EventArgs e)
        {
            Hide();
            EmpActs empActs = new EmpActs();
            empActs.FormClosed += (s, args) => Close();
            empActs.ShowDialog();
            empActs.Focus();

        }
    }
}
