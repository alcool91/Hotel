using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            label13.Text = String.Format(search.getType());
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
                if((search.getType() == "c" || search.getType() == "i") && search.getDatePaid() == "NP" && DateTime.ParseExact(search.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture) < DateTime.Today.AddDays(3))
                {
                    DialogResult chargeCard = MessageBox.Show("To cancel you must charge " + search.getName() + " for the first night, card number " + search.getPayment() + " $" + search.getCost()/search.getNumNights() + ". click YES to confirm payment, or NO to go back to view screen.",
                "Confirm Payment...", MessageBoxButtons.YesNo);
                    if (chargeCard == DialogResult.Yes)
                    {
                        Reservation newRes = new Reservation(search.getPayment(), search.getCost(), search.getStartDate(), search.getNumNights(), search.getRoom(), search.getName(), search.getPhone(), search.getType(), search.getEmail(), DateTime.Today.ToString("yyyyMMdd"));
                        DataController.addToRecord(search.getName() + ", card number " + search.getPayment() + "charged $" + search.getCost()/search.getNumNights() + ".");
                        DataController.modifyReservation(search, newRes);
                        DataController.cancelReservation(newRes);
                        DialogResult submit2 = MessageBox.Show("Successfully cancelled.",
                    "Cancelled", MessageBoxButtons.OK);
                        if (submit2 == DialogResult.OK)
                        {
                            Hide();
                            ResOpts resOpts1 = new ResOpts();
                            resOpts1.FormClosed += (s, args) => Close();
                            resOpts1.ShowDialog();
                            resOpts1.Focus();
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    DataController.cancelReservation(DataController.resList[index]);
                    Hide();
                    ResOpts resOpts = new ResOpts();
                    resOpts.FormClosed += (s, args) => Close();
                    resOpts.ShowDialog();
                    resOpts.Focus();
                }
                
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int room = DataController.assignRoom(search);
            DialogResult submit = MessageBox.Show("Successfully checked in guest to room " + room,
                "Checked in", MessageBoxButtons.OK);
            if (submit == DialogResult.OK)
            {
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
                    Reservation newRes = new Reservation(search.getPayment(), search.getCost(), search.getStartDate(), search.getNumNights(), search.getRoom(), search.getName(), search.getPhone(), search.getType(), search.getEmail(), DateTime.Today.ToString("yyyyMMdd"));
                    DataController.addToRecord(search.getName() + ", card number " + search.getPayment() + "charged $" + search.getCost() + ".");
                    Report.printBill(search);
                    Process p = new Process();
                    p.StartInfo.FileName = ".\\Hotel\\Reports\\DailyOccupancy.txt";
                    p.Start();
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
                Report.printBill(search);
                Process p = new Process();
                p.StartInfo.FileName = ".\\Hotel\\Reports\\DailyOccupancy.txt";
                p.Start();
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