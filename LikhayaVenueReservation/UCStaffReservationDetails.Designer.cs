namespace LikhayaVenueReservation
{
    partial class UCStaffReservationDetails
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
            this.lblReservationStatusData = new System.Windows.Forms.Label();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboReservationEndTime = new System.Windows.Forms.ComboBox();
            this.cboReservationStartTime = new System.Windows.Forms.ComboBox();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.cboReservationDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectVenue = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboVenues = new System.Windows.Forms.ComboBox();
            this.lblUserNameDetails = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReservationStatusData
            // 
            this.lblReservationStatusData.AutoSize = true;
            this.lblReservationStatusData.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatusData.Location = new System.Drawing.Point(434, 411);
            this.lblReservationStatusData.Name = "lblReservationStatusData";
            this.lblReservationStatusData.Size = new System.Drawing.Size(263, 37);
            this.lblReservationStatusData.TabIndex = 43;
            this.lblReservationStatusData.Text = "Reservation Status:";
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatus.Location = new System.Drawing.Point(85, 411);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(263, 37);
            this.lblReservationStatus.TabIndex = 42;
            this.lblReservationStatus.Text = "Reservation Status:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(487, 484);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 40);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboReservationEndTime
            // 
            this.cboReservationEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationEndTime.Enabled = false;
            this.cboReservationEndTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationEndTime.FormattingEnabled = true;
            this.cboReservationEndTime.Location = new System.Drawing.Point(234, 326);
            this.cboReservationEndTime.Name = "cboReservationEndTime";
            this.cboReservationEndTime.Size = new System.Drawing.Size(300, 38);
            this.cboReservationEndTime.TabIndex = 40;
            // 
            // cboReservationStartTime
            // 
            this.cboReservationStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationStartTime.Enabled = false;
            this.cboReservationStartTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationStartTime.FormattingEnabled = true;
            this.cboReservationStartTime.Location = new System.Drawing.Point(234, 276);
            this.cboReservationStartTime.Name = "cboReservationStartTime";
            this.cboReservationStartTime.Size = new System.Drawing.Size(300, 38);
            this.cboReservationStartTime.TabIndex = 39;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.Location = new System.Drawing.Point(198, 484);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(250, 40);
            this.btnCancelReservation.TabIndex = 38;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(86, 324);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(142, 37);
            this.lblEndTime.TabIndex = 37;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(70, 277);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(158, 37);
            this.lblStartTime.TabIndex = 36;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(143, 225);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(85, 37);
            this.lblSelectDate.TabIndex = 35;
            this.lblSelectDate.Text = "Date:";
            // 
            // cboReservationDate
            // 
            this.cboReservationDate.Enabled = false;
            this.cboReservationDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cboReservationDate.Location = new System.Drawing.Point(234, 227);
            this.cboReservationDate.Name = "cboReservationDate";
            this.cboReservationDate.Size = new System.Drawing.Size(300, 35);
            this.cboReservationDate.TabIndex = 34;
            this.cboReservationDate.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            // 
            // lblSelectVenue
            // 
            this.lblSelectVenue.AutoSize = true;
            this.lblSelectVenue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVenue.Location = new System.Drawing.Point(119, 168);
            this.lblSelectVenue.Name = "lblSelectVenue";
            this.lblSelectVenue.Size = new System.Drawing.Size(109, 37);
            this.lblSelectVenue.TabIndex = 33;
            this.lblSelectVenue.Text = " Venue:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(322, 54);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(266, 37);
            this.lblHeader.TabIndex = 32;
            this.lblHeader.Text = "Reservation Details";
            // 
            // cboVenues
            // 
            this.cboVenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenues.Enabled = false;
            this.cboVenues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenues.FormattingEnabled = true;
            this.cboVenues.Location = new System.Drawing.Point(234, 171);
            this.cboVenues.Name = "cboVenues";
            this.cboVenues.Size = new System.Drawing.Size(550, 38);
            this.cboVenues.TabIndex = 31;
            // 
            // lblUserNameDetails
            // 
            this.lblUserNameDetails.AutoSize = true;
            this.lblUserNameDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameDetails.Location = new System.Drawing.Point(434, 108);
            this.lblUserNameDetails.Name = "lblUserNameDetails";
            this.lblUserNameDetails.Size = new System.Drawing.Size(263, 37);
            this.lblUserNameDetails.TabIndex = 45;
            this.lblUserNameDetails.Text = "Reservation Status:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(85, 108);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(165, 37);
            this.lblUserName.TabIndex = 44;
            this.lblUserName.Text = "User Name:";
            // 
            // UCStaffReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 571);
            this.Controls.Add(this.lblUserNameDetails);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblReservationStatusData);
            this.Controls.Add(this.lblReservationStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboReservationEndTime);
            this.Controls.Add(this.cboReservationStartTime);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.cboReservationDate);
            this.Controls.Add(this.lblSelectVenue);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cboVenues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UCStaffReservationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMAK Venue Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservationStatusData;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboReservationEndTime;
        private System.Windows.Forms.ComboBox cboReservationStartTime;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker cboReservationDate;
        private System.Windows.Forms.Label lblSelectVenue;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cboVenues;
        private System.Windows.Forms.Label lblUserNameDetails;
        private System.Windows.Forms.Label lblUserName;
    }
}