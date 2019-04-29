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
            this.btnSearchRes = new System.Windows.Forms.Button();
            this.txtSearchRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxRes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRes
            // 
            this.gboxRes.Controls.Add(this.btnNewRes);
            this.gboxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRes.ForeColor = System.Drawing.Color.White;
            this.gboxRes.Location = new System.Drawing.Point(50, 91);
            this.gboxRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxRes.Name = "gboxRes";
            this.gboxRes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxRes.Size = new System.Drawing.Size(470, 283);
            this.gboxRes.TabIndex = 0;
            this.gboxRes.TabStop = false;
            this.gboxRes.Text = "Reservations Menu";
            this.gboxRes.Enter += new System.EventHandler(this.gboxRes_Enter);
            // 
            // btnNewRes
            // 
            this.btnNewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRes.ForeColor = System.Drawing.Color.Black;
            this.btnNewRes.Location = new System.Drawing.Point(134, 105);
            this.btnNewRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewRes.Name = "btnNewRes";
            this.btnNewRes.Size = new System.Drawing.Size(195, 91);
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
            this.btnBackF3.Location = new System.Drawing.Point(1038, 18);
            this.btnBackF3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackF3.Name = "btnBackF3";
            this.btnBackF3.Size = new System.Drawing.Size(112, 35);
            this.btnBackF3.TabIndex = 4;
            this.btnBackF3.Text = "Back";
            this.btnBackF3.UseVisualStyleBackColor = true;
            this.btnBackF3.Click += new System.EventHandler(this.btnBackF3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnSearchRes);
            this.groupBox1.Controls.Add(this.txtSearchRes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(528, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(588, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Reservation";
            // 
            // btnSearchRes
            // 
            this.btnSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRes.ForeColor = System.Drawing.Color.Black;
            this.btnSearchRes.Location = new System.Drawing.Point(468, 238);
            this.btnSearchRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchRes.Name = "btnSearchRes";
            this.btnSearchRes.Size = new System.Drawing.Size(112, 35);
            this.btnSearchRes.TabIndex = 7;
            this.btnSearchRes.Text = "Search Reservations";
            this.btnSearchRes.UseVisualStyleBackColor = true;
            this.btnSearchRes.Click += new System.EventHandler(this.btnSearchRes_Click);
            // 
            // txtSearchRes
            // 
            this.txtSearchRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRes.Location = new System.Drawing.Point(248, 148);
            this.txtSearchRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchRes.Name = "txtSearchRes";
            this.txtSearchRes.Size = new System.Drawing.Size(176, 28);
            this.txtSearchRes.TabIndex = 20;
            this.txtSearchRes.TextChanged += new System.EventHandler(this.txtSearchRes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please enter the last name of the guest whose \r\nreservation you wish to search:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(248, 196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 28);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search By Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search By Phone:";
            // 
            // ResOpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1168, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxRes);
            this.Controls.Add(this.btnBackF3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(721, 316);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}