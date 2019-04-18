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
            this.btnBackF6 = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBackF6
            // 
            this.btnBackF6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackF6.ForeColor = System.Drawing.Color.Black;
            this.btnBackF6.Location = new System.Drawing.Point(392, 9);
            this.btnBackF6.Name = "btnBackF6";
            this.btnBackF6.Size = new System.Drawing.Size(75, 23);
            this.btnBackF6.TabIndex = 15;
            this.btnBackF6.Text = "Back";
            this.btnBackF6.UseVisualStyleBackColor = true;
            this.btnBackF6.Click += new System.EventHandler(this.btnBackF6_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchName.ForeColor = System.Drawing.Color.Black;
            this.btnSearchName.Location = new System.Drawing.Point(392, 440);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchName.TabIndex = 17;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 355);
            this.listBox1.TabIndex = 18;
            // 
            // SearchRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 475);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnBackF6);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(495, 514);
            this.Name = "SearchRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Reservations";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackF6;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.ListBox listBox1;
    }
}