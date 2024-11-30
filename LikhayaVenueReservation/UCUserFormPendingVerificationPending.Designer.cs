namespace LikhayaVenueReservation
{
    partial class UCUserFormPendingVerificationPending
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPendingHeader = new System.Windows.Forms.Label();
            this.lblPendingDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(263, 400);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPendingHeader
            // 
            this.lblPendingHeader.AutoSize = true;
            this.lblPendingHeader.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingHeader.Location = new System.Drawing.Point(50, 57);
            this.lblPendingHeader.Name = "lblPendingHeader";
            this.lblPendingHeader.Size = new System.Drawing.Size(550, 47);
            this.lblPendingHeader.TabIndex = 2;
            this.lblPendingHeader.Text = "ACCOUNT PENDING APPROVAL";
            // 
            // lblPendingDesc
            // 
            this.lblPendingDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingDesc.Location = new System.Drawing.Point(50, 230);
            this.lblPendingDesc.Name = "lblPendingDesc";
            this.lblPendingDesc.Size = new System.Drawing.Size(550, 138);
            this.lblPendingDesc.TabIndex = 3;
            this.lblPendingDesc.Text = "Your account is waiting to be approved by an administrator. Your account needs ve" +
    "rification in order to reserve a venue. Please come back once your account has b" +
    "een accepted.";
            this.lblPendingDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCUserFormPendingVerificationPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPendingDesc);
            this.Controls.Add(this.lblPendingHeader);
            this.Controls.Add(this.btnLogout);
            this.Name = "UCUserFormPendingVerificationPending";
            this.Size = new System.Drawing.Size(650, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPendingHeader;
        private System.Windows.Forms.Label lblPendingDesc;
    }
}
