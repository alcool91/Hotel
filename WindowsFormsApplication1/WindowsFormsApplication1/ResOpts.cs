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
    public partial class ResOpts : Form
    {
        public ResOpts()
        {
            InitializeComponent();
        }

        private void gboxRes_Enter(object sender, EventArgs e)
        {

        }

        public void btnBackF3_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.FormClosed += (s, args) => Close();
            homeScreen.ShowDialog();
            homeScreen.Focus();
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            Hide();
            CreateNewRes createNewRes = new CreateNewRes();
            createNewRes.FormClosed += (s, args) => Close();
            createNewRes.ShowDialog();
            createNewRes.Focus();

        }

        private void btnSearchRes_Click(object sender, EventArgs e)
        {
            Hide();
            SearchRes searchRes = new SearchRes();
            searchRes.FormClosed += (s, args) => Close();
            searchRes.ShowDialog();
            searchRes.Focus();

        }

        private void txtSearchRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
