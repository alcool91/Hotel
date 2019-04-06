namespace WindowsFormsApplication1
{
    partial class ResType
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
            this.lblType = new System.Windows.Forms.Label();
            this.chkdListBoxType = new System.Windows.Forms.CheckedListBox();
            this.btnSubmitRes = new System.Windows.Forms.Button();
            this.btnBackF5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(12, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(286, 16);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Please select the reservation type (select one):";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // chkdListBoxType
            // 
            this.chkdListBoxType.BackColor = System.Drawing.Color.Black;
            this.chkdListBoxType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkdListBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdListBoxType.ForeColor = System.Drawing.Color.White;
            this.chkdListBoxType.FormattingEnabled = true;
            this.chkdListBoxType.Items.AddRange(new object[] {
            "Prepaid Room Reservation",
            "60-day in Advance Room Reservation",
            "Conventional Room Reservation",
            "Incentive Room Reservation"});
            this.chkdListBoxType.Location = new System.Drawing.Point(29, 91);
            this.chkdListBoxType.Name = "chkdListBoxType";
            this.chkdListBoxType.Size = new System.Drawing.Size(269, 85);
            this.chkdListBoxType.TabIndex = 6;
            this.chkdListBoxType.SelectedIndexChanged += new System.EventHandler(this.chkdListBoxType_SelectedIndexChanged);
            // 
            // btnSubmitRes
            // 
            this.btnSubmitRes.Location = new System.Drawing.Point(228, 251);
            this.btnSubmitRes.Name = "btnSubmitRes";
            this.btnSubmitRes.Size = new System.Drawing.Size(126, 23);
            this.btnSubmitRes.TabIndex = 7;
            this.btnSubmitRes.Text = "Submit Reservation";
            this.btnSubmitRes.UseVisualStyleBackColor = true;
            this.btnSubmitRes.Click += new System.EventHandler(this.btnSubmitRes_Click);
            // 
            // btnBackF5
            // 
            this.btnBackF5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackF5.ForeColor = System.Drawing.Color.Black;
            this.btnBackF5.Location = new System.Drawing.Point(279, 12);
            this.btnBackF5.Name = "btnBackF5";
            this.btnBackF5.Size = new System.Drawing.Size(75, 23);
            this.btnBackF5.TabIndex = 14;
            this.btnBackF5.Text = "Back";
            this.btnBackF5.UseVisualStyleBackColor = true;
            this.btnBackF5.Click += new System.EventHandler(this.btnBackF5_Click);
            // 
            // ResType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(366, 286);
            this.Controls.Add(this.btnBackF5);
            this.Controls.Add(this.btnSubmitRes);
            this.Controls.Add(this.chkdListBoxType);
            this.Controls.Add(this.lblType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(382, 325);
            this.Name = "ResType";
            this.Text = "Reservation Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckedListBox chkdListBoxType;
        private System.Windows.Forms.Button btnSubmitRes;
        private System.Windows.Forms.Button btnBackF5;
    }
}