namespace WindowsFormsApplication1
{
    partial class ResOpts
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
            this.gboxRes = new System.Windows.Forms.GroupBox();
            this.btnNewRes = new System.Windows.Forms.Button();
            this.btnBackF3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchRes = new System.Windows.Forms.Button();
            this.gboxRes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRes
            // 
            this.gboxRes.Controls.Add(this.btnNewRes);
            this.gboxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRes.ForeColor = System.Drawing.Color.White;
            this.gboxRes.Location = new System.Drawing.Point(33, 59);
            this.gboxRes.Name = "gboxRes";
            this.gboxRes.Size = new System.Drawing.Size(313, 184);
            this.gboxRes.TabIndex = 0;
            this.gboxRes.TabStop = false;
            this.gboxRes.Text = "Reservations Menu";
            this.gboxRes.Enter += new System.EventHandler(this.gboxRes_Enter);
            // 
            // btnNewRes
            // 
            this.btnNewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRes.ForeColor = System.Drawing.Color.Black;
            this.btnNewRes.Location = new System.Drawing.Point(89, 68);
            this.btnNewRes.Name = "btnNewRes";
            this.btnNewRes.Size = new System.Drawing.Size(130, 59);
            this.btnNewRes.TabIndex = 5;
            this.btnNewRes.Text = "Create New Reservation";
            this.btnNewRes.UseVisualStyleBackColor = true;
            this.btnNewRes.Click += new System.EventHandler(this.btnNewRes_Click);
            // 
            // btnBackF3
            // 
            this.btnBackF3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackF3.ForeColor = System.Drawing.Color.Black;
            this.btnBackF3.Location = new System.Drawing.Point(692, 12);
            this.btnBackF3.Name = "btnBackF3";
            this.btnBackF3.Size = new System.Drawing.Size(75, 23);
            this.btnBackF3.TabIndex = 4;
            this.btnBackF3.Text = "Back";
            this.btnBackF3.UseVisualStyleBackColor = true;
            this.btnBackF3.Click += new System.EventHandler(this.btnBackF3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchRes);
            this.groupBox1.Controls.Add(this.txtSearchRes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(352, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Reservation";
            // 
            // txtSearchRes
            // 
            this.txtSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRes.Location = new System.Drawing.Point(54, 96);
            this.txtSearchRes.Name = "txtSearchRes";
            this.txtSearchRes.Size = new System.Drawing.Size(179, 21);
            this.txtSearchRes.TabIndex = 20;
            this.txtSearchRes.Text = "Enter a last name";
            this.txtSearchRes.TextChanged += new System.EventHandler(this.txtSearchRes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please enter the last name of the guest whose \r\nreservation you wish to search:";
            // 
            // btnSearchRes
            // 
            this.btnSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRes.ForeColor = System.Drawing.Color.Black;
            this.btnSearchRes.Location = new System.Drawing.Point(261, 94);
            this.btnSearchRes.Name = "btnSearchRes";
            this.btnSearchRes.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRes.TabIndex = 7;
            this.btnSearchRes.Text = "Search Reservations";
            this.btnSearchRes.UseVisualStyleBackColor = true;
            this.btnSearchRes.Click += new System.EventHandler(this.btnSearchRes_Click);
            // 
            // ResOpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(779, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxRes);
            this.Controls.Add(this.btnBackF3);
            this.MinimumSize = new System.Drawing.Size(488, 225);
            this.Name = "ResOpts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Options";
            this.gboxRes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRes;
        private System.Windows.Forms.Button btnBackF3;
        private System.Windows.Forms.Button btnNewRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchRes;
    }
}