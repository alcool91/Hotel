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
            this.label1 = new System.Windows.Forms.Label();
            this.lblManagerFail = new System.Windows.Forms.Label();
            this.btnManagerLogin = new System.Windows.Forms.Button();
            this.txtManagerPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtManagerUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnManagerCancel = new System.Windows.Forms.Button();
            this.gboxManagerLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxManagerLogin
            // 
            this.gboxManagerLogin.Controls.Add(this.btnManagerCancel);
            this.gboxManagerLogin.Controls.Add(this.label1);
            this.gboxManagerLogin.Controls.Add(this.lblManagerFail);
            this.gboxManagerLogin.Controls.Add(this.btnManagerLogin);
            this.gboxManagerLogin.Controls.Add(this.txtManagerPass);
            this.gboxManagerLogin.Controls.Add(this.lblPassword);
            this.gboxManagerLogin.Controls.Add(this.txtManagerUser);
            this.gboxManagerLogin.Controls.Add(this.lblUser);
            this.gboxManagerLogin.ForeColor = System.Drawing.Color.White;
            this.gboxManagerLogin.Location = new System.Drawing.Point(43, 32);
            this.gboxManagerLogin.Name = "gboxManagerLogin";
            this.gboxManagerLogin.Size = new System.Drawing.Size(315, 230);
            this.gboxManagerLogin.TabIndex = 7;
            this.gboxManagerLogin.TabStop = false;
            this.gboxManagerLogin.Enter += new System.EventHandler(this.gboxManagerLogin_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manager authorization required  to perform this action! \r\nPlease enter manager cr" +
    "edentials below to continue:";
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
            // btnManagerLogin
            // 
            this.btnManagerLogin.BackColor = System.Drawing.Color.White;
            this.btnManagerLogin.ForeColor = System.Drawing.Color.Black;
            this.btnManagerLogin.Location = new System.Drawing.Point(73, 184);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(70, 23);
            this.btnManagerLogin.TabIndex = 4;
            this.btnManagerLogin.Text = "Login";
            this.btnManagerLogin.UseVisualStyleBackColor = false;
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // txtManagerPass
            // 
            this.txtManagerPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtManagerPass.Location = new System.Drawing.Point(149, 136);
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
            this.lblPassword.Location = new System.Drawing.Point(52, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtManagerUser
            // 
            this.txtManagerUser.Location = new System.Drawing.Point(149, 90);
            this.txtManagerUser.Name = "txtManagerUser";
            this.txtManagerUser.Size = new System.Drawing.Size(100, 20);
            this.txtManagerUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Black;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(40, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(103, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Name:";
            // 
            // btnManagerCancel
            // 
            this.btnManagerCancel.BackColor = System.Drawing.Color.White;
            this.btnManagerCancel.ForeColor = System.Drawing.Color.Black;
            this.btnManagerCancel.Location = new System.Drawing.Point(149, 184);
            this.btnManagerCancel.Name = "btnManagerCancel";
            this.btnManagerCancel.Size = new System.Drawing.Size(70, 23);
            this.btnManagerCancel.TabIndex = 8;
            this.btnManagerCancel.Text = "Cancel";
            this.btnManagerCancel.UseVisualStyleBackColor = false;
            this.btnManagerCancel.Click += new System.EventHandler(this.btnManagerCancel_Click);
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 299);
            this.Controls.Add(this.gboxManagerLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ManagerLogin";
            this.Text = "Authorization Required";
            this.gboxManagerLogin.ResumeLayout(false);
            this.gboxManagerLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxManagerLogin;
        private System.Windows.Forms.Label lblManagerFail;
        private System.Windows.Forms.Button btnManagerLogin;
        private System.Windows.Forms.TextBox txtManagerPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtManagerUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagerCancel;
    }
}