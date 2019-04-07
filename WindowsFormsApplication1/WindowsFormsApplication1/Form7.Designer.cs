namespace WindowsFormsApplication1
{
    partial class EmpActs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExOccRep = new System.Windows.Forms.Button();
            this.btnPrntBill = new System.Windows.Forms.Button();
            this.btnChngRate = new System.Windows.Forms.Button();
            this.btnIncomeRep = new System.Windows.Forms.Button();
            this.btnIncentRep = new System.Windows.Forms.Button();
            this.btnDayArrRep = new System.Windows.Forms.Button();
            this.btnDayOccRep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxEmpAct = new System.Windows.Forms.GroupBox();
            this.btnBackF7 = new System.Windows.Forms.Button();
            this.gboxEmpAct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExOccRep
            // 
            this.btnExOccRep.ForeColor = System.Drawing.Color.Black;
            this.btnExOccRep.Location = new System.Drawing.Point(100, 112);
            this.btnExOccRep.Name = "btnExOccRep";
            this.btnExOccRep.Size = new System.Drawing.Size(89, 56);
            this.btnExOccRep.TabIndex = 0;
            this.btnExOccRep.Text = "Expected Occupancy Report";
            this.btnExOccRep.UseVisualStyleBackColor = true;
            this.btnExOccRep.Click += new System.EventHandler(this.btnExOccRep_Click);
            // 
            // btnPrntBill
            // 
            this.btnPrntBill.ForeColor = System.Drawing.Color.Black;
            this.btnPrntBill.Location = new System.Drawing.Point(340, 282);
            this.btnPrntBill.Name = "btnPrntBill";
            this.btnPrntBill.Size = new System.Drawing.Size(89, 37);
            this.btnPrntBill.TabIndex = 1;
            this.btnPrntBill.Text = "Print Bill";
            this.btnPrntBill.UseVisualStyleBackColor = true;
            this.btnPrntBill.Click += new System.EventHandler(this.btnPrntBill_Click);
            // 
            // btnChngRate
            // 
            this.btnChngRate.ForeColor = System.Drawing.Color.Black;
            this.btnChngRate.Location = new System.Drawing.Point(100, 282);
            this.btnChngRate.Name = "btnChngRate";
            this.btnChngRate.Size = new System.Drawing.Size(89, 37);
            this.btnChngRate.TabIndex = 2;
            this.btnChngRate.Text = "Change Base Rates";
            this.btnChngRate.UseVisualStyleBackColor = true;
            this.btnChngRate.Click += new System.EventHandler(this.btnChngRate_Click);
            // 
            // btnIncomeRep
            // 
            this.btnIncomeRep.ForeColor = System.Drawing.Color.Black;
            this.btnIncomeRep.Location = new System.Drawing.Point(219, 112);
            this.btnIncomeRep.Name = "btnIncomeRep";
            this.btnIncomeRep.Size = new System.Drawing.Size(89, 56);
            this.btnIncomeRep.TabIndex = 3;
            this.btnIncomeRep.Text = "Expected Room Income Report";
            this.btnIncomeRep.UseVisualStyleBackColor = true;
            this.btnIncomeRep.Click += new System.EventHandler(this.btnIncomeRep_Click);
            // 
            // btnIncentRep
            // 
            this.btnIncentRep.ForeColor = System.Drawing.Color.Black;
            this.btnIncentRep.Location = new System.Drawing.Point(340, 112);
            this.btnIncentRep.Name = "btnIncentRep";
            this.btnIncentRep.Size = new System.Drawing.Size(89, 56);
            this.btnIncentRep.TabIndex = 4;
            this.btnIncentRep.Text = "Incentive Report";
            this.btnIncentRep.UseVisualStyleBackColor = true;
            this.btnIncentRep.Click += new System.EventHandler(this.btnIncentRep_Click);
            // 
            // btnDayArrRep
            // 
            this.btnDayArrRep.ForeColor = System.Drawing.Color.Black;
            this.btnDayArrRep.Location = new System.Drawing.Point(283, 199);
            this.btnDayArrRep.Name = "btnDayArrRep";
            this.btnDayArrRep.Size = new System.Drawing.Size(89, 56);
            this.btnDayArrRep.TabIndex = 5;
            this.btnDayArrRep.Text = "Daily Arrivals Report";
            this.btnDayArrRep.UseVisualStyleBackColor = true;
            this.btnDayArrRep.Click += new System.EventHandler(this.btnDayArrRep_Click);
            // 
            // btnDayOccRep
            // 
            this.btnDayOccRep.ForeColor = System.Drawing.Color.Black;
            this.btnDayOccRep.Location = new System.Drawing.Point(161, 199);
            this.btnDayOccRep.Name = "btnDayOccRep";
            this.btnDayOccRep.Size = new System.Drawing.Size(89, 56);
            this.btnDayOccRep.TabIndex = 6;
            this.btnDayOccRep.Text = "Daily Occupancy Report";
            this.btnDayOccRep.UseVisualStyleBackColor = true;
            this.btnDayOccRep.Click += new System.EventHandler(this.btnDayOccRep_Click);
            
            // 
            // gboxEmpAct
            // 
            this.gboxEmpAct.Controls.Add(this.btnBackF7);
            this.gboxEmpAct.Controls.Add(this.label1);
            this.gboxEmpAct.Controls.Add(this.btnDayOccRep);
            this.gboxEmpAct.Controls.Add(this.btnExOccRep);
            this.gboxEmpAct.Controls.Add(this.btnDayArrRep);
            this.gboxEmpAct.Controls.Add(this.btnPrntBill);
            this.gboxEmpAct.Controls.Add(this.btnIncentRep);
            this.gboxEmpAct.Controls.Add(this.btnChngRate);
            this.gboxEmpAct.Controls.Add(this.btnIncomeRep);
            this.gboxEmpAct.Location = new System.Drawing.Point(73, 49);
            this.gboxEmpAct.Name = "gboxEmpAct";
            this.gboxEmpAct.Size = new System.Drawing.Size(518, 359);
            this.gboxEmpAct.TabIndex = 8;
            this.gboxEmpAct.TabStop = false;
            this.gboxEmpAct.Enter += new System.EventHandler(this.gboxEmpAct_Enter);
            // 
            // btnBackF7
            // 
            this.btnBackF7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackF7.ForeColor = System.Drawing.Color.Black;
            this.btnBackF7.Location = new System.Drawing.Point(428, 19);
            this.btnBackF7.Name = "btnBackF7";
            this.btnBackF7.Size = new System.Drawing.Size(75, 23);
            this.btnBackF7.TabIndex = 16;
            this.btnBackF7.Text = "Back";
            this.btnBackF7.UseVisualStyleBackColor = true;
            this.btnBackF7.Click += new System.EventHandler(this.btnBackF7_Click);
            // 
            // EmpActs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(660, 469);
            this.Controls.Add(this.gboxEmpAct);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(676, 508);
            this.Name = "EmpActs";
            this.Text = "Employee Actions";
            this.gboxEmpAct.ResumeLayout(false);
            this.gboxEmpAct.PerformLayout();
            this.ResumeLayout(false);

            #region Labels
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "On this screen, you can choose to view reports, \r\nchange base rates, and print an" +
    " accommodation bill.";
            #endregion
        }

        #endregion

        private System.Windows.Forms.Button btnExOccRep;
        private System.Windows.Forms.Button btnPrntBill;
        private System.Windows.Forms.Button btnChngRate;
        private System.Windows.Forms.Button btnIncomeRep;
        private System.Windows.Forms.Button btnIncentRep;
        private System.Windows.Forms.Button btnDayArrRep;
        private System.Windows.Forms.Button btnDayOccRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxEmpAct;
        private System.Windows.Forms.Button btnBackF7;
    }
}