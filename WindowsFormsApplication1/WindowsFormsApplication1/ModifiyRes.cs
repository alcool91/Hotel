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
    public partial class ModifiyRes : Form
    {
        double cost = 0;
        int room = 1, numNights = 0;
        String paymentInfo = "N/A", fname = "N/A", lname = "N/A", type, email = "N/A", phone = "N/A", Edate, Sdate;
        DateTime start, end;
        Reservation Mod;
        public ModifiyRes()
        {
            InitializeComponent();
            unavailLabel.Visible = false;
            calStartDate.MinDate = DateTime.Today;
            start = calStartDate.SelectionStart;
            Sdate = calStartDate.SelectionStart.ToString("yyyyMMdd");
            calEndDate.MinDate = DateTime.Today.AddDays(1);
            end = calEndDate.SelectionStart;
            Edate = calEndDate.SelectionStart.ToString("yyyyMMdd");
            Mod = DataController.resList[DataController.modIndex];
            cost = Mod.getCost();
            type = Mod.getType();
            /*if (type == "s")
            {
                type = "Sixty Day (15% Discount)";
            }
            if (type == "c" || type == "i")
            {
                type = "Conventional";
            }
            if (type == "p")
            {
                type = "Pre-Paid (25% Discount)";
            }*/

            //comboBox2.Items.Add(type);
            //comboBox2.Text = type;
            string[] fullname = Mod.getName().Split();
            textBox5.Text = fullname[0];
            textBox4.Text = fullname[1];
            textBox3.Text = Mod.getEmail();
            textBox2.Text = Mod.getPhone();
            textBox1.Text = Mod.getPayment();
            label6.Text = cost.ToString();
        }
        public void reset()
        {

        }

        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            unavailLabel.Visible = false;
            btnSubmitRes.Enabled = true;
            calEndDate.MinDate = calStartDate.SelectionStart.AddDays(1);

            Sdate = calStartDate.SelectionRange.Start.ToString("yyyyMMdd");

            start = calStartDate.SelectionRange.Start;
            end = calEndDate.SelectionStart;
            numNights = (end.Subtract(start)).Days;
            string unavailable = (DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), numNights));
            if (unavailable != "")
            {
                unavailLabel.Text = unavailable;
                unavailLabel.Visible = true;
                btnSubmitRes.Enabled = false;
            }
            //cost = DataController.calendar.getCost(Sdate, numNights, type);
            resetType();
            label6.Text = "";
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            unavailLabel.Visible = false;
            btnSubmitRes.Enabled = true;
            Edate = calEndDate.SelectionRange.End.ToString("yyyyMMdd");
            end = calEndDate.SelectionRange.End;
            numNights = (end.Subtract(start)).Days;
            string unavailable = (DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), numNights));
            if (unavailable != "")
            {
                unavailLabel.Text = unavailable;
                unavailLabel.Visible = true;
                btnSubmitRes.Enabled = false;
            }
            resetType();
            label6.Text = "";
        }

        private void btnSubmitRes_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Is the information you entered correct? ",
                "Confirm Your Reservation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                if (type == "Sixty Day (15% Discount)")
                {
                    type = "s";
                }
                if (type == "Conventional")
                {
                    type = "c";
                }
                if (type == "Pre-Paid (25% Discount)")
                {
                    type = "p";
                }
            }
            if (submit == DialogResult.No)
            {
                Hide();
                ModifiyRes reset = new ModifiyRes();
                reset.FormClosed += (s, args) => Close();
                reset.ShowDialog();
                reset.Focus();
            }
           
            String name = fname + " " + lname;
            numNights = (end.Subtract(start)).Days;
            //cost = DataController.calendar.getCost(Sdate, numNights, type);
            Reservation newRes = new Reservation(paymentInfo, cost, Sdate, numNights, room, name, phone, type, email, Mod.getDatePaid());

            DataController.modifyReservation(Mod, newRes);

            Hide();
            ResOpts resOpts = new ResOpts();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnGoPrnt_Click(object sender, EventArgs e)
        {

        }

        private void btnDoneNewRes_Click(object sender, EventArgs e)
        {
            Hide();
            ResOpts resOpts = new ResOpts();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = comboBox2.Text;
            if (type == "Sixty Day (15% Discount)")
            {
                type = "s";
            }
            if (type == "Conventional")
            {
                type = "c";
            }
            if (type == "Pre-Paid (25% Discount)")
            {
                type = "p";
            }
            cost = DataController.calendar.getCost(Sdate, numNights, type);
            label6.Text = cost.ToString();
        }

        private void resetType()
        {
            comboBox2.Items.Clear();
            int i = calStartDate.SelectionRange.Start.Subtract(DateTime.Today).Days;
            if (i >= 90)
                comboBox2.Items.Add("Pre-Paid (25% Discount)");
            if (i >= 60)
                comboBox2.Items.Add("Sixty Day (15% Discount)");
            comboBox2.Items.Add("Conventional");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            fname = textBox5.Text;
            if (fname == "")
                fname = "N/A";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lname = textBox4.Text;
            if (lname == "")
                lname = "N/A";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            phone = textBox2.Text;
            if (phone == "")
                phone = "N/A";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = textBox3.Text;
            if (email == "")
                email = "N/A";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            paymentInfo = textBox1.Text;
            if (paymentInfo == "")
                paymentInfo = "N/A";
        }
    }
}
