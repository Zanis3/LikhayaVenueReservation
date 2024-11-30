namespace LikhayaVenueReservation
{
    partial class UCStaffVenuesReadUpdateDeleteVenue
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
            this.lblVenueDescription = new System.Windows.Forms.Label();
            this.txtVenueDescription = new System.Windows.Forms.TextBox();
            this.cboVenueLocation = new System.Windows.Forms.ComboBox();
            this.lblVenueLocation = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.btnUpdateVenue = new System.Windows.Forms.Button();
            this.btnDeleteVenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVenueDescription
            // 
            this.lblVenueDescription.AutoSize = true;
            this.lblVenueDescription.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueDescription.Location = new System.Drawing.Point(62, 284);
            this.lblVenueDescription.Name = "lblVenueDescription";
            this.lblVenueDescription.Size = new System.Drawing.Size(257, 37);
            this.lblVenueDescription.TabIndex = 14;
            this.lblVenueDescription.Text = "Venue Description:";
            // 
            // txtVenueDescription
            // 
            this.txtVenueDescription.Enabled = false;
            this.txtVenueDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueDescription.Location = new System.Drawing.Point(69, 324);
            this.txtVenueDescription.Multiline = true;
            this.txtVenueDescription.Name = "txtVenueDescription";
            this.txtVenueDescription.Size = new System.Drawing.Size(750, 86);
            this.txtVenueDescription.TabIndex = 13;
            // 
            // cboVenueLocation
            // 
            this.cboVenueLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenueLocation.Enabled = false;
            this.cboVenueLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.cboVenueLocation.FormattingEnabled = true;
            this.cboVenueLocation.Items.AddRange(new object[] {
            "Admin Building",
            "Building 1",
            "Building 2",
            "Building 3",
            "HPSB Building"});
            this.cboVenueLocation.Location = new System.Drawing.Point(69, 217);
            this.cboVenueLocation.Name = "cboVenueLocation";
            this.cboVenueLocation.Size = new System.Drawing.Size(750, 45);
            this.cboVenueLocation.TabIndex = 12;
            // 
            // lblVenueLocation
            // 
            this.lblVenueLocation.AutoSize = true;
            this.lblVenueLocation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueLocation.Location = new System.Drawing.Point(62, 168);
            this.lblVenueLocation.Name = "lblVenueLocation";
            this.lblVenueLocation.Size = new System.Drawing.Size(220, 37);
            this.lblVenueLocation.TabIndex = 11;
            this.lblVenueLocation.Text = "Venue Location:";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueName.Location = new System.Drawing.Point(62, 62);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(185, 37);
            this.lblVenueName.TabIndex = 10;
            this.lblVenueName.Text = "Venue Name:";
            // 
            // txtVenueName
            // 
            this.txtVenueName.Enabled = false;
            this.txtVenueName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueName.Location = new System.Drawing.Point(69, 102);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(750, 43);
            this.txtVenueName.TabIndex = 9;
            // 
            // btnUpdateVenue
            // 
            this.btnUpdateVenue.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVenue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVenue.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVenue.Location = new System.Drawing.Point(223, 457);
            this.btnUpdateVenue.Name = "btnUpdateVenue";
            this.btnUpdateVenue.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateVenue.TabIndex = 15;
            this.btnUpdateVenue.Text = "Update Venue";
            this.btnUpdateVenue.UseVisualStyleBackColor = false;
            this.btnUpdateVenue.Click += new System.EventHandler(this.btnUpdateVenue_Click);
            // 
            // btnDeleteVenue
            // 
            this.btnDeleteVenue.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVenue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVenue.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVenue.Location = new System.Drawing.Point(449, 457);
            this.btnDeleteVenue.Name = "btnDeleteVenue";
            this.btnDeleteVenue.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteVenue.TabIndex = 16;
            this.btnDeleteVenue.Text = "Delete Venue";
            this.btnDeleteVenue.UseVisualStyleBackColor = false;
            this.btnDeleteVenue.Click += new System.EventHandler(this.btnDeleteVenue_Click);
            // 
            // UCStaffVenuesReadUpdateDeleteVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteVenue);
            this.Controls.Add(this.btnUpdateVenue);
            this.Controls.Add(this.lblVenueDescription);
            this.Controls.Add(this.txtVenueDescription);
            this.Controls.Add(this.cboVenueLocation);
            this.Controls.Add(this.lblVenueLocation);
            this.Controls.Add(this.lblVenueName);
            this.Controls.Add(this.txtVenueName);
            this.Name = "UCStaffVenuesReadUpdateDeleteVenue";
            this.Size = new System.Drawing.Size(900, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenueDescription;
        private System.Windows.Forms.TextBox txtVenueDescription;
        private System.Windows.Forms.ComboBox cboVenueLocation;
        private System.Windows.Forms.Label lblVenueLocation;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.Button btnUpdateVenue;
        private System.Windows.Forms.Button btnDeleteVenue;
    }
}
