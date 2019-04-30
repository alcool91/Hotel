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
    public partial class ManagerLogin : Form
    {
        public bool isMan = false;
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void gboxManagerLogin_Enter(object sender, EventArgs e)
        {

        }
 
        private void btnManagerSubmit_Click(object sender, EventArgs e)
        {
            //Insert code to check for valid manager password.
            //Similar to that which is in Login.cs, line 30.
            if (DataController.checkManager(textBox1.Text, txtManagerPass.Text)) {
                //somehow go to next page
                isMan = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //stay on current page
                isMan = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnManagerCancel_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
