namespace LikhayaVenueReservation
{
    partial class UCUserReservationReadUpdateDelete
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.lblReservationStatusData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboReservationEndTime
            // 
            this.cboReservationEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationEndTime.Enabled = false;
            this.cboReservationEndTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationEndTime.FormattingEnabled = true;
            this.cboReservationEndTime.Location = new System.Drawing.Point(208, 274);
            this.cboReservationEndTime.Name = "cboReservationEndTime";
            this.cboReservationEndTime.Size = new System.Drawing.Size(300, 38);
            this.cboReservationEndTime.TabIndex = 23;
            // 
            // cboReservationStartTime
            // 
            this.cboReservationStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationStartTime.Enabled = false;
            this.cboReservationStartTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationStartTime.FormattingEnabled = true;
            this.cboReservationStartTime.Location = new System.Drawing.Point(208, 224);
            this.cboReservationStartTime.Name = "cboReservationStartTime";
            this.cboReservationStartTime.Size = new System.Drawing.Size(300, 38);
            this.cboReservationStartTime.TabIndex = 22;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.Location = new System.Drawing.Point(173, 414);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(250, 40);
            this.btnCancelReservation.TabIndex = 21;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(60, 272);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(142, 37);
            this.lblEndTime.TabIndex = 20;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(44, 225);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(158, 37);
            this.lblStartTime.TabIndex = 19;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(117, 173);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(85, 37);
            this.lblSelectDate.TabIndex = 18;
            this.lblSelectDate.Text = "Date:";
            // 
            // cboReservationDate
            // 
            this.cboReservationDate.Enabled = false;
            this.cboReservationDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cboReservationDate.Location = new System.Drawing.Point(208, 175);
            this.cboReservationDate.Name = "cboReservationDate";
            this.cboReservationDate.Size = new System.Drawing.Size(300, 35);
            this.cboReservationDate.TabIndex = 17;
            this.cboReservationDate.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            // 
            // lblSelectVenue
            // 
            this.lblSelectVenue.AutoSize = true;
            this.lblSelectVenue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVenue.Location = new System.Drawing.Point(93, 116);
            this.lblSelectVenue.Name = "lblSelectVenue";
            this.lblSelectVenue.Size = new System.Drawing.Size(109, 37);
            this.lblSelectVenue.TabIndex = 16;
            this.lblSelectVenue.Text = " Venue:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(318, 41);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(266, 37);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "Reservation Details";
            // 
            // cboVenues
            // 
            this.cboVenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenues.Enabled = false;
            this.cboVenues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenues.FormattingEnabled = true;
            this.cboVenues.Location = new System.Drawing.Point(208, 119);
            this.cboVenues.Name = "cboVenues";
            this.cboVenues.Size = new System.Drawing.Size(550, 38);
            this.cboVenues.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(462, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 40);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatus.Location = new System.Drawing.Point(60, 341);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(263, 37);
            this.lblReservationStatus.TabIndex = 29;
            this.lblReservationStatus.Text = "Reservation Status:";
            // 
            // lblReservationStatusData
            // 
            this.lblReservationStatusData.AutoSize = true;
            this.lblReservationStatusData.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatusData.Location = new System.Drawing.Point(409, 341);
            this.lblReservationStatusData.Name = "lblReservationStatusData";
            this.lblReservationStatusData.Size = new System.Drawing.Size(263, 37);
            this.lblReservationStatusData.TabIndex = 30;
            this.lblReservationStatusData.Text = "Reservation Status:";
            // 
            // UCUserReservationReadUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UCUserReservationReadUpdateDelete";
            this.Size = new System.Drawing.Size(900, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Label lblReservationStatusData;
    }
}
