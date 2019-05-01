namespace WindowsFormsApplication1
{
    partial class CreateNewRes
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
            this.GboxNewRes = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCCard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calStartDate = new System.Windows.Forms.MonthCalendar();
            this.btnDoneNewRes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitRes = new System.Windows.Forms.Button();
            this.btnGoPrnt = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.calEndDate = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.GboxNewRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboxNewRes
            // 
            this.GboxNewRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GboxNewRes.Controls.Add(this.label9);
            this.GboxNewRes.Controls.Add(this.label5);
            this.GboxNewRes.Controls.Add(this.txtCCard);
            this.GboxNewRes.Controls.Add(this.label8);
            this.GboxNewRes.Controls.Add(this.label7);
            this.GboxNewRes.Controls.Add(this.comboBox1);
            this.GboxNewRes.Controls.Add(this.label6);
            this.GboxNewRes.Controls.Add(this.calStartDate);
            this.GboxNewRes.Controls.Add(this.btnDoneNewRes);
            this.GboxNewRes.Controls.Add(this.label4);
            this.GboxNewRes.Controls.Add(this.label3);
            this.GboxNewRes.Controls.Add(this.label2);
            this.GboxNewRes.Controls.Add(this.label1);
            this.GboxNewRes.Controls.Add(this.btnSubmitRes);
            this.GboxNewRes.Controls.Add(this.btnGoPrnt);
            this.GboxNewRes.Controls.Add(this.lblEndDate);
            this.GboxNewRes.Controls.Add(this.calEndDate);
            this.GboxNewRes.Controls.Add(this.lblStartDate);
            this.GboxNewRes.Controls.Add(this.txtPhone);
            this.GboxNewRes.Controls.Add(this.txtEmail);
            this.GboxNewRes.Controls.Add(this.txtLastName);
            this.GboxNewRes.Controls.Add(this.txtFirstName);
            this.GboxNewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxNewRes.ForeColor = System.Drawing.Color.White;
            this.GboxNewRes.Location = new System.Drawing.Point(76, 49);
            this.GboxNewRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxNewRes.Name = "GboxNewRes";
            this.GboxNewRes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxNewRes.Size = new System.Drawing.Size(1050, 794);
            this.GboxNewRes.TabIndex = 0;
            this.GboxNewRes.TabStop = false;
            this.GboxNewRes.Text = "Reservation Info";
            this.GboxNewRes.Enter += new System.EventHandler(this.gboxNewRes_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(673, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cost";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 625);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Credit Card Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCCard
            // 
            this.txtCCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCard.Location = new System.Drawing.Point(422, 619);
            this.txtCCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCCard.Name = "txtCCard";
            this.txtCCard.Size = new System.Drawing.Size(481, 33);
            this.txtCCard.TabIndex = 5;
            this.txtCCard.TextChanged += new System.EventHandler(this.txtCCard_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cost:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Reservation:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 37);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(26, 738);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(737, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reservation has been successfully submitted. Click \"Done\" to return to the previo" +
    "us screen.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // calStartDate
            // 
            this.calStartDate.Location = new System.Drawing.Point(116, 101);
            this.calStartDate.Margin = new System.Windows.Forms.Padding(14);
            this.calStartDate.MaxSelectionCount = 1;
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.TabIndex = 7;
            this.calStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStartDate_DateChanged);
            // 
            // btnDoneNewRes
            // 
            this.btnDoneNewRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoneNewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneNewRes.ForeColor = System.Drawing.Color.Black;
            this.btnDoneNewRes.Location = new System.Drawing.Point(922, 229);
            this.btnDoneNewRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoneNewRes.Name = "btnDoneNewRes";
            this.btnDoneNewRes.Size = new System.Drawing.Size(120, 35);
            this.btnDoneNewRes.TabIndex = 20;
            this.btnDoneNewRes.Text = "Back";
            this.btnDoneNewRes.UseVisualStyleBackColor = true;
            this.btnDoneNewRes.Click += new System.EventHandler(this.btnDoneNewRes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 549);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 549);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubmitRes
            // 
            this.btnSubmitRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRes.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRes.Location = new System.Drawing.Point(922, 119);
            this.btnSubmitRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitRes.Name = "btnSubmitRes";
            this.btnSubmitRes.Size = new System.Drawing.Size(120, 35);
            this.btnSubmitRes.TabIndex = 14;
            this.btnSubmitRes.Text = "Submit";
            this.btnSubmitRes.UseVisualStyleBackColor = true;
            this.btnSubmitRes.Click += new System.EventHandler(this.btnSubmitRes_Click);
            // 
            // btnGoPrnt
            // 
            this.btnGoPrnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoPrnt.Enabled = false;
            this.btnGoPrnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoPrnt.ForeColor = System.Drawing.Color.Black;
            this.btnGoPrnt.Location = new System.Drawing.Point(922, 175);
            this.btnGoPrnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoPrnt.Name = "btnGoPrnt";
            this.btnGoPrnt.Size = new System.Drawing.Size(120, 35);
            this.btnGoPrnt.TabIndex = 13;
            this.btnGoPrnt.Text = "Go to print";
            this.btnGoPrnt.UseVisualStyleBackColor = true;
            this.btnGoPrnt.Click += new System.EventHandler(this.btnGoPrnt_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(589, 58);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(187, 29);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "Check Out Date:";
            // 
            // calEndDate
            // 
            this.calEndDate.Location = new System.Drawing.Point(530, 101);
            this.calEndDate.Margin = new System.Windows.Forms.Padding(14);
            this.calEndDate.MaxSelectionCount = 1;
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.TabIndex = 9;
            this.calEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEndDate_DateChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(173, 58);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(168, 29);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Check In Date:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(754, 543);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 33);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(207, 543);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 33);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(696, 476);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(306, 33);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(267, 482);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(223, 33);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // CreateNewRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1204, 926);
            this.Controls.Add(this.GboxNewRes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1003, 956);
            this.Name = "CreateNewRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Reservation";
            this.GboxNewRes.ResumeLayout(false);
            this.GboxNewRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxNewRes;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.MonthCalendar calEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.MonthCalendar calStartDate;
        private System.Windows.Forms.TextBox txtCCard;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSubmitRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoneNewRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGoPrnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}