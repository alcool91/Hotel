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
    public partial class EmpActs : Form
    {
        ManagerLogin managerLogin = new ManagerLogin();

        public EmpActs()
        {
            InitializeComponent();
        }

        private void gboxEmpAct_Enter(object sender, EventArgs e)
        {

        }

        private void btnBackF7_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.FormClosed += (s, args) => Close();
            homeScreen.ShowDialog();
            homeScreen.Focus();

        }

        private void btnExOccRep_Click(object sender, EventArgs e)
        {
            managerLogin.ShowDialog();
            managerLogin.Focus();

        }

        private void btnIncomeRep_Click(object sender, EventArgs e)
        {
            managerLogin.ShowDialog();
            managerLogin.Focus();

        }

        private void btnIncentRep_Click(object sender, EventArgs e)
        {
            managerLogin.ShowDialog();
            managerLogin.Focus();

        }

        private void btnDayOccRep_Click(object sender, EventArgs e)
        {
            managerLogin.ShowDialog();
            managerLogin.Focus();

        }

        private void btnDayArrRep_Click(object sender, EventArgs e)
        {
            managerLogin.ShowDialog();
            managerLogin.Focus();

        }

        private void btnChngRate_Click(object sender, EventArgs e)
        {
            managerLogin.ShowDialog();
            managerLogin.Focus();

        }
    }
}
