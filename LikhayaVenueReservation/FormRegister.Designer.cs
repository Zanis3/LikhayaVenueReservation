namespace LikhayaVenueReservation
{
    partial class FormRegister
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
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.GroupBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlUserGroupDetails = new System.Windows.Forms.GroupBox();
            this.rdoUserClassOutsider = new System.Windows.Forms.RadioButton();
            this.rdoUserClassStudent = new System.Windows.Forms.RadioButton();
            this.lblUserDesignation = new System.Windows.Forms.Label();
            this.txtUserDesignation = new System.Windows.Forms.TextBox();
            this.lblUserGroup = new System.Windows.Forms.Label();
            this.txtUserGroup = new System.Windows.Forms.TextBox();
            this.lblUserClassification = new System.Windows.Forms.Label();
            this.txtUserClassification = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlLegalName = new System.Windows.Forms.GroupBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.imgUMAKLogo = new System.Windows.Forms.PictureBox();
            this.pnlRegistration.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUserGroupDetails.SuspendLayout();
            this.pnlLegalName.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUMAKLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.Controls.Add(this.btnClear);
            this.pnlRegistration.Controls.Add(this.btnRegister);
            this.pnlRegistration.Controls.Add(this.pnlPassword);
            this.pnlRegistration.Controls.Add(this.pnlUserGroupDetails);
            this.pnlRegistration.Controls.Add(this.btnReturn);
            this.pnlRegistration.Controls.Add(this.pnlLegalName);
            this.pnlRegistration.Controls.Add(this.pnlHeader);
            this.pnlRegistration.Location = new System.Drawing.Point(145, 0);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(980, 681);
            this.pnlRegistration.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(502, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(265, 560);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(175, 40);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassword.Location = new System.Drawing.Point(37, 402);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(900, 100);
            this.pnlPassword.TabIndex = 6;
            this.pnlPassword.TabStop = false;
            this.pnlPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(371, 34);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(146, 21);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(375, 58);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 29);
            this.txtConfirmPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(147, 34);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 29);
            this.txtPassword.TabIndex = 2;
            // 
            // pnlUserGroupDetails
            // 
            this.pnlUserGroupDetails.Controls.Add(this.rdoUserClassOutsider);
            this.pnlUserGroupDetails.Controls.Add(this.rdoUserClassStudent);
            this.pnlUserGroupDetails.Controls.Add(this.lblUserDesignation);
            this.pnlUserGroupDetails.Controls.Add(this.txtUserDesignation);
            this.pnlUserGroupDetails.Controls.Add(this.lblUserGroup);
            this.pnlUserGroupDetails.Controls.Add(this.txtUserGroup);
            this.pnlUserGroupDetails.Controls.Add(this.lblUserClassification);
            this.pnlUserGroupDetails.Controls.Add(this.txtUserClassification);
            this.pnlUserGroupDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUserGroupDetails.Location = new System.Drawing.Point(37, 268);
            this.pnlUserGroupDetails.Name = "pnlUserGroupDetails";
            this.pnlUserGroupDetails.Size = new System.Drawing.Size(900, 100);
            this.pnlUserGroupDetails.TabIndex = 6;
            this.pnlUserGroupDetails.TabStop = false;
            this.pnlUserGroupDetails.Text = "User Details";
            // 
            // rdoUserClassOutsider
            // 
            this.rdoUserClassOutsider.AutoSize = true;
            this.rdoUserClassOutsider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoUserClassOutsider.Location = new System.Drawing.Point(31, 64);
            this.rdoUserClassOutsider.Name = "rdoUserClassOutsider";
            this.rdoUserClassOutsider.Size = new System.Drawing.Size(91, 25);
            this.rdoUserClassOutsider.TabIndex = 7;
            this.rdoUserClassOutsider.Text = "Outsider";
            this.rdoUserClassOutsider.UseVisualStyleBackColor = true;
            this.rdoUserClassOutsider.CheckedChanged += new System.EventHandler(this.rdoUserClassOutsider_CheckedChanged);
            // 
            // rdoUserClassStudent
            // 
            this.rdoUserClassStudent.AutoSize = true;
            this.rdoUserClassStudent.Checked = true;
            this.rdoUserClassStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoUserClassStudent.Location = new System.Drawing.Point(31, 32);
            this.rdoUserClassStudent.Name = "rdoUserClassStudent";
            this.rdoUserClassStudent.Size = new System.Drawing.Size(86, 25);
            this.rdoUserClassStudent.TabIndex = 6;
            this.rdoUserClassStudent.TabStop = true;
            this.rdoUserClassStudent.Text = "Student";
            this.rdoUserClassStudent.UseVisualStyleBackColor = true;
            this.rdoUserClassStudent.CheckedChanged += new System.EventHandler(this.rdoUserClassStudent_CheckedChanged);
            // 
            // lblUserDesignation
            // 
            this.lblUserDesignation.AutoSize = true;
            this.lblUserDesignation.Location = new System.Drawing.Point(593, 34);
            this.lblUserDesignation.Name = "lblUserDesignation";
            this.lblUserDesignation.Size = new System.Drawing.Size(101, 21);
            this.lblUserDesignation.TabIndex = 5;
            this.lblUserDesignation.Text = "Designation:";
            // 
            // txtUserDesignation
            // 
            this.txtUserDesignation.Location = new System.Drawing.Point(597, 58);
            this.txtUserDesignation.Name = "txtUserDesignation";
            this.txtUserDesignation.Size = new System.Drawing.Size(200, 29);
            this.txtUserDesignation.TabIndex = 4;
            // 
            // lblUserGroup
            // 
            this.lblUserGroup.AutoSize = true;
            this.lblUserGroup.Location = new System.Drawing.Point(371, 34);
            this.lblUserGroup.Name = "lblUserGroup";
            this.lblUserGroup.Size = new System.Drawing.Size(89, 21);
            this.lblUserGroup.TabIndex = 3;
            this.lblUserGroup.Text = "Org Name:";
            // 
            // txtUserGroup
            // 
            this.txtUserGroup.Location = new System.Drawing.Point(375, 58);
            this.txtUserGroup.Name = "txtUserGroup";
            this.txtUserGroup.Size = new System.Drawing.Size(200, 29);
            this.txtUserGroup.TabIndex = 2;
            // 
            // lblUserClassification
            // 
            this.lblUserClassification.AutoSize = true;
            this.lblUserClassification.Location = new System.Drawing.Point(147, 36);
            this.lblUserClassification.Name = "lblUserClassification";
            this.lblUserClassification.Size = new System.Drawing.Size(92, 21);
            this.lblUserClassification.TabIndex = 1;
            this.lblUserClassification.Text = "Student ID:";
            // 
            // txtUserClassification
            // 
            this.txtUserClassification.Location = new System.Drawing.Point(151, 58);
            this.txtUserClassification.Name = "txtUserClassification";
            this.txtUserClassification.Size = new System.Drawing.Size(200, 29);
            this.txtUserClassification.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(14, 634);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 35);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "<< LOG-IN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlLegalName
            // 
            this.pnlLegalName.Controls.Add(this.lblMiddleName);
            this.pnlLegalName.Controls.Add(this.txtMiddleName);
            this.pnlLegalName.Controls.Add(this.lblFirstName);
            this.pnlLegalName.Controls.Add(this.txtFirstName);
            this.pnlLegalName.Controls.Add(this.lblLastName);
            this.pnlLegalName.Controls.Add(this.txtLastName);
            this.pnlLegalName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLegalName.Location = new System.Drawing.Point(37, 135);
            this.pnlLegalName.Name = "pnlLegalName";
            this.pnlLegalName.Size = new System.Drawing.Size(900, 100);
            this.pnlLegalName.TabIndex = 1;
            this.pnlLegalName.TabStop = false;
            this.pnlLegalName.Text = "Full Name Details";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(593, 34);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(113, 21);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(597, 58);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(200, 29);
            this.txtMiddleName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(371, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 21);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(375, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 29);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(147, 34);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 21);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 29);
            this.txtLastName.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.imgUMAKLogo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(91, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(438, 45);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "UFMO Account Registration";
            // 
            // imgUMAKLogo
            // 
            this.imgUMAKLogo.Image = global::LikhayaVenueReservation.Properties.Resources.logoumaksmall;
            this.imgUMAKLogo.Location = new System.Drawing.Point(0, 0);
            this.imgUMAKLogo.Name = "imgUMAKLogo";
            this.imgUMAKLogo.Size = new System.Drawing.Size(85, 75);
            this.imgUMAKLogo.TabIndex = 0;
            this.imgUMAKLogo.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LikhayaVenueReservation.Properties.Resources.OOP_HOMESCREEN;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMAK Venue Reservation";
            this.pnlRegistration.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUserGroupDetails.ResumeLayout(false);
            this.pnlUserGroupDetails.PerformLayout();
            this.pnlLegalName.ResumeLayout(false);
            this.pnlLegalName.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUMAKLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox imgUMAKLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox pnlLegalName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox pnlUserGroupDetails;
        private System.Windows.Forms.RadioButton rdoUserClassStudent;
        private System.Windows.Forms.Label lblUserDesignation;
        private System.Windows.Forms.TextBox txtUserDesignation;
        private System.Windows.Forms.Label lblUserGroup;
        private System.Windows.Forms.TextBox txtUserGroup;
        private System.Windows.Forms.Label lblUserClassification;
        private System.Windows.Forms.TextBox txtUserClassification;
        private System.Windows.Forms.RadioButton rdoUserClassOutsider;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox pnlPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClear;
    }
}