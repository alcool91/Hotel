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
            this.lblEndDate = new System.Windows.Forms.Label();
            this.calEndDate = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.calStartDate = new System.Windows.Forms.MonthCalendar();
            this.tboxCCard = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.btnBackF4 = new System.Windows.Forms.Button();
            this.btnNextF4 = new System.Windows.Forms.Button();
            this.GboxNewRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboxNewRes
            // 
            this.GboxNewRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GboxNewRes.Controls.Add(this.btnNextF4);
            this.GboxNewRes.Controls.Add(this.btnBackF4);
            this.GboxNewRes.Controls.Add(this.lblEndDate);
            this.GboxNewRes.Controls.Add(this.calEndDate);
            this.GboxNewRes.Controls.Add(this.lblStartDate);
            this.GboxNewRes.Controls.Add(this.calStartDate);
            this.GboxNewRes.Controls.Add(this.tboxCCard);
            this.GboxNewRes.Controls.Add(this.tboxPhone);
            this.GboxNewRes.Controls.Add(this.tboxEmail);
            this.GboxNewRes.Controls.Add(this.tboxLastName);
            this.GboxNewRes.Controls.Add(this.tboxFirstName);
            this.GboxNewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxNewRes.ForeColor = System.Drawing.Color.White;
            this.GboxNewRes.Location = new System.Drawing.Point(51, 36);
            this.GboxNewRes.Name = "GboxNewRes";
            this.GboxNewRes.Size = new System.Drawing.Size(557, 516);
            this.GboxNewRes.TabIndex = 0;
            this.GboxNewRes.TabStop = false;
            this.GboxNewRes.Text = "Reservation Info";
            this.GboxNewRes.Enter += new System.EventHandler(this.gboxNewRes_Enter);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(327, 267);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(128, 18);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "Effective end date.";
            // 
            // calEndDate
            // 
            this.calEndDate.Location = new System.Drawing.Point(275, 294);
            this.calEndDate.MaxSelectionCount = 1;
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.TabIndex = 9;
            this.calEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEndDate_DateChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(79, 267);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(133, 18);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Effective start date.";
            // 
            // calStartDate
            // 
            this.calStartDate.Location = new System.Drawing.Point(30, 294);
            this.calStartDate.MaxSelectionCount = 1;
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.TabIndex = 7;
            this.calStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStartDate_DateChanged);
            // 
            // tboxCCard
            // 
            this.tboxCCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCCard.Location = new System.Drawing.Point(29, 218);
            this.tboxCCard.Name = "tboxCCard";
            this.tboxCCard.Size = new System.Drawing.Size(322, 24);
            this.tboxCCard.TabIndex = 5;
            this.tboxCCard.Text = "Credit Card Number";
            this.tboxCCard.TextChanged += new System.EventHandler(this.tboxCCard_TextChanged);
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPhone.Location = new System.Drawing.Point(29, 170);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(167, 24);
            this.tboxPhone.TabIndex = 4;
            this.tboxPhone.Text = "Phone";
            this.tboxPhone.TextChanged += new System.EventHandler(this.tboxPhone_TextChanged);
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(29, 123);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(322, 24);
            this.tboxEmail.TabIndex = 3;
            this.tboxEmail.Text = "Email Address";
            this.tboxEmail.TextChanged += new System.EventHandler(this.tboxEmail_TextChanged);
            // 
            // tboxLastName
            // 
            this.tboxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLastName.Location = new System.Drawing.Point(205, 75);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(205, 24);
            this.tboxLastName.TabIndex = 2;
            this.tboxLastName.Text = "Last Name";
            this.tboxLastName.TextChanged += new System.EventHandler(this.tboxLastName_TextChanged);
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxFirstName.Location = new System.Drawing.Point(29, 75);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(150, 24);
            this.tboxFirstName.TabIndex = 0;
            this.tboxFirstName.Text = "First Name";
            this.tboxFirstName.TextChanged += new System.EventHandler(this.tboxFirstName_TextChanged);
            // 
            // btnBackF4
            // 
            this.btnBackF4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackF4.ForeColor = System.Drawing.Color.Black;
            this.btnBackF4.Location = new System.Drawing.Point(467, 25);
            this.btnBackF4.Name = "btnBackF4";
            this.btnBackF4.Size = new System.Drawing.Size(75, 23);
            this.btnBackF4.TabIndex = 13;
            this.btnBackF4.Text = "Back";
            this.btnBackF4.UseVisualStyleBackColor = true;
            this.btnBackF4.Click += new System.EventHandler(this.btnBackF4_Click);
            // 
            // btnNextF4
            // 
            this.btnNextF4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextF4.ForeColor = System.Drawing.Color.Black;
            this.btnNextF4.Location = new System.Drawing.Point(467, 477);
            this.btnNextF4.Name = "btnNextF4";
            this.btnNextF4.Size = new System.Drawing.Size(75, 23);
            this.btnNextF4.TabIndex = 14;
            this.btnNextF4.Text = "Next";
            this.btnNextF4.UseVisualStyleBackColor = true;
            this.btnNextF4.Click += new System.EventHandler(this.btnNextF4_Click);
            // 
            // CreateNewRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(660, 602);
            this.Controls.Add(this.GboxNewRes);
            this.MinimumSize = new System.Drawing.Size(676, 641);
            this.Name = "CreateNewRes";
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
        private System.Windows.Forms.TextBox tboxCCard;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.Button btnNextF4;
        private System.Windows.Forms.Button btnBackF4;
    }
}