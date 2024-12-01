namespace LikhayaVenueReservation
{
    partial class UCUserAddReservation
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
            this.cboVenues = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSelectVenue = new System.Windows.Forms.Label();
            this.cboReservationDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.cboReservationStartTime = new System.Windows.Forms.ComboBox();
            this.cboReservationEndTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboVenues
            // 
            this.cboVenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenues.FormattingEnabled = true;
            this.cboVenues.Location = new System.Drawing.Point(265, 133);
            this.cboVenues.Name = "cboVenues";
            this.cboVenues.Size = new System.Drawing.Size(550, 38);
            this.cboVenues.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(325, 63);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(230, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Add Reservation";
            // 
            // lblSelectVenue
            // 
            this.lblSelectVenue.AutoSize = true;
            this.lblSelectVenue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVenue.Location = new System.Drawing.Point(73, 134);
            this.lblSelectVenue.Name = "lblSelectVenue";
            this.lblSelectVenue.Size = new System.Drawing.Size(186, 37);
            this.lblSelectVenue.TabIndex = 2;
            this.lblSelectVenue.Text = "Select Venue:";
            // 
            // cboReservationDate
            // 
            this.cboReservationDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cboReservationDate.Location = new System.Drawing.Point(375, 206);
            this.cboReservationDate.Name = "cboReservationDate";
            this.cboReservationDate.Size = new System.Drawing.Size(300, 35);
            this.cboReservationDate.TabIndex = 3;
            this.cboReservationDate.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(200, 204);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(169, 37);
            this.lblSelectDate.TabIndex = 4;
            this.lblSelectDate.Text = "Select Date:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(200, 275);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(158, 37);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(216, 342);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(142, 37);
            this.lblEndTime.TabIndex = 10;
            this.lblEndTime.Text = "End Time:";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(305, 439);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(250, 40);
            this.btnAddReservation.TabIndex = 11;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // cboReservationStartTime
            // 
            this.cboReservationStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationStartTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationStartTime.FormattingEnabled = true;
            this.cboReservationStartTime.Location = new System.Drawing.Point(375, 275);
            this.cboReservationStartTime.Name = "cboReservationStartTime";
            this.cboReservationStartTime.Size = new System.Drawing.Size(300, 38);
            this.cboReservationStartTime.TabIndex = 12;
            // 
            // cboReservationEndTime
            // 
            this.cboReservationEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationEndTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationEndTime.FormattingEnabled = true;
            this.cboReservationEndTime.Location = new System.Drawing.Point(375, 345);
            this.cboReservationEndTime.Name = "cboReservationEndTime";
            this.cboReservationEndTime.Size = new System.Drawing.Size(300, 38);
            this.cboReservationEndTime.TabIndex = 13;
            // 
            // UCUserAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboReservationEndTime);
            this.Controls.Add(this.cboReservationStartTime);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.cboReservationDate);
            this.Controls.Add(this.lblSelectVenue);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cboVenues);
            this.Name = "UCUserAddReservation";
            this.Size = new System.Drawing.Size(900, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVenues;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSelectVenue;
        private System.Windows.Forms.DateTimePicker cboReservationDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.ComboBox cboReservationStartTime;
        private System.Windows.Forms.ComboBox cboReservationEndTime;
    }
}
