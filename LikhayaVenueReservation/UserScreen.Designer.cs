namespace LikhayaVenueReservation
{
    partial class UserScreen
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
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnProfileButton = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.imgUMAKLogo = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUMAKLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.DarkMagenta;
            this.pnlNavigation.Controls.Add(this.btnLogout);
            this.pnlNavigation.Controls.Add(this.btnReservations);
            this.pnlNavigation.Location = new System.Drawing.Point(-3, 73);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(350, 610);
            this.pnlNavigation.TabIndex = 4;
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(0, 184);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(350, 100);
            this.btnReservations.TabIndex = 1;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Orchid;
            this.pnlHeader.Controls.Add(this.btnProfileButton);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.imgUMAKLogo);
            this.pnlHeader.Location = new System.Drawing.Point(-3, -2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1270, 75);
            this.pnlHeader.TabIndex = 3;
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
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(350, 75);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(920, 610);
            this.pnlContainer.TabIndex = 5;
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMAK Venue Reservation";
            this.pnlNavigation.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUMAKLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnProfileButton;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox imgUMAKLogo;
        private System.Windows.Forms.Panel pnlContainer;
    }
}