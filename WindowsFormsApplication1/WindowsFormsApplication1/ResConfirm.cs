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
    public partial class ResConfirm : Form
    {
        public ResConfirm()
        {
            InitializeComponent();
        }

        // Declares the PrintDocument object.
        private System.Drawing.Printing.PrintDocument resToPrint =
            new System.Drawing.Printing.PrintDocument();

        private void btnPntBill_Click(object sender, EventArgs e)
        {
            // Allows the user to choose the page range to print.
            printDialog1.AllowSomePages = true;

            // Shows the help button.
            printDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property must be set 
            printDialog1.Document = resToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                resToPrint.Print();
            }

        }

        //This btn goes back to CreateNewRes so user can make changes
        private void btnMkChng_Click(object sender, EventArgs e)
        {
            Hide();
            CreateNewRes createNewRes = new CreateNewRes();
            createNewRes.Focus();
        }

        private void txtResConfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
