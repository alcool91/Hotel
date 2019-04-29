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
        double cost = 0;
        int room = 1, numNights;
        String  paymentInfo, fname, lname, type, email,phone, Edate, Sdate;

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

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            fname = txtFirstName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numNights = Convert.ToInt32(textBox1.Text);
        }

        private void txtCCard_TextChanged(object sender, EventArgs e)
        {
            paymentInfo = txtCCard.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Sdate = calStartDate.SelectionRange.Start.ToString("yyyyMMdd");
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Edate = calEndDate.SelectionRange.End.ToString("yyyyMMdd"); ;
        }

        private void btnSubmitRes_Click(object sender, EventArgs e) //This btn will save the reservation.
        {
            DialogResult submit = MessageBox.Show("Is the information you entered correct? ",
                "Confirm Your Reservation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                String name = fname + " " + lname;
                if(type == "60-Day")
                {
                    type = "s";
                }
                if (type == "Convential")
                {
                    type = "c";
                }
                if (type == "Pre-Pay")
                {
                    type = "p";
                }

               // cost = DataController.calendar.getCost(Sdate, numNights, type);
                //cost = DataController.calendar.getCost(Sdate, numNights, type);

                label6.Enabled = true;
                //String sdateString = Sdate.ToString("yyyyMMdd");
                btnSubmitRes.Enabled = false;
                DataController.createReservation(paymentInfo, cost, Sdate, room, name, phone, type, email);

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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lname = txtLastName.Text;
        }
    }
}
