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
    public partial class ResOpts : Form
    {
        static String name, phone;
        static int room;
        public ResOpts()
        {
            InitializeComponent();
        }

        private void gboxRes_Enter(object sender, EventArgs e)
        {

        }

        public void btnBackF3_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.FormClosed += (s, args) => Close();
            homeScreen.ShowDialog();
            homeScreen.Focus();
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            Hide();
            CreateNewRes createNewRes = new CreateNewRes();
            createNewRes.FormClosed += (s, args) => Close();
            createNewRes.ShowDialog();
            createNewRes.Focus();

        }

        private void btnSearchRes_Click(object sender, EventArgs e)
        {
            Hide();
            name = txtSearchRes.Text;
            DataController.storeIndex(-1);
            DataController.getSearchInfo(name, phone);
            SearchRes searchRes = new SearchRes();
            searchRes.FormClosed += (s, args) => Close();
            searchRes.ShowDialog();
            searchRes.Focus();

        }

        private void txtSearchRes_TextChanged(object sender, EventArgs e)
        {
            //name = txtSearchRes.Text;
            //DataController.storeIndex(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}