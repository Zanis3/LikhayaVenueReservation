namespace LikhayaVenueReservation
{
    partial class UserFormPendingVerification
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
            this.pnlAccountStatus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAccountStatus
            // 
            this.pnlAccountStatus.Location = new System.Drawing.Point(315, 100);
            this.pnlAccountStatus.Name = "pnlAccountStatus";
            this.pnlAccountStatus.Size = new System.Drawing.Size(650, 500);
            this.pnlAccountStatus.TabIndex = 0;
            // 
            // UserFormPendingVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LikhayaVenueReservation.Properties.Resources.OOP_HOMESCREEN;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlAccountStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserFormPendingVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMAK Venue Reservation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccountStatus;
    }
}