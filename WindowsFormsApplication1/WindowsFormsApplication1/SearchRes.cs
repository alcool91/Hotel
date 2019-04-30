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
        static String setname, setphone;
        static double cost;
        static int room, numNights;
        static String date, paymentInfo, name, phone, type, email;
        Reservation search = new Reservation(paymentInfo,cost,date,room,name,phone,type,email);
        public SearchRes()
        {
            InitializeComponent();
            getRes();
        }
        public void getRes()
        {
            setname  = DataController.setSearchName();

            search = DataController.searchReservation(setname);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = search.getName();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = search.getPhone();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = search.getEmail();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = search.getPayment();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = search.getType();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = search.getRoom().ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = search.getCost().ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = search.getNumNights().ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = search.getStartDate();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
