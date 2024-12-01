using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikhayaVenueReservation
{
    public partial class UCUserReservations : UserControl
    {
        private UCUserReservationSettings viewReservation;
        public UCUserReservations()
        {
            InitializeComponent();
            tblViewReservations.AutoGenerateColumns = true;
            loadReservationData("SELECT r.ReservationID, v.VenueName, v.VenueLocation, r.ReservationDate, r.ReservationStartTime, r.ReservationEndTime, r.ReservationCreationDate, r.ReservationStatus FROM Reservation r LEFT JOIN Venue v ON r.VenueID = v.VenueID WHERE r.accountID = @accountid");
            tblViewReservations.CellClick += tblViewReservations_CellClick;
        }

        private void tblViewReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblViewReservations.Rows[e.RowIndex];
                string reservationID = selectedRow.Cells["ReservationID"].Value.ToString();

                if (viewReservation == null || viewReservation.IsDisposed)
                {
                    viewReservation = new UCUserReservationSettings("update", reservationID);
                }
                else
                {
                    viewReservation.Close();
                    viewReservation = new UCUserReservationSettings("update", reservationID);
                }

                viewReservation.ShowDialog();
                viewReservation.BringToFront();
                viewReservation.Focus();
            }
        }

        private void loadReservationData(string query, string searchValue = null)
        {
            tblViewReservations.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            string searchQuery = txtSearchReservation.Text;

            try
            {
                conn.Open();
                SqlCommand viewAllReservations = new SqlCommand(query, conn);

                viewAllReservations.Parameters.AddWithValue("@accountid", Session.sessionUserID);
                viewAllReservations.Parameters.AddWithValue("@searchvalue", searchQuery);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewAllReservations);
                DataTable venueData = new DataTable();
                dataAdapter.Fill(venueData);

                if (venueData.Rows.Count > 0)
                {
                    tblViewReservations.DataSource = venueData;
                }
                else
                {
                    Extra.showNoticeMessage("No data found.");
                }
            }
            catch (Exception ex)
            {
                Extra.showException(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = @"SELECT r.ReservationID, v.VenueName, v.VenueLocation, r.ReservationDate, r.ReservationStartTime, r.ReservationEndTime, r.ReservationCreationDate, r.ReservationStatus FROM Reservation r LEFT JOIN Venue v ON r.VenueID = v.VenueID WHERE r.accountID = @accountid AND (v.VenueName = @searchvalue OR v.VenueLocation LIKE @searchValue OR r.ReservationStatus LIKE @searchvalue)";

            string searchValue = txtSearchReservation.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                searchValue = "%";
            }
            else
            {
                searchValue = "%" + searchValue + "%";
            }

            loadReservationData(query, searchValue);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            loadReservationData("SELECT r.ReservationID, v.VenueName, v.VenueLocation, r.ReservationDate, r.ReservationStartTime, r.ReservationEndTime, r.ReservationCreationDate, r.ReservationStatus FROM Reservation r LEFT JOIN Venue v ON r.VenueID = v.VenueID WHERE r.accountID = @accountid");
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            UCUserReservationSettings addReservation = new UCUserReservationSettings("add");
            addReservation.Show();
        }
    }
}
