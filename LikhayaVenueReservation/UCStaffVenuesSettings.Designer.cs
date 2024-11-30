namespace LikhayaVenueReservation
{
    partial class UCStaffVenuesSettings
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
            this.pnlVenueContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlVenueContainer
            // 
            this.pnlVenueContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlVenueContainer.Name = "pnlVenueContainer";
            this.pnlVenueContainer.Size = new System.Drawing.Size(900, 570);
            this.pnlVenueContainer.TabIndex = 0;
            // 
            // UCStaffVenuesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 571);
            this.Controls.Add(this.pnlVenueContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UCStaffVenuesSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMAK Venue Reservation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVenueContainer;
    }
}