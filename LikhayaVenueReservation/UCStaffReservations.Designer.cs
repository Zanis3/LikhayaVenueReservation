namespace LikhayaVenueReservation
{
    partial class UCStaffReservations
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
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.tblViewReservations = new System.Windows.Forms.DataGridView();
            this.lblReservations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(590, 535);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(150, 40);
            this.btnClearSearch.TabIndex = 16;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(434, 535);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReservation.Location = new System.Drawing.Point(203, 540);
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(225, 35);
            this.txtSearchReservation.TabIndex = 14;
            // 
            // tblViewReservations
            // 
            this.tblViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewReservations.Location = new System.Drawing.Point(85, 110);
            this.tblViewReservations.Name = "tblViewReservations";
            this.tblViewReservations.Size = new System.Drawing.Size(750, 400);
            this.tblViewReservations.TabIndex = 13;
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservations.Location = new System.Drawing.Point(357, 38);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(210, 45);
            this.lblReservations.TabIndex = 12;
            this.lblReservations.Text = "Reservations";
            // 
            // UCStaffReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchReservation);
            this.Controls.Add(this.tblViewReservations);
            this.Controls.Add(this.lblReservations);
            this.Name = "UCStaffReservations";
            this.Size = new System.Drawing.Size(920, 610);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.DataGridView tblViewReservations;
        private System.Windows.Forms.Label lblReservations;
    }
}
