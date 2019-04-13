namespace WindowsFormsApplication1
{
    partial class ResConfirm
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
            this.btnPntBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMkChng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPntBill
            // 
            this.btnPntBill.ForeColor = System.Drawing.Color.Black;
            this.btnPntBill.Location = new System.Drawing.Point(321, 396);
            this.btnPntBill.Name = "btnPntBill";
            this.btnPntBill.Size = new System.Drawing.Size(89, 23);
            this.btnPntBill.TabIndex = 0;
            this.btnPntBill.Text = "Print this page";
            this.btnPntBill.UseVisualStyleBackColor = true;
            this.btnPntBill.Click += new System.EventHandler(this.btnPntBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation summary information coming soon...";
            // 
            // btnMkChng
            // 
            this.btnMkChng.ForeColor = System.Drawing.Color.Black;
            this.btnMkChng.Location = new System.Drawing.Point(207, 396);
            this.btnMkChng.Name = "btnMkChng";
            this.btnMkChng.Size = new System.Drawing.Size(100, 23);
            this.btnMkChng.TabIndex = 2;
            this.btnMkChng.Text = "Make Changes";
            this.btnMkChng.UseVisualStyleBackColor = true;
            this.btnMkChng.Click += new System.EventHandler(this.btnMkChng_Click);
            // 
            // ResConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 559);
            this.Controls.Add(this.btnMkChng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPntBill);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ResConfirm";
            this.Text = "Reservation Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPntBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMkChng;
    }
}