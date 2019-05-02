namespace WindowsFormsApplication1
{
    partial class ChngRate
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
            this.gboxChngRate = new System.Windows.Forms.GroupBox();
            this.calStart = new System.Windows.Forms.MonthCalendar();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.calEnd = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubmitRate = new System.Windows.Forms.Label();
            this.lblSetRate = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitRate = new System.Windows.Forms.Button();
            this.txtChngRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxChngRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxChngRate
            // 
            this.gboxChngRate.Controls.Add(this.calStart);
            this.gboxChngRate.Controls.Add(this.lblEndDate);
            this.gboxChngRate.Controls.Add(this.calEnd);
            this.gboxChngRate.Controls.Add(this.lblStartDate);
            this.gboxChngRate.Controls.Add(this.label3);
            this.gboxChngRate.Controls.Add(this.lblSubmitRate);
            this.gboxChngRate.Controls.Add(this.lblSetRate);
            this.gboxChngRate.Controls.Add(this.btnDone);
            this.gboxChngRate.Controls.Add(this.label2);
            this.gboxChngRate.Controls.Add(this.btnSubmitRate);
            this.gboxChngRate.Controls.Add(this.txtChngRate);
            this.gboxChngRate.Controls.Add(this.label1);
            this.gboxChngRate.Location = new System.Drawing.Point(91, 53);
            this.gboxChngRate.Margin = new System.Windows.Forms.Padding(4);
            this.gboxChngRate.Name = "gboxChngRate";
            this.gboxChngRate.Padding = new System.Windows.Forms.Padding(4);
            this.gboxChngRate.Size = new System.Drawing.Size(703, 468);
            this.gboxChngRate.TabIndex = 0;
            this.gboxChngRate.TabStop = false;
            this.gboxChngRate.Enter += new System.EventHandler(this.gboxChngRate_Enter);
            // 
            // calStart
            // 
            this.calStart.Location = new System.Drawing.Point(68, 88);
            this.calStart.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calStart.MaxSelectionCount = 1;
            this.calStart.Name = "calStart";
            this.calStart.TabIndex = 26;
            this.calStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStart_DateChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(401, 53);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(196, 24);
            this.lblEndDate.TabIndex = 29;
            this.lblEndDate.Text = "Through this selection";
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(371, 88);
            this.calEnd.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calEnd.MaxSelectionCount = 1;
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 28;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(155, 53);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 27;
            this.lblStartDate.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "USD";
            // 
            // lblSubmitRate
            // 
            this.lblSubmitRate.AutoSize = true;
            this.lblSubmitRate.Enabled = false;
            this.lblSubmitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitRate.ForeColor = System.Drawing.Color.Lime;
            this.lblSubmitRate.Location = new System.Drawing.Point(8, 434);
            this.lblSubmitRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubmitRate.Name = "lblSubmitRate";
            this.lblSubmitRate.Size = new System.Drawing.Size(227, 18);
            this.lblSubmitRate.TabIndex = 23;
            this.lblSubmitRate.Text = "Base rate successfully submitted!";
            // 
            // lblSetRate
            // 
            this.lblSetRate.AutoSize = true;
            this.lblSetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetRate.Location = new System.Drawing.Point(20, 306);
            this.lblSetRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetRate.Name = "lblSetRate";
            this.lblSetRate.Size = new System.Drawing.Size(128, 18);
            this.lblSetRate.TabIndex = 22;
            this.lblSetRate.Text = "Set Rate: (not set)";
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(594, 429);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 28);
            this.btnDone.TabIndex = 21;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Rate:";
            // 
            // btnSubmitRate
            // 
            this.btnSubmitRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitRate.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRate.Location = new System.Drawing.Point(486, 429);
            this.btnSubmitRate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRate.Name = "btnSubmitRate";
            this.btnSubmitRate.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitRate.TabIndex = 19;
            this.btnSubmitRate.Text = "Submit";
            this.btnSubmitRate.UseVisualStyleBackColor = true;
            this.btnSubmitRate.Click += new System.EventHandler(this.btnSubmitRate_Click);
            // 
            // txtChngRate
            // 
            this.txtChngRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChngRate.Location = new System.Drawing.Point(123, 332);
            this.txtChngRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtChngRate.Name = "txtChngRate";
            this.txtChngRate.Size = new System.Drawing.Size(119, 24);
            this.txtChngRate.TabIndex = 17;
            this.txtChngRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChngRate.TextChanged += new System.EventHandler(this.txtChngRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a date range for the dates you wish to set";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChngRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 577);
            this.Controls.Add(this.gboxChngRate);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(895, 614);
            this.Name = "ChngRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Base Rate";
            this.gboxChngRate.ResumeLayout(false);
            this.gboxChngRate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxChngRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChngRate;
        private System.Windows.Forms.Button btnSubmitRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubmitRate;
        private System.Windows.Forms.Label lblSetRate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.MonthCalendar calEnd;
        private System.Windows.Forms.Label lblStartDate;
    }
}