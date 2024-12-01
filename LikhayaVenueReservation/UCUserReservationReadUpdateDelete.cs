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
    public partial class UCUserReservationReadUpdateDelete : UserControl
    {
        private string reservationID = "";
        private string reservationStatus = "";
        DateTime reservationDate = DateTime.Today;
        public UCUserReservationReadUpdateDelete()
        {
            InitializeComponent();
        }

        public UCUserReservationReadUpdateDelete(string id) : this()
        {
            reservationID = id;
            loadReservation(reservationID);
        }

        private void loadReservation(string id)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();

                SqlCommand loadReservation = new SqlCommand("SELECT r.ReservationDate, r.ReservationStartTime, r.ReservationEndTime, r.ReservationStatus, v.VenueID, v.VenueName FROM Reservation r INNER JOIN Venue v ON r.VenueID = v.VenueID WHERE r.ReservationID = @reservationid", conn);

                loadReservation.Parameters.AddWithValue("@reservationid", Convert.ToInt32(id));

                SqlDataReader reader = loadReservation.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cboVenues.Items.Add(reader["VenueName"].ToString());
                        cboVenues.Text = reader["VenueName"].ToString();

                        cboReservationDate.Value = Convert.ToDateTime(reader["ReservationDate"]);

                        reservationDate = Convert.ToDateTime(reader["ReservationDate"]);

                        cboReservationStartTime.Items.Add(reader["ReservationStartTime"].ToString());
                        cboReservationStartTime.Text = reader["ReservationStartTime"].ToString();

                        cboReservationEndTime.Items.Add(reader["ReservationEndTime"].ToString());
                        cboReservationEndTime.Text = reader["ReservationEndTime"].ToString();

                        reservationStatus = reader["ReservationStatus"].ToString();
                        lblReservationStatusData.Text = reservationStatus;
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No data found for the given VenueID.", "Error");
                }

                if(reservationStatus == "cancelled" && reservationStatus == "completed")
                {
                    btnCancelReservation.Enabled = false;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Now;
            TimeSpan difference = reservationDate - today;

            if (difference.TotalDays < 3 && difference.TotalDays >= 0)
            {
                Extra.showWarningMessage("Reservations cannot be cancelled three days before the planned date. Please contact a UFMO staff instead.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to caancel this reservation? This cannot be undone.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(Extra.connectionString);

                    try
                    {
                        conn.Open();

                        SqlCommand cancelReservation = new SqlCommand("UPDATE [Reservation] SET ReservationStatus = @status WHERE ReservationID = @id", conn);

                        cancelReservation.Parameters.AddWithValue("@status", "cancelled");
                        cancelReservation.Parameters.AddWithValue("@id", reservationID);

                        int execute = cancelReservation.ExecuteNonQuery();

                        if(execute == 1)
                        {
                            Extra.showSucessMessage("Reservation cancelled successfully.");
                            Extra.log($"{Session.sessionUserType} '{Session.sessionUsername}' has cancelled their reservation.");

                            btnCancelReservation.Enabled = false;
                            lblReservationStatusData.Text = "cancelled";
                        }
                        else
                        {
                            Extra.showWarningMessage("Something went wrong. Please try again.");
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
            }
        }
    }
}
