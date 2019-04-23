﻿using System;
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
    public partial class ChngRate : Form
    {
        public ChngRate()
        {
            InitializeComponent();
        }

        private void gboxChngRate_Enter(object sender, EventArgs e)
        {

        }

        private void dateChngRate_ValueChanged(object sender, EventArgs e)
        {
            //Need to get value of date selected somehow.
        }

        private void txtChngRate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmitRate_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!string.IsNullOrWhiteSpace(txtChngRate.Text) || 
                !int.TryParse(txtChngRate.Text, out parsedValue))
            {
                lblSetRate.Text = "Set Rate: $" + txtChngRate.Text; //This new value for the label need to
                                                               //be mapped to the same date that the new
                                                               //base rate is mapped to.
                lblSetRate.Refresh();
                lblSubmitRate.Enabled = true;
                btnSubmitRate.Enabled = false; //Submit button to be re-enabled when user selects a different date.
            }
            else
            {
                MessageBox.Show("Invalid entry for 'NEW RATE'. Enter only numbers when setting the base rate.",
                     "Error");
            }
            

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Hide();
            EmpActs empActs = new EmpActs();
            empActs.FormClosed += (s, args) => Close();
            empActs.ShowDialog();
            empActs.Focus();
        }
    }
}
