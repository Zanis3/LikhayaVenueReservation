namespace LikhayaVenueReservation
{
    partial class UCAdminEditProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnEditUsername = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlEditAdminProfile = new System.Windows.Forms.Panel();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.pnlEditAdminProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(97, 133);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 35);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(92, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 30);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(134, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(296, 45);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Edit Admin Profile";
            // 
            // btnEditUsername
            // 
            this.btnEditUsername.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsername.ForeColor = System.Drawing.Color.White;
            this.btnEditUsername.Location = new System.Drawing.Point(368, 128);
            this.btnEditUsername.Name = "btnEditUsername";
            this.btnEditUsername.Size = new System.Drawing.Size(125, 40);
            this.btnEditUsername.TabIndex = 3;
            this.btnEditUsername.Text = "Edit";
            this.btnEditUsername.UseVisualStyleBackColor = false;
            this.btnEditUsername.Click += new System.EventHandler(this.btnEditUsername_Click);
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.ForeColor = System.Drawing.Color.White;
            this.btnEditPassword.Location = new System.Drawing.Point(368, 209);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(125, 40);
            this.btnEditPassword.TabIndex = 6;
            this.btnEditPassword.Text = "Edit";
            this.btnEditPassword.UseVisualStyleBackColor = false;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(97, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 30);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(97, 214);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 35);
            this.txtPassword.TabIndex = 4;
            // 
            // pnlEditAdminProfile
            // 
            this.pnlEditAdminProfile.Controls.Add(this.btnShowPassword);
            this.pnlEditAdminProfile.Controls.Add(this.btnDeleteAccount);
            this.pnlEditAdminProfile.Controls.Add(this.lblHeader);
            this.pnlEditAdminProfile.Controls.Add(this.btnEditPassword);
            this.pnlEditAdminProfile.Controls.Add(this.txtUsername);
            this.pnlEditAdminProfile.Controls.Add(this.lblPassword);
            this.pnlEditAdminProfile.Controls.Add(this.lblUsername);
            this.pnlEditAdminProfile.Controls.Add(this.txtPassword);
            this.pnlEditAdminProfile.Controls.Add(this.btnEditUsername);
            this.pnlEditAdminProfile.Location = new System.Drawing.Point(174, 107);
            this.pnlEditAdminProfile.Name = "pnlEditAdminProfile";
            this.pnlEditAdminProfile.Size = new System.Drawing.Size(564, 413);
            this.pnlEditAdminProfile.TabIndex = 7;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(196, 323);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(175, 40);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.Location = new System.Drawing.Point(247, 213);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(100, 35);
            this.btnShowPassword.TabIndex = 8;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // UCAdminEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LikhayaVenueReservation.Properties.Resources.OOP_HOMESCREEN;
            this.Controls.Add(this.pnlEditAdminProfile);
            this.Name = "UCAdminEditProfile";
            this.Size = new System.Drawing.Size(920, 610);
            this.pnlEditAdminProfile.ResumeLayout(false);
            this.pnlEditAdminProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnEditUsername;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlEditAdminProfile;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnShowPassword;
    }
}
