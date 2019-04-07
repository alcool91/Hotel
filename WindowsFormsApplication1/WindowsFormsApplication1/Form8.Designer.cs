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
            this.gboxChngRate.Controls.Add(this.label2);
            this.gboxChngRate.Controls.Add(this.btnSubmitRate);
            this.gboxChngRate.Controls.Add(this.dateChngRate);
            this.gboxChngRate.Controls.Add(this.txtChngRate);
            this.gboxChngRate.Controls.Add(this.label1);
            this.gboxChngRate.Location = new System.Drawing.Point(161, 121);
            this.gboxChngRate.Name = "gboxChngRate";
            this.gboxChngRate.Size = new System.Drawing.Size(337, 210);
            this.gboxChngRate.TabIndex = 0;
            this.gboxChngRate.TabStop = false;
            this.gboxChngRate.Enter += new System.EventHandler(this.gboxChngRate_Enter);
            // 
            // btnSubmitRate
            // 
            this.btnSubmitRate.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitRate.Location = new System.Drawing.Point(255, 178);
            this.btnSubmitRate.Name = "btnSubmitRate";
            this.btnSubmitRate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitRate.TabIndex = 19;
            this.btnSubmitRate.Text = "Submit";
            this.btnSubmitRate.UseVisualStyleBackColor = true;
            this.btnSubmitRate.Click += new System.EventHandler(this.btnSubmitRate_Click);
            // 
            // dateChngRate
            // 
            this.dateChngRate.Location = new System.Drawing.Point(56, 72);
            this.dateChngRate.Name = "dateChngRate";
            this.dateChngRate.Size = new System.Drawing.Size(200, 20);
            this.dateChngRate.TabIndex = 18;
            this.dateChngRate.ValueChanged += new System.EventHandler(this.dateChngRate_ValueChanged);
            // 
            // txtChngRate
            // 
            this.txtChngRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChngRate.Location = new System.Drawing.Point(103, 124);
            this.txtChngRate.Name = "txtChngRate";
            this.txtChngRate.Size = new System.Drawing.Size(179, 21);
            this.txtChngRate.TabIndex = 17;
            this.txtChngRate.Text = "Enter a new rate";
            this.txtChngRate.TextChanged += new System.EventHandler(this.txtChngRate_TextChanged);
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
            this.Text = "Change Base Rate";
            this.gboxChngRate.ResumeLayout(false);
            this.gboxChngRate.PerformLayout();
            this.ResumeLayout(false);

            #region Labels
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Rate:";
            #endregion
        }

        #endregion

        private System.Windows.Forms.GroupBox gboxChngRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateChngRate;
        private System.Windows.Forms.TextBox txtChngRate;
        private System.Windows.Forms.Button btnSubmitRate;
        private System.Windows.Forms.Label label2;
    }
}