namespace LikhayaVenueReservation
{
    partial class UCStaffVenues
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
            this.lblVenues = new System.Windows.Forms.Label();
            this.tblViewVenues = new System.Windows.Forms.DataGridView();
            this.btnAddVenue = new System.Windows.Forms.Button();
            this.txtSearchVenue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewVenues)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVenues
            // 
            this.lblVenues.AutoSize = true;
            this.lblVenues.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenues.Location = new System.Drawing.Point(383, 41);
            this.lblVenues.Name = "lblVenues";
            this.lblVenues.Size = new System.Drawing.Size(125, 45);
            this.lblVenues.TabIndex = 0;
            this.lblVenues.Text = "Venues";
            // 
            // tblViewVenues
            // 
            this.tblViewVenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewVenues.Location = new System.Drawing.Point(75, 111);
            this.tblViewVenues.Name = "tblViewVenues";
            this.tblViewVenues.Size = new System.Drawing.Size(750, 400);
            this.tblViewVenues.TabIndex = 1;
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVenue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVenue.ForeColor = System.Drawing.Color.White;
            this.btnAddVenue.Location = new System.Drawing.Point(675, 534);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(150, 40);
            this.btnAddVenue.TabIndex = 2;
            this.btnAddVenue.Text = "Add Venue";
            this.btnAddVenue.UseVisualStyleBackColor = false;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // txtSearchVenue
            // 
            this.txtSearchVenue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVenue.Location = new System.Drawing.Point(75, 539);
            this.txtSearchVenue.Name = "txtSearchVenue";
            this.txtSearchVenue.Size = new System.Drawing.Size(225, 35);
            this.txtSearchVenue.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(306, 534);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search Venue";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(482, 534);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(150, 40);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // UCStaffVenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchVenue);
            this.Controls.Add(this.btnAddVenue);
            this.Controls.Add(this.tblViewVenues);
            this.Controls.Add(this.lblVenues);
            this.Name = "UCStaffVenues";
            this.Size = new System.Drawing.Size(920, 610);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewVenues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenues;
        private System.Windows.Forms.DataGridView tblViewVenues;
        private System.Windows.Forms.Button btnAddVenue;
        private System.Windows.Forms.TextBox txtSearchVenue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
    }
}
