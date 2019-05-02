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
            //InitializeComponent();
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

    }
}