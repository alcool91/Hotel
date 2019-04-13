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
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubmitRate = new System.Windows.Forms.Label();
            this.lblSetRate = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitRate = new System.Windows.Forms.Button();
            this.dateChngRate = new System.Windows.Forms.DateTimePicker();
            this.txtChngRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxChngRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxChngRate
            // 
            this.gboxChngRate.Controls.Add(this.label3);
            this.gboxChngRate.Controls.Add(this.lblSubmitRate);
            this.gboxChngRate.Controls.Add(this.lblSetRate);
            this.gboxChngRate.Controls.Add(this.btnDone);
            this.gboxChngRate.Controls.Add(this.label2);
            this.gboxChngRate.Controls.Add(this.btnSubmitRate);
            this.gboxChngRate.Controls.Add(this.dateChngRate);
            this.gboxChngRate.Controls.Add(this.txtChngRate);
            this.gboxChngRate.Controls.Add(this.label1);
            this.gboxChngRate.Location = new System.Drawing.Point(161, 69);
            this.gboxChngRate.Name = "gboxChngRate";
            this.gboxChngRate.Size = new System.Drawing.Size(337, 262);
            this.gboxChngRate.TabIndex = 0;
            this.gboxChngRate.TabStop = false;
            this.gboxChngRate.Enter += new System.EventHandler(this.gboxChngRate_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "USD";
            // 
            // lblSubmitRate
            // 
            this.lblSubmitRate.AutoSize = true;
            this.lblSubmitRate.Enabled = false;
            this.lblSubmitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitRate.ForeColor = System.Drawing.Color.Green;
            this.lblSubmitRate.Location = new System.Drawing.Point(62, 203);
            this.lblSubmitRate.Name = "lblSubmitRate";
            this.lblSubmitRate.Size = new System.Drawing.Size(187, 15);
            this.lblSubmitRate.TabIndex = 23;
            this.lblSubmitRate.Text = "Base rate successfully submitted!";
            // 
            // lblSetRate
            // 
            this.lblSetRate.AutoSize = true;
            this.lblSetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetRate.Location = new System.Drawing.Point(62, 99);
            this.lblSetRate.Name = "lblSetRate";
            this.lblSetRate.Size = new System.Drawing.Size(104, 15);
            this.lblSetRate.TabIndex = 22;
            this.lblSetRate.Text = "Set Rate: (not set)";
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(255, 230);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
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
            this.label2.Location = new System.Drawing.Point(53, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Rate:";
            // 
            // btnSubmitRate
            // 
            this.btnSubmitRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitRate.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRate.Location = new System.Drawing.Point(174, 230);
            this.btnSubmitRate.Name = "btnSubmitRate";
            this.btnSubmitRate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitRate.TabIndex = 19;
            this.btnSubmitRate.Text = "Submit";
            this.btnSubmitRate.UseVisualStyleBackColor = true;
            this.btnSubmitRate.Click += new System.EventHandler(this.btnSubmitRate_Click);
            // 
            // dateChngRate
            // 
            this.dateChngRate.Location = new System.Drawing.Point(56, 76);
            this.dateChngRate.Name = "dateChngRate";
            this.dateChngRate.Size = new System.Drawing.Size(200, 20);
            this.dateChngRate.TabIndex = 18;
            this.dateChngRate.ValueChanged += new System.EventHandler(this.dateChngRate_ValueChanged);
            // 
            // txtChngRate
            // 
            this.txtChngRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChngRate.Location = new System.Drawing.Point(138, 140);
            this.txtChngRate.Name = "txtChngRate";
            this.txtChngRate.Size = new System.Drawing.Size(90, 21);
            this.txtChngRate.TabIndex = 17;
            this.txtChngRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChngRate.TextChanged += new System.EventHandler(this.txtChngRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a date for the rate you wish to set.\r\nThen enter the new base rate." +
    "";
            // 
            // ChngRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(660, 469);
            this.Controls.Add(this.gboxChngRate);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(676, 508);
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
        private System.Windows.Forms.DateTimePicker dateChngRate;
        private System.Windows.Forms.TextBox txtChngRate;
        private System.Windows.Forms.Button btnSubmitRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubmitRate;
        private System.Windows.Forms.Label lblSetRate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label3;
    }
}