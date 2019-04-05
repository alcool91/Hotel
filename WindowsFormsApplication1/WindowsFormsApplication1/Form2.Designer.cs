namespace WindowsFormsApplication1
{
    partial class MainScreen
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
            this.lblActvUser = new System.Windows.Forms.Label();
            this.gboxMain = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.gboxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActvUser
            // 
            this.lblActvUser.AutoSize = true;
            this.lblActvUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActvUser.ForeColor = System.Drawing.Color.White;
            this.lblActvUser.Location = new System.Drawing.Point(6, 22);
            this.lblActvUser.Name = "lblActvUser";
            this.lblActvUser.Size = new System.Drawing.Size(91, 13);
            this.lblActvUser.TabIndex = 2;
            this.lblActvUser.Text = "User: \"username\"";
            this.lblActvUser.Click += new System.EventHandler(this.lblActvUser_Click);
            // 
            // gboxMain
            // 
            this.gboxMain.BackColor = System.Drawing.Color.Black;
            this.gboxMain.Controls.Add(this.btnEmployee);
            this.gboxMain.Controls.Add(this.btnReservation);
            this.gboxMain.Controls.Add(this.btnLogout);
            this.gboxMain.Controls.Add(this.lblActvUser);
            this.gboxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMain.ForeColor = System.Drawing.Color.White;
            this.gboxMain.Location = new System.Drawing.Point(12, 12);
            this.gboxMain.Name = "gboxMain";
            this.gboxMain.Size = new System.Drawing.Size(448, 162);
            this.gboxMain.TabIndex = 3;
            this.gboxMain.TabStop = false;
            this.gboxMain.Text = "Welcome!";
            this.gboxMain.Enter += new System.EventHandler(this.gboxMain_Enter);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(358, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.Black;
            this.btnReservation.Location = new System.Drawing.Point(73, 62);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(130, 59);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Reservation Options";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Location = new System.Drawing.Point(249, 62);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(130, 59);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee Actions";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 186);
            this.Controls.Add(this.gboxMain);
            this.MinimumSize = new System.Drawing.Size(488, 225);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.gboxMain.ResumeLayout(false);
            this.gboxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblActvUser;
        private System.Windows.Forms.GroupBox gboxMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnReservation;
    }
}