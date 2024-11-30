namespace LikhayaVenueReservation
{
    partial class UCUserFormPendingVerificationRejected
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
            this.lblRejectedHeader = new System.Windows.Forms.Label();
            this.lblRejectedDesc = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label1lblRejectedDescTwo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRejectedHeader
            // 
            this.lblRejectedHeader.AutoSize = true;
            this.lblRejectedHeader.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedHeader.Location = new System.Drawing.Point(128, 53);
            this.lblRejectedHeader.Name = "lblRejectedHeader";
            this.lblRejectedHeader.Size = new System.Drawing.Size(364, 47);
            this.lblRejectedHeader.TabIndex = 3;
            this.lblRejectedHeader.Text = "ACCOUNT REJECTED";
            // 
            // lblRejectedDesc
            // 
            this.lblRejectedDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedDesc.Location = new System.Drawing.Point(48, 124);
            this.lblRejectedDesc.Name = "lblRejectedDesc";
            this.lblRejectedDesc.Size = new System.Drawing.Size(461, 40);
            this.lblRejectedDesc.TabIndex = 4;
            this.lblRejectedDesc.Text = "Your account has been rejected due to the following reason:";
            this.lblRejectedDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReason
            // 
            this.txtReason.Enabled = false;
            this.txtReason.Location = new System.Drawing.Point(52, 167);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(500, 200);
            this.txtReason.TabIndex = 5;
            // 
            // label1lblRejectedDescTwo
            // 
            this.label1lblRejectedDescTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblRejectedDescTwo.Location = new System.Drawing.Point(48, 370);
            this.label1lblRejectedDescTwo.Name = "label1lblRejectedDescTwo";
            this.label1lblRejectedDescTwo.Size = new System.Drawing.Size(421, 40);
            this.label1lblRejectedDescTwo.TabIndex = 6;
            this.label1lblRejectedDescTwo.Text = "You can re-register to apply for verification once more:";
            this.label1lblRejectedDescTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(427, 413);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReRegister
            // 
            this.btnReRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReRegister.ForeColor = System.Drawing.Color.White;
            this.btnReRegister.Location = new System.Drawing.Point(52, 413);
            this.btnReRegister.Name = "btnReRegister";
            this.btnReRegister.Size = new System.Drawing.Size(148, 40);
            this.btnReRegister.TabIndex = 8;
            this.btnReRegister.Text = "RE-REGISTER";
            this.btnReRegister.UseVisualStyleBackColor = false;
            this.btnReRegister.Click += new System.EventHandler(this.btnReRegister_Click);
            // 
            // UCUserFormPendingVerificationRejected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReRegister);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1lblRejectedDescTwo);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblRejectedDesc);
            this.Controls.Add(this.lblRejectedHeader);
            this.Name = "UCUserFormPendingVerificationRejected";
            this.Size = new System.Drawing.Size(650, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRejectedHeader;
        private System.Windows.Forms.Label lblRejectedDesc;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label1lblRejectedDescTwo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReRegister;
    }
}
