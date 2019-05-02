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
    public partial class SearchRes : Form
    {
        static String setname;
        static int index = 0;
        static Reservation search;
        public SearchRes()
        {
            getRes();
            InitializeComponent();
            label17.Text = search.getName();
            label16.Text = search.getPhone();
            label18.Text = search.getEmail();
            label15.Text = search.getPayment();
            label13.Text = search.getType();
            label14.Text = search.getRoom().ToString();
            label12.Text = search.getCost().ToString();
            label11.Text = search.getNumNights().ToString();
            label10.Text = search.getStartDate();

        }
        public void getRes()
        {
            setname = DataController.setSearchName();
            index = DataController.searchReservation(setname, index);
            if(index == -1)
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
            InitializeComponent();
            label17.Text = String.Format(search.getName());
            label16.Text = String.Format(search.getPhone());
            label18.Text = String.Format(search.getEmail());
            label15.Text = String.Format(search.getPayment());
            label13.Text = String.Format(search.getType());
            label14.Text = String.Format(search.getRoom().ToString());
            label12.Text = String.Format(search.getCost().ToString());
            label11.Text = String.Format(search.getNumNights().ToString());
            label10.Text = String.Format(search.getStartDate());
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

        private void txtSearchRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Is the information you entered correct? ",
                "Confirm Your Reservation...", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                DataController.cancelReservation(index);
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

        private void label10_Click_1(object sender, EventArgs e)
        {
            label10.Text = search.getStartDate();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            getRes();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}