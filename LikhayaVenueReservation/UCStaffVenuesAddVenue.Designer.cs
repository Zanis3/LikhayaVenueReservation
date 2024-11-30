namespace LikhayaVenueReservation
{
    partial class UCStaffVenuesAddVenue
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
            this.lblAddVenue = new System.Windows.Forms.Label();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblVenueLocation = new System.Windows.Forms.Label();
            this.cboVenueLocation = new System.Windows.Forms.ComboBox();
            this.lblVenueDescription = new System.Windows.Forms.Label();
            this.txtVenueDescription = new System.Windows.Forms.TextBox();
            this.btnAddVenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddVenue
            // 
            this.lblAddVenue.AutoSize = true;
            this.lblAddVenue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVenue.Location = new System.Drawing.Point(344, 38);
            this.lblAddVenue.Name = "lblAddVenue";
            this.lblAddVenue.Size = new System.Drawing.Size(203, 45);
            this.lblAddVenue.TabIndex = 0;
            this.lblAddVenue.Text = "ADD VENUE";
            // 
            // txtVenueName
            // 
            this.txtVenueName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueName.Location = new System.Drawing.Point(58, 163);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(750, 43);
            this.txtVenueName.TabIndex = 1;
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueName.Location = new System.Drawing.Point(51, 123);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(185, 37);
            this.lblVenueName.TabIndex = 2;
            this.lblVenueName.Text = "Venue Name:";
            // 
            // lblVenueLocation
            // 
            this.lblVenueLocation.AutoSize = true;
            this.lblVenueLocation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueLocation.Location = new System.Drawing.Point(51, 229);
            this.lblVenueLocation.Name = "lblVenueLocation";
            this.lblVenueLocation.Size = new System.Drawing.Size(220, 37);
            this.lblVenueLocation.TabIndex = 4;
            this.lblVenueLocation.Text = "Venue Location:";
            // 
            // cboVenueLocation
            // 
            this.cboVenueLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenueLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.cboVenueLocation.FormattingEnabled = true;
            this.cboVenueLocation.Items.AddRange(new object[] {
            "Admin Building",
            "Building 1",
            "Building 2",
            "Building 3",
            "HPSB Building"});
            this.cboVenueLocation.Location = new System.Drawing.Point(58, 278);
            this.cboVenueLocation.Name = "cboVenueLocation";
            this.cboVenueLocation.Size = new System.Drawing.Size(750, 45);
            this.cboVenueLocation.TabIndex = 5;
            // 
            // lblVenueDescription
            // 
            this.lblVenueDescription.AutoSize = true;
            this.lblVenueDescription.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueDescription.Location = new System.Drawing.Point(51, 345);
            this.lblVenueDescription.Name = "lblVenueDescription";
            this.lblVenueDescription.Size = new System.Drawing.Size(257, 37);
            this.lblVenueDescription.TabIndex = 7;
            this.lblVenueDescription.Text = "Venue Description:";
            // 
            // txtVenueDescription
            // 
            this.txtVenueDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueDescription.Location = new System.Drawing.Point(58, 385);
            this.txtVenueDescription.Multiline = true;
            this.txtVenueDescription.Name = "txtVenueDescription";
            this.txtVenueDescription.Size = new System.Drawing.Size(750, 86);
            this.txtVenueDescription.TabIndex = 6;
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVenue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVenue.ForeColor = System.Drawing.Color.White;
            this.btnAddVenue.Location = new System.Drawing.Point(363, 491);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(150, 40);
            this.btnAddVenue.TabIndex = 8;
            this.btnAddVenue.Text = "Add Venue";
            this.btnAddVenue.UseVisualStyleBackColor = false;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // UCStaffVenuesAddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddVenue);
            this.Controls.Add(this.lblVenueDescription);
            this.Controls.Add(this.txtVenueDescription);
            this.Controls.Add(this.cboVenueLocation);
            this.Controls.Add(this.lblVenueLocation);
            this.Controls.Add(this.lblVenueName);
            this.Controls.Add(this.txtVenueName);
            this.Controls.Add(this.lblAddVenue);
            this.Name = "UCStaffVenuesAddVenue";
            this.Size = new System.Drawing.Size(900, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddVenue;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblVenueLocation;
        private System.Windows.Forms.ComboBox cboVenueLocation;
        private System.Windows.Forms.Label lblVenueDescription;
        private System.Windows.Forms.TextBox txtVenueDescription;
        private System.Windows.Forms.Button btnAddVenue;
    }
}
