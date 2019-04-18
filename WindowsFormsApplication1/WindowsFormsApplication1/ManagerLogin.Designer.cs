namespace WindowsFormsApplication1
{
    partial class ManagerLogin
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
            this.gboxManagerLogin = new System.Windows.Forms.GroupBox();
            this.btnManagerCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblManagerFail = new System.Windows.Forms.Label();
            this.btnManagerSubmit = new System.Windows.Forms.Button();
            this.txtManagerPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxManagerLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxManagerLogin
            // 
            this.gboxManagerLogin.Controls.Add(this.textBox1);
            this.gboxManagerLogin.Controls.Add(this.label2);
            this.gboxManagerLogin.Controls.Add(this.btnManagerCancel);
            this.gboxManagerLogin.Controls.Add(this.label1);
            this.gboxManagerLogin.Controls.Add(this.lblManagerFail);
            this.gboxManagerLogin.Controls.Add(this.btnManagerSubmit);
            this.gboxManagerLogin.Controls.Add(this.txtManagerPass);
            this.gboxManagerLogin.Controls.Add(this.lblPassword);
            this.gboxManagerLogin.ForeColor = System.Drawing.Color.White;
            this.gboxManagerLogin.Location = new System.Drawing.Point(43, 32);
            this.gboxManagerLogin.Name = "gboxManagerLogin";
            this.gboxManagerLogin.Size = new System.Drawing.Size(315, 266);
            this.gboxManagerLogin.TabIndex = 7;
            this.gboxManagerLogin.TabStop = false;
            this.gboxManagerLogin.Enter += new System.EventHandler(this.gboxManagerLogin_Enter);
            // 
            // btnManagerCancel
            // 
            this.btnManagerCancel.BackColor = System.Drawing.Color.White;
            this.btnManagerCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnManagerCancel.ForeColor = System.Drawing.Color.Black;
            this.btnManagerCancel.Location = new System.Drawing.Point(153, 191);
            this.btnManagerCancel.Name = "btnManagerCancel";
            this.btnManagerCancel.Size = new System.Drawing.Size(70, 23);
            this.btnManagerCancel.TabIndex = 8;
            this.btnManagerCancel.Text = "Cancel";
            this.btnManagerCancel.UseVisualStyleBackColor = false;
            this.btnManagerCancel.Click += new System.EventHandler(this.btnManagerCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manager authorization required  to perform this action! \r\nPlease re-enter manager" +
    " password below to continue:";
            // 
            // lblManagerFail
            // 
            this.lblManagerFail.AutoSize = true;
            this.lblManagerFail.Enabled = false;
            this.lblManagerFail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerFail.ForeColor = System.Drawing.Color.Red;
            this.lblManagerFail.Location = new System.Drawing.Point(74, 62);
            this.lblManagerFail.Name = "lblManagerFail";
            this.lblManagerFail.Size = new System.Drawing.Size(138, 14);
            this.lblManagerFail.TabIndex = 6;
            this.lblManagerFail.Text = "Failed to Authenticate User!";
            // 
            // btnManagerSubmit
            // 
            this.btnManagerSubmit.BackColor = System.Drawing.Color.White;
            this.btnManagerSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnManagerSubmit.Location = new System.Drawing.Point(77, 191);
            this.btnManagerSubmit.Name = "btnManagerSubmit";
            this.btnManagerSubmit.Size = new System.Drawing.Size(70, 23);
            this.btnManagerSubmit.TabIndex = 4;
            this.btnManagerSubmit.Text = "Submit";
            this.btnManagerSubmit.UseVisualStyleBackColor = false;
            this.btnManagerSubmit.Click += new System.EventHandler(this.btnManagerSubmit_Click);
            // 
            // txtManagerPass
            // 
            this.txtManagerPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtManagerPass.Location = new System.Drawing.Point(153, 143);
            this.txtManagerPass.Name = "txtManagerPass";
            this.txtManagerPass.PasswordChar = '*';
            this.txtManagerPass.Size = new System.Drawing.Size(100, 20);
            this.txtManagerPass.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(56, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(153, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // ManagerLogin
            // 
            this.AcceptButton = this.btnManagerSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnManagerCancel;
            this.ClientSize = new System.Drawing.Size(400, 335);
            this.Controls.Add(this.gboxManagerLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization Required";
            this.gboxManagerLogin.ResumeLayout(false);
            this.gboxManagerLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxManagerLogin;
        private System.Windows.Forms.Label lblManagerFail;
        private System.Windows.Forms.TextBox txtManagerPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagerCancel;
        private System.Windows.Forms.Button btnManagerSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}