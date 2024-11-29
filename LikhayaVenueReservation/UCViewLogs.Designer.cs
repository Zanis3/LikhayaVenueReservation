namespace LikhayaVenueReservation
{
    partial class UCViewLogs
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
            this.components = new System.ComponentModel.Container();
            this.likhayaVenueReservationDataSet = new LikhayaVenueReservation.LikhayaVenueReservationDataSet();
            this.likhayaVenueReservationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblViewLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.likhayaVenueReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likhayaVenueReservationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // likhayaVenueReservationDataSet
            // 
            this.likhayaVenueReservationDataSet.DataSetName = "LikhayaVenueReservationDataSet";
            this.likhayaVenueReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // likhayaVenueReservationDataSetBindingSource
            // 
            this.likhayaVenueReservationDataSetBindingSource.DataSource = this.likhayaVenueReservationDataSet;
            this.likhayaVenueReservationDataSetBindingSource.Position = 0;
            // 
            // tblViewLogs
            // 
            this.tblViewLogs.AllowUserToAddRows = false;
            this.tblViewLogs.AllowUserToDeleteRows = false;
            this.tblViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewLogs.Location = new System.Drawing.Point(37, 33);
            this.tblViewLogs.Name = "tblViewLogs";
            this.tblViewLogs.Size = new System.Drawing.Size(850, 550);
            this.tblViewLogs.TabIndex = 0;
            // 
            // UCViewLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblViewLogs);
            this.Name = "UCViewLogs";
            this.Size = new System.Drawing.Size(920, 610);
            ((System.ComponentModel.ISupportInitialize)(this.likhayaVenueReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likhayaVenueReservationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LikhayaVenueReservationDataSet likhayaVenueReservationDataSet;
        private System.Windows.Forms.BindingSource likhayaVenueReservationDataSetBindingSource;
        private System.Windows.Forms.DataGridView tblViewLogs;
    }
}
