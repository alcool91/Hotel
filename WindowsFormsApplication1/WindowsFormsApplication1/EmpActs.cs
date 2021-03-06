﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmpActs : Form
    {
        ManagerLogin managerLogin = new ManagerLogin();
        ChngRate chngRate = new ChngRate();
        public bool confirmed = false;
        public EmpActs()
        {
            InitializeComponent();
        }

        private void gboxEmpAct_Enter(object sender, EventArgs e)
        {

        }

        private void btnBackF7_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.FormClosed += (s, args) => Close();
            homeScreen.ShowDialog();
            homeScreen.Focus();

        }

        private void btnExOccRep_Click(object sender, EventArgs e)
        {
            
            if (!DataController.isManager)
            {
                var conf = managerLogin.ShowDialog();
                managerLogin.Focus();
                if (conf == DialogResult.OK)
                {
                    confirmed = managerLogin.isMan;
                    Console.WriteLine(confirmed);
                }

                if (confirmed)
                {
                    Report.getExpectedOccupancy(DateTime.Today.ToString("yyyyMMdd"), 30);
                    Process p = new Process();
                    p.StartInfo.FileName = ".\\Hotel\\Reports\\ExpectedOccupancy.txt";
                    p.Start();
                }
                else
                {

                }
            }
            else
            {
                Report.getExpectedOccupancy(DateTime.Today.ToString("yyyyMMdd"), 30);
                Process p = new Process();
                p.StartInfo.FileName = ".\\Hotel\\Reports\\ExpectedOccupancy.txt";
                p.Start();
            }

        }

        private void btnIncomeRep_Click(object sender, EventArgs e)
        {
            
            if (!DataController.isManager)
            {

                var conf = managerLogin.ShowDialog();
                managerLogin.Focus();
                if (conf == DialogResult.OK)
                {
                    confirmed = managerLogin.isMan;
                    Console.WriteLine(confirmed);
                }

                if (confirmed)
                {
                    Report.getExpectedIncome();
                    Process p = new Process();
                    p.StartInfo.FileName = ".\\Hotel\\Reports\\ExpectedIncome.txt";
                    p.Start();
                }
                else
                {

                }
            }
            else
            {
                Report.getExpectedIncome();
                Process p = new Process();
                p.StartInfo.FileName = ".\\Hotel\\Reports\\ExpectedIncome.txt";
                p.Start();
            }

        }

        private void btnIncentRep_Click(object sender, EventArgs e)
        {
            if (!DataController.isManager)
            {
                var conf = managerLogin.ShowDialog();
                
                managerLogin.Focus();
                if (conf == DialogResult.OK)
                {
                    confirmed = managerLogin.isMan;
                    Console.WriteLine(confirmed);
                }

                if (confirmed)
                {
                    Report.getIncentives();
                    Process p = new Process();
                    p.StartInfo.FileName = ".\\Hotel\\Reports\\Incentives.txt";
                    p.Start();
                }
                else
                {

                }
            }
            else
            {
                Report.getIncentives();
                Process p = new Process();
                p.StartInfo.FileName = ".\\Hotel\\Reports\\Incentives.txt";
                p.Start();
            }

        }

        private void btnDayOccRep_Click(object sender, EventArgs e)
        {
            Report.getDailyArrivals();
            Process p = new Process();
            p.StartInfo.FileName = ".\\Hotel\\Reports\\DailyArrivals.txt";
            p.Start();
        }

        private void btnDayArrRep_Click(object sender, EventArgs e)
        {
            Report.getDailyOccupancy();
            Process p = new Process();
            p.StartInfo.FileName = ".\\Hotel\\Reports\\DailyOccupancy.txt";
            p.Start();
        }
       
        
       private void btnChngRate_Click(object sender, EventArgs e)
        {
            if (!DataController.isManager)
            {
                var conf = managerLogin.ShowDialog();
                managerLogin.Focus();
                if (conf == DialogResult.OK)
                {
                    confirmed = managerLogin.isMan;
                    Console.WriteLine(confirmed);
                }

                if (confirmed)
                {
                    Hide();
                    chngRate.FormClosed += (s, args) => Close();
                    chngRate.ShowDialog();
                    chngRate.Focus();
                }
                else
                {

                }
            }
            else
            {
                Hide();
                chngRate.FormClosed += (s, args) => Close();
                chngRate.ShowDialog();
                chngRate.Focus();
            }

        }
    }
}
