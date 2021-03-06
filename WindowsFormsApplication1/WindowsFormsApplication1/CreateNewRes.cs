﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class CreateNewRes : Form
    {
        double cost = 0;
        int room = 0, numNights = 0;
        string unavailable;
        String paymentInfo = "N/A", fname = "N/A", lname = "N/A", type, email = "N/A", phone = "N/A";
        DateTime start, end;
        public CreateNewRes()
        {
            InitializeComponent();
            label10.Visible = false;
            btnSubmitRes.Enabled = false;
            calStartDate.MinDate = DateTime.Today;
            start = calStartDate.SelectionStart;
            unavailable = DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), 1);
            if (unavailable != "")
            {
                label10.Text = unavailable;
                label10.Visible = true;
                btnSubmitRes.Enabled = false;
            }
            calEndDate.MinDate = DateTime.Today.AddDays(1);
            end = calEndDate.SelectionStart;

            comboBox1.Items.Add("Conventional");
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
            if (fname == "")
                fname = "N/A";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lname = txtLastName.Text;
            if (lname == "")
                lname = "N/A";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            if (email == "")
                email = "N/A";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.Text;
            if (phone == "")
                phone = "N/A";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
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
            if(unavailable == "")
                btnSubmitRes.Enabled = true;

            type = comboBox1.Text;
            if (type == "Pre-Paid (25% Discount)")
            {
                txtCCard.Visible = true;
                label5.Visible = true;
                type = "p";
            }
            else if (type == "Conventional")
            {
                txtCCard.Visible = true;
                label5.Visible = true;
                type = "c";
            }
            else if (type == "Sixty Day (15% Discount)")
            {
                type = "s";
                txtCCard.Visible = false;
                label5.Visible = false;               
            }
            else if (type == " ")
            {
                btnSubmitRes.Enabled = false;
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

            start = calStartDate.SelectionStart;
            end = calEndDate.SelectionStart;
            numNights = (end.Subtract(start)).Days;
            cost = DataController.calendar.getCost(start.ToString("yyyyMMdd"), numNights, type);
            label9.Text = cost.ToString();
            label9.Visible = true;
        }

        private void txtCCard_TextChanged(object sender, EventArgs e)
        {
            paymentInfo = txtCCard.Text;
            if (paymentInfo == "")
                paymentInfo = "N/A";
        }

        private void recreateTypeChoice()
        {
            comboBox1.Items.Clear();
            int i = calStartDate.SelectionRange.Start.Subtract(DateTime.Today).Days;
            if (i >= 90)
                comboBox1.Items.Add("Pre-Paid (25% Discount)");
            if (i >= 60)
                comboBox1.Items.Add("Sixty Day (15% Discount)");
            comboBox1.Items.Add("Conventional");
        }

        private void calStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            label10.Visible = false;
            recreateTypeChoice();
            label9.Visible = false;
            start = calStartDate.SelectionStart;
            calEndDate.MinDate = start.AddDays(1);
            end = calEndDate.SelectionStart;
            numNights = (end.Subtract(start)).Days;
            unavailable = (DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), numNights));
            if (unavailable != "")
            {
                label10.Text = unavailable;
                label10.Visible = true;
                btnSubmitRes.Enabled = false;
            }
        }

        private void calEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            label10.Visible = false;
            recreateTypeChoice();
            start = calStartDate.SelectionRange.Start;
            end = calEndDate.SelectionRange.End;
            numNights = (end.Subtract(start)).Days;
            unavailable = (DataController.calendar.areDatesaAvailable(start.ToString("yyyyMMdd"), numNights));
            if (unavailable != "")
            {
                label10.Text = unavailable;
                label10.Visible = true;
                btnSubmitRes.Enabled = false;
            } /*else if (comboBox1.Text != "")
            {
                numNights = (end.Subtract(start)).Days;                
                cost = DataController.calendar.getCost(start.ToString("yyyyMMdd"), numNights, type);
                label9.Text = cost.ToString();
                label9.Enabled = true;
                //btnSubmitRes.Enabled = true;
            }*/
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
                if (type == "Conventional")
                {
                    type = "c";
                }
                if (type == "Pre-Paid (25% Discount)")
                {
                    type = "p";
                }

                name = fname + " " + lname;

                //cost = DataController.calendar.getCost(Sdate, numNights, type);
                //numNights = (end.Subtract(start)).Days;
                
                cost = DataController.calendar.getCost(start.ToString("yyyyMMdd"), numNights, type);
                //String sdateString = Sdate.ToString("yyyyMMdd");
                btnSubmitRes.Enabled = false;

                if(type == "p")
                {
                    DialogResult chargeCard = MessageBox.Show("For this Reservation: you must charge " + name + ", card number " + paymentInfo + " $" + cost + ". click YES to confirm payment, or NO to go back to create screen.",
                "Confirm Payment...", MessageBoxButtons.YesNo);
                    if (chargeCard == DialogResult.Yes)
                    {
                        DataController.createReservation(paymentInfo, cost, start.ToString("yyyyMMdd"), numNights, room, name, phone, type, email, DateTime.Today.ToString("yyyyMMdd"));
                        DataController.addToRecord(name + ", card number " + paymentInfo + "charged $" + cost + ".");
                        label6.Enabled = true;
                        disableScreen();
                        //exit();
                        Hide();
                        ResOpts resOpts = new ResOpts();
                        resOpts.FormClosed += (s, args) => Close();
                        resOpts.ShowDialog();
                        resOpts.Focus();
                    }
                    else
                    {
                        btnSubmitRes.Enabled = true;
                    }                        
                }
                else
                {
                    DataController.createReservation(paymentInfo, cost, start.ToString("yyyyMMdd"), numNights, room, name, phone, type, email, "NP");
                    label6.Enabled = true;
                    disableScreen();
                    //exit();
                }
            }
            else if (submit == DialogResult.No)
            {

            }
        }

        private void disableScreen()
        {
            btnSubmitRes.Enabled = false;
            calStartDate.Enabled = false;
            calEndDate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtCCard.Enabled = false;
            comboBox1.Enabled = false;
            btnSubmitRes.Enabled = false;
        }

        private void exit() // Closes Window
        {
            Hide();
            ResOpts resOpts = new ResOpts();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();
        }

        private void btnDoneNewRes_Click(object sender, EventArgs e) //This btn will go back to previous screen.
        {
            exit();
        }   
    }
}