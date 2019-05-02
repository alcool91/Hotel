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
    public partial class SearchRes : Form
    {
        String setname;
        int index = 0;
        Reservation search;
        public SearchRes()
        {
            InitializeComponent();
            getRes();
            setRes();
        }
        public void getRes()
        {
            setname = DataController.setSearchName();
            index = DataController.searchReservation(setname, index);
            if (index == -1)
            {
                DialogResult submit = MessageBox.Show("There is no Reservation under this name",
                "Click OK", MessageBoxButtons.OK);
                if (submit == DialogResult.OK)
                {
                    Hide();
                    ResOpts resOpts = new ResOpts();
                    resOpts.FormClosed += (s, args) => Close();
                    resOpts.ShowDialog();
                    resOpts.Focus();

                }

            }
            else
            {
                search = DataController.resList[index];
                setRes();
            }


        }
        public void setRes()
        {
            if (search.getStartDate() == DateTime.Today.ToString("yyyyMMdd") && search.getRoom() == 0)
            {
                btnCheckIn.Enabled = true;
            }
            else
            {
                btnCheckIn.Enabled = false;
            }
            if (search.getRoom() != 0)
            {
                btnCheckOut.Enabled = true;
            }
            else
            {
                btnCheckOut.Enabled = false;
            }
                
            label17.Text = String.Format(search.getName());
            label16.Text = String.Format(search.getPhone());
            label18.Text = String.Format(search.getEmail());
            label15.Text = String.Format(search.getPayment());
            string type = String.Format(search.getType());
            if(type == "p")
            {
                label13.Text = "Pre-Pay";
            }
            if (type == "s")
            {
                label13.Text = "Sixty Day";
            }
            if (type == "c")
            {

                label13.Text = "Conventional";
            }
            if (type == "i")
            {
                label13.Text = "Incentive";
            }
            label14.Text = String.Format(search.getRoom().ToString());
            label12.Text = String.Format(search.getCost().ToString());
            label11.Text = String.Format(search.getNumNights().ToString());
            label10.Text = String.Format(DateTime.ParseExact(search.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy"));
            if (search.getDatePaid() == "NP")
            {
                label22.Text = "Unpaid";
            }
            else
            {
                label22.Text = String.Format(DateTime.ParseExact(search.getDatePaid(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy"));
            }

            //label10.Text = String.Format(search.getStartDate());
        }
        private void btnBackF6_Click(object sender, EventArgs e)
        {
            Hide();
            ResOpts resOpts = new ResOpts();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            DataController.storeIndex(index);
            Hide();
            ModifiyRes resOpts = new ModifiyRes();
            resOpts.FormClosed += (s, args) => Close();
            resOpts.ShowDialog();
            resOpts.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Are you sure you want to cancel? ",
                "Confirm Cancellation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                DataController.cancelReservation(DataController.resList[index]);
                Hide();
                ResOpts resOpts = new ResOpts();
                resOpts.FormClosed += (s, args) => Close();
                resOpts.ShowDialog();
                resOpts.Focus();
            }
            if (submit == DialogResult.No)
            {
                Hide();
                SearchRes resOpts = new SearchRes();
                resOpts.FormClosed += (s, args) => Close();
                resOpts.ShowDialog();
                resOpts.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            getRes();
            setRes();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int room = DataController.assignRoom(search);
            DialogResult submit = MessageBox.Show("Successfully checked in guest to room " + room,
                "Checked in", MessageBoxButtons.OK);
            if (submit == DialogResult.OK)
            {
                //DataController.cancelReservation(DataController.resList[index]);
                Hide();
                ResOpts resOpts = new ResOpts();
                resOpts.FormClosed += (s, args) => Close();
                resOpts.ShowDialog();
                resOpts.Focus();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int room = search.getRoom();
            if(search.getDatePaid() == "NP")
            {
                DialogResult chargeCard = MessageBox.Show("To check out you must charge " + search.getName() + ", card number " + search.getPayment() + " $" + search.getCost() + ". click YES to confirm payment, or NO to go back to view screen.",
                "Confirm Payment...", MessageBoxButtons.YesNo);
                if (chargeCard == DialogResult.Yes)
                {
                    search.setDatePaid(DateTime.Today.ToString("yyyyMMdd"));
                    Reservation newRes = new Reservation(search.getPayment(), search.getCost(), search.getStartDate(), search.getNumNights(), search.getRoom(), search.getName(), search.getPhone(), search.getType(), search.getEmail(), DateTime.Today.ToString("yyyyMMdd"));
                    DataController.modifyReservation(search, newRes);
                    DataController.checkOut(room, newRes);
                    DialogResult submit = MessageBox.Show("Successfully checked out.",
                "Checked Out", MessageBoxButtons.OK);
                    if (submit == DialogResult.OK)
                    {
                        Hide();
                        ResOpts resOpts = new ResOpts();
                        resOpts.FormClosed += (s, args) => Close();
                        resOpts.ShowDialog();
                        resOpts.Focus();
                    }
                }
                else
                {

                }
            }
            else
            {
                DataController.checkOut(room, search);
                DialogResult submit = MessageBox.Show("Successfully checked out.",
            "Checked Out", MessageBoxButtons.OK);
                if (submit == DialogResult.OK)
                {
                    Hide();
                    ResOpts resOpts = new ResOpts();
                    resOpts.FormClosed += (s, args) => Close();
                    resOpts.ShowDialog();
                    resOpts.Focus();
                }
            }


        }
    }
}