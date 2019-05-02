using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ModifiyRes : Form
    {
        double cost, originalCost;
        int room, numNights;
        string unavailable;
        String paymentInfo = "N/A", fname = "N/A", lname = "N/A", type, email = "N/A", phone = "N/A", datePaid = "NP";
        DateTime start, end;
        Reservation Mod;
        public ModifiyRes()
        {
            InitializeComponent();
            label12.Visible = false;
            calStartDate.MinDate = DateTime.Today;
            

            
            Mod = DataController.resList[DataController.modIndex];
            start = DateTime.ParseExact(Mod.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture);
            end = DateTime.ParseExact(Mod.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(Mod.getNumNights());
            calEndDate.MinDate = start.AddDays(1);
            //Edate = end.ToString("yyyyMMdd");
            calStartDate.SelectionStart = start;
            calEndDate.SelectionStart = end;
            if(Mod.getType() == "p")
            {
                if (DateTime.Today.AddDays(90) < start)
                    calStartDate.MinDate = DateTime.Today.AddDays(90);
                else
                    calStartDate.MinDate = start;
            }
            else if (Mod.getType() == "s")
            {
                if (DateTime.Today.AddDays(60) < start)
                    calStartDate.MinDate = DateTime.Today.AddDays(60);
                else
                    calStartDate.MinDate = start;
            }

            calStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStartDate_DateChanged);
            calEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEndDate_DateChanged);
            cost = Mod.getCost();
            originalCost = cost;
            datePaid = Mod.getDatePaid();
            type = Mod.getType();
            string[] fullname = Mod.getName().Split();
            textBox5.Text = fullname[0];
            textBox4.Text = fullname[1];
            textBox3.Text = Mod.getEmail();
            textBox2.Text = Mod.getPhone();
            textBox1.Text = Mod.getPayment();
            label6.Text = cost.ToString();
        }

        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            label12.Visible = false;

            calEndDate.MinDate = calStartDate.SelectionStart.AddDays(1);

            getAdjustedCost();
            //start = calStartDate.SelectionRange.Start;
            //end = calEndDate.SelectionStart;
            //numNights = (end.Subtract(start)).Days;
            unavailable = (DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), numNights));
            if (unavailable != "")
            {
                label12.Text = unavailable;
                label6.Text = "";
                label12.Visible = true;
                btnSubmitRes.Enabled = false;
            }
            else
            {
                btnSubmitRes.Enabled = true;
                //cost = DataController.calendar.getCost(start.ToString("yyyyMMdd"), numNights, type);
                //resetType();
                label6.Text = cost.ToString();
            }
            
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            label12.Visible = false;

            //start = calStartDate.SelectionRange.Start;
            //end = calEndDate.SelectionStart;

            //numNights = (end.Subtract(start)).Days;
            getAdjustedCost();
            unavailable = (DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), numNights));
            if (unavailable != "")
            {
                label12.Text = unavailable;
                label6.Text = "";
                label12.Visible = true;
                btnSubmitRes.Enabled = false;
            }
            else
            {
                //cost = DataController.calendar.getCost(start.ToString("yyyyMMdd"), numNights, type);
                btnSubmitRes.Enabled = true;
                label6.Text = cost.ToString();
            }
            //resetType();
            
        }

        private void btnSubmitRes_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Is the information you entered correct? ",
                "Confirm Your Reservation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                String name = fname + " " + lname;

                if (type == "p" || type == "s")
                {
                    double owed = 0;
                    if(datePaid != "NP")
                    {
                        owed = cost - originalCost;
                    }
                    else
                    {
                        owed = cost;
                    }
                    if(owed > 0)
                    {
                        DialogResult chargeCard = MessageBox.Show("For this Reservation: you must charge " + name + ", card number " + paymentInfo + " $" + owed + ". click YES to confirm payment, or NO to go back to create screen.",
                        "Confirm Payment...", MessageBoxButtons.YesNo);
                        if (chargeCard == DialogResult.Yes)
                        {
                            Reservation newRes = new Reservation(paymentInfo, cost, start.ToString("yyyyMMdd"), numNights, room, name, phone, type, email, DateTime.Today.ToString("yyyyMMdd"));
                            DataController.addToRecord(name + ", card number " + paymentInfo + "charged $" + cost + ".");
                            DataController.modifyReservation(Mod, newRes);
                            disableScreen();
                            //exit();
                        }
                        else
                        {
                            btnSubmitRes.Enabled = true;
                        }
                    }
                    else
                    {
                        Reservation newRes = new Reservation(paymentInfo, originalCost, start.ToString("yyyyMMdd"), numNights, room, name, phone, type, email, datePaid);
                        DataController.modifyReservation(Mod, newRes);
                        disableScreen();
                    }
                    
                }
                else
                {
                    Reservation newRes = new Reservation(paymentInfo, cost, start.ToString("yyyyMMdd"), numNights, room, name, phone, type, email, datePaid);
                    DataController.modifyReservation(Mod, newRes);
                    disableScreen();
                }
            }        
        }
        
        private void getAdjustedCost()
        {
            start = calStartDate.SelectionStart;
            end = calEndDate.SelectionStart;
            numNights = (end.Subtract(start)).Days;
            cost = DataController.calendar.getCost(start.ToString("yyyyMMdd"), numNights, type);
            if((type == "p" || type == "s"))
            {
                cost = 1.1 * cost;
                if (cost < originalCost)
                    cost = originalCost;
            }
            if (start.ToString("yyyyMMdd") == Mod.getStartDate() && end.Subtract(start).Days == Mod.getNumNights())
            {
                cost = originalCost;
            }

        }

        private void GboxNewRes_Enter(object sender, EventArgs e)
        {
            //btnSubmitRes_Click(sender, e);
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

        private void disableScreen()
        {
            btnSubmitRes.Enabled = false;
            calStartDate.Enabled = false;
            calEndDate.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            btnSubmitRes.Enabled = false;
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
