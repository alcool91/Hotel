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
        int room = 1, numNights = 0;
        String paymentInfo = "N/A", fname, lname, type, email, phone, Edate, Sdate;
        DateTime start, end;
        public CreateNewRes()
        {
            InitializeComponent();
            txtCCard.Visible = false;
            txtLastName.Visible = false;
            txtFirstName.Visible = false;
            txtEmail.Visible = false;
            txtPhone.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;


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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = comboBox1.Text;
            numNights = (end.Subtract(start)).Days;
            if (type == "Pre-Paid (25% Discount)")
            {
                txtCCard.Visible = true;
                txtLastName.Visible = true;
                txtFirstName.Visible = true;
                txtEmail.Visible = true;
                txtPhone.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                if (type == "Sixty Day (15% Discount)")
                {
                    type = "s";
                }
                if (type == "Convential")
                {
                    type = "c";
                }
                if (type == "Pre-Paid (25% Discount)")
                {
                    type = "p";
                }
                cost = DataController.calendar.getCost(Sdate, numNights, type);
                label9.Text = cost.ToString();
            }
            if (type == "Convential")
            {
                txtCCard.Visible = true;
                txtLastName.Visible = true;
                txtFirstName.Visible = true;
                txtEmail.Visible = true;
                txtPhone.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                if (type == "Sixty Day (15% Discount)")
                {
                    type = "s";
                }
                if (type == "Convential")
                {
                    type = "c";
                }
                if (type == "Pre-Paid (25% Discount)")
                {
                    type = "p";
                }
                cost = DataController.calendar.getCost(Sdate, numNights, type);
                label9.Text = cost.ToString();
            }
            if (type == "Sixty Day (15% Discount)")
            {
                txtCCard.Visible = false;
                txtLastName.Visible = true;
                txtFirstName.Visible = true;
                txtEmail.Visible = true;
                txtPhone.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                if (type == "Sixty Day (15% Discount)")
                {
                    type = "s";
                }
                if (type == "Convential")
                {
                    type = "c";
                }
                if (type == "Pre-Paid (25% Discount)")
                {
                    type = "p";
                }
                cost = DataController.calendar.getCost(Sdate, numNights, type);
                label9.Text = cost.ToString();
            }
            if (type == " ")
            {
                txtCCard.Visible = false;
                txtLastName.Visible = false;
                txtFirstName.Visible = false;
                txtEmail.Visible = false;
                txtPhone.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                // cost = DataController.calendar.getCost(Sdate, numNights, type);
                //label9.Text = cost.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            calEndDate.MinDate = calStartDate.SelectionStart.AddDays(1);

            Sdate = calStartDate.SelectionRange.Start.ToString("yyyyMMdd");
            comboBox1.Items.Clear();
            int i = calStartDate.SelectionRange.Start.Subtract(DateTime.Today).Days;
            if (i >= 90)
                comboBox1.Items.Add("Pre-Paid (25% Discount)");
            if (i >= 60)
                comboBox1.Items.Add("Sixty Day (15% Discount)");
            comboBox1.Items.Add("Convential");

            start = calStartDate.SelectionRange.Start;
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Edate = calEndDate.SelectionRange.End.ToString("yyyyMMdd");
            end = calEndDate.SelectionRange.End;
        }

        private void btnSubmitRes_Click(object sender, EventArgs e) //This btn will save the reservation.
        {
            DialogResult submit = MessageBox.Show("Is the information you entered correct? ",
                "Confirm Your Reservation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                String name = fname + " " + lname;
                if (type == "Sixty Day (15% Discount)")
                {
                    type = "s";
                }
                if (type == "Convential")
                {
                    type = "c";
                }
                if (type == "Pre-Paid (25% Discount)")
                {
                    type = "p";
                }

                name = fname + " " + lname;

                //cost = DataController.calendar.getCost(Sdate, numNights, type);
                numNights = (end.Subtract(start)).Days;
                label6.Enabled = true;
                cost = DataController.calendar.getCost(Sdate, numNights, type);
                //String sdateString = Sdate.ToString("yyyyMMdd");
                btnSubmitRes.Enabled = false;
                DataController.createReservation(paymentInfo, cost, Sdate, numNights, room, name, phone, type, email);

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