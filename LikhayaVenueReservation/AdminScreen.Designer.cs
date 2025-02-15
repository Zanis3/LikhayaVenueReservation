﻿namespace LikhayaVenueReservation
{
    partial class AdminScreen
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnProfileButton = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.imgUMAKLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUMAKLogo)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.btnProfileButton);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.imgUMAKLogo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1270, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnProfileButton
            // 
            this.btnProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.btnProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileButton.Image = global::LikhayaVenueReservation.Properties.Resources.profilebutton;
            this.btnProfileButton.Location = new System.Drawing.Point(1140, 0);
            this.btnProfileButton.Name = "btnProfileButton";
            this.btnProfileButton.Size = new System.Drawing.Size(75, 75);
            this.btnProfileButton.TabIndex = 3;
            this.btnProfileButton.UseVisualStyleBackColor = false;
            this.btnProfileButton.Click += new System.EventHandler(this.btnProfileButton_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(140, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 45);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "UFMO Venue Reservation";
            // 
            // imgUMAKLogo
            // 
            this.imgUMAKLogo.Image = global::LikhayaVenueReservation.Properties.Resources.logoumaksmall;
            this.imgUMAKLogo.Location = new System.Drawing.Point(50, 0);
            this.imgUMAKLogo.Name = "imgUMAKLogo";
            this.imgUMAKLogo.Size = new System.Drawing.Size(85, 75);
            this.imgUMAKLogo.TabIndex = 1;
            this.imgUMAKLogo.TabStop = false;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlNavigation.Controls.Add(this.btnLogout);
            this.pnlNavigation.Controls.Add(this.btnViewLogs);
            this.pnlNavigation.Controls.Add(this.btnViewAccount);
            this.pnlNavigation.Controls.Add(this.btnAddAccounts);
            this.pnlNavigation.Location = new System.Drawing.Point(0, 75);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(350, 610);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLogs.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.ForeColor = System.Drawing.Color.White;
            this.btnViewLogs.Location = new System.Drawing.Point(0, 290);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(350, 100);
            this.btnViewLogs.TabIndex = 2;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.UseVisualStyleBackColor = false;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAccount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccount.ForeColor = System.Drawing.Color.White;
            this.btnViewAccount.Location = new System.Drawing.Point(0, 170);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(350, 100);
            this.btnViewAccount.TabIndex = 1;
            this.btnViewAccount.Text = "View Accounts";
            this.btnViewAccount.UseVisualStyleBackColor = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccounts.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAddAccounts.Location = new System.Drawing.Point(0, 50);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(350, 100);
            this.btnAddAccounts.TabIndex = 0;
            this.btnAddAccounts.Text = "Add Staff/Admin";
            this.btnAddAccounts.UseVisualStyleBackColor = false;
            this.btnAddAccounts.Click += new System.EventHandler(this.btnAddAccounts_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(350, 75);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(920, 610);
            this.pnlContainer.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(93, 522);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMAK Venue Reservation";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUMAKLogo)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox imgUMAKLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnProfileButton;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnLogout;
    }
}