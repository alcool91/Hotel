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
    public partial class CreateNewRes : Form
    {
        public CreateNewRes()
        {
            InitializeComponent();
        }

        private void gboxNewRes_Enter(object sender, EventArgs e)
        {

        }

        private void btnGoPrnt_Click(object sender, EventArgs e) //This btn will go to print accommodation bill screen.
        {
            //ResConfirm resConfirm = new ResConfirm();
            //resConfirm.ShowDialog();
            //resConfirm.Focus();

        }
        
        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Need to get value of selected date somehow.
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Need to get value of selected date somehow.
        }

        private void btnSubmitRes_Click(object sender, EventArgs e) //This btn will save the reservation.
        {
            DialogResult submit = MessageBox.Show("Is the information you entered correct? ",
                "Confirm Your Reservation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                label6.Enabled = true;
                btnSubmitRes.Enabled = false;

            }
            else if (submit == DialogResult.No)
            {

            }

        }

        private void btnDoneNewRes_Click(object sender, EventArgs e) //This btn will go back to previous screen.
        {
            Hide();
            ResOpts resOpts = new ResOpts();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();

        }
    }
}
