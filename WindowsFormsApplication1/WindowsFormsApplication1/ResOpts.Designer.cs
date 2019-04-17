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
            this.btnSearchRes = new System.Windows.Forms.Button();
            this.btnNewRes = new System.Windows.Forms.Button();
            this.btnBackF3 = new System.Windows.Forms.Button();
            this.gboxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRes
            // 
            this.gboxRes.Controls.Add(this.btnSearchRes);
            this.gboxRes.Controls.Add(this.btnNewRes);
            this.gboxRes.Controls.Add(this.btnBackF3);
            this.gboxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRes.ForeColor = System.Drawing.Color.White;
            this.gboxRes.Location = new System.Drawing.Point(12, 12);
            this.gboxRes.Name = "gboxRes";
            this.gboxRes.Size = new System.Drawing.Size(448, 162);
            this.gboxRes.TabIndex = 0;
            this.gboxRes.TabStop = false;
            this.gboxRes.Text = "Reservations Menu";
            this.gboxRes.Enter += new System.EventHandler(this.gboxRes_Enter);
            // 
            // btnSearchRes
            // 
            this.btnSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRes.ForeColor = System.Drawing.Color.Black;
            this.btnSearchRes.Location = new System.Drawing.Point(246, 63);
            this.btnSearchRes.Name = "btnSearchRes";
            this.btnSearchRes.Size = new System.Drawing.Size(130, 59);
            this.btnSearchRes.TabIndex = 7;
            this.btnSearchRes.Text = "Search Reservations";
            this.btnSearchRes.UseVisualStyleBackColor = true;
            this.btnSearchRes.Click += new System.EventHandler(this.btnSearchRes_Click);
            // 
            // btnNewRes
            // 
            this.btnNewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRes.ForeColor = System.Drawing.Color.Black;
            this.btnNewRes.Location = new System.Drawing.Point(75, 63);
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
            this.btnBackF3.Location = new System.Drawing.Point(356, 25);
            this.btnBackF3.Name = "btnBackF3";
            this.btnBackF3.Size = new System.Drawing.Size(75, 23);
            this.btnBackF3.TabIndex = 4;
            this.btnBackF3.Text = "Back";
            this.btnBackF3.UseVisualStyleBackColor = true;
            this.btnBackF3.Click += new System.EventHandler(this.btnBackF3_Click);
            // 
            // ResOpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 186);
            this.Controls.Add(this.gboxRes);
            this.MinimumSize = new System.Drawing.Size(488, 225);
            this.Name = "ResOpts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Options";
            this.gboxRes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRes;
        private System.Windows.Forms.Button btnBackF3;
        private System.Windows.Forms.Button btnSearchRes;
        private System.Windows.Forms.Button btnNewRes;
    }
}