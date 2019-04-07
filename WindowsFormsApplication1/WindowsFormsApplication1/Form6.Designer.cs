namespace WindowsFormsApplication1
{
    partial class SearchRes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackF6 = new System.Windows.Forms.Button();
            this.txtSearchRes = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackF6
            // 
            this.btnBackF6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackF6.ForeColor = System.Drawing.Color.Black;
            this.btnBackF6.Location = new System.Drawing.Point(308, 9);
            this.btnBackF6.Name = "btnBackF6";
            this.btnBackF6.Size = new System.Drawing.Size(75, 23);
            this.btnBackF6.TabIndex = 15;
            this.btnBackF6.Text = "Back";
            this.btnBackF6.UseVisualStyleBackColor = true;
            this.btnBackF6.Click += new System.EventHandler(this.btnBackF6_Click);
            // 
            // txtSearchRes
            // 
            this.txtSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRes.Location = new System.Drawing.Point(59, 59);
            this.txtSearchRes.Name = "txtSearchRes";
            this.txtSearchRes.Size = new System.Drawing.Size(179, 21);
            this.txtSearchRes.TabIndex = 16;
            this.txtSearchRes.Text = "Enter a last name";
            // 
            // btnSearchName
            // 
            this.btnSearchName.ForeColor = System.Drawing.Color.Black;
            this.btnSearchName.Location = new System.Drawing.Point(308, 105);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchName.TabIndex = 17;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // SearchRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(395, 140);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearchRes);
            this.Controls.Add(this.btnBackF6);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SearchRes";
            this.Text = "Search Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

            #region Labels
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the last name of the guest whose \r\nreservation you wish to search:";
            #endregion
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackF6;
        private System.Windows.Forms.TextBox txtSearchRes;
        private System.Windows.Forms.Button btnSearchName;
    }
}