using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikhayaVenueReservation
{
    public partial class UCUserAddReservation : UserControl
    {
        private int venueid = 0;
        public UCUserAddReservation()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();

                SqlCommand loadVenues = new SqlCommand("SELECT * FROM [Venue]", conn);

                SqlDataReader reader = loadVenues.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cboVenues.Items.Add(reader["VenueName"].ToString());
                    }

                    reader.Close();
                }
                else
                {
                    Extra.showWarningMessage("Something went wrong. Please try again.");
                }
            }
            catch(Exception ex)
            {
                Extra.showException(ex);
            }
            finally
            {
                conn.Close();
            }

            //MINIMUM DATE
            cboReservationDate.CustomFormat = "MM/dd/yyyy";
            cboReservationDate.MinDate = DateTime.Now.AddDays(7);
            cboReservationDate.MaxDate = DateTime.Now.AddDays(7).AddYears(1);

            //MINIMUM TIME
            DateTime startTime = DateTime.Today.AddHours(6);
            DateTime startendTime = DateTime.Today.AddHours(20.5);

            while (startTime <= startendTime)
            {
                cboReservationStartTime.Items.Add(startTime.ToString("HH:mm"));
                startTime = startTime.AddMinutes(30);
            }

            //END TIME
            DateTime endStartTime = DateTime.Today.AddHours(6.5);
            DateTime endTime = DateTime.Today.AddHours(21);

            while (endStartTime <= endTime)
            {
                cboReservationEndTime.Items.Add(endStartTime.ToString("HH:mm"));
                endStartTime = endStartTime.AddMinutes(30);
            }
        }

        private void getVenue(SqlConnection conn)
        {
            try
            {
                //GET VENUE
                SqlCommand getVenue = new SqlCommand("SELECT * FROM [Venue] WHERE VenueName = @venuename", conn);

                getVenue.Parameters.AddWithValue("@venuename", cboVenues.Text);

                SqlDataReader reader = getVenue.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        venueid = Convert.ToInt32(reader["VenueID"].ToString());
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                Extra.showException(ex);
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            int counter = 0;

            //IF EMPTY UNG CHOICE SA COMBO BOX
            if (string.IsNullOrEmpty(cboVenues.Text) || string.IsNullOrEmpty(cboReservationEndTime.Text) || string.IsNullOrEmpty(cboReservationStartTime.Text))
            {
                Extra.showWarningMessage("Some fields are empty. Please try again.");
            }
            else
            {
                counter += 1;
            }

            DateTime startTimeParsed, endTimeParsed;
            bool isStartTimeValid = DateTime.TryParseExact(cboReservationStartTime.Text, "HH:mm",
                                                           CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                           out startTimeParsed);
            bool isEndTimeValid = DateTime.TryParseExact(cboReservationEndTime.Text, "HH:mm",
                                                         CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                         out endTimeParsed);

            //IF START TIME IS LATER THAN END TIME
            if (isStartTimeValid == false && isEndTimeValid == false && (!string.IsNullOrEmpty(cboReservationEndTime.Text) || !string.IsNullOrEmpty(cboReservationStartTime.Text)))
            {
                Extra.showWarningMessage("Start time must never be later than End Time. Please try again.");
            }
            else
            {
                counter += 1;
            }

            //IF MERON NA NAKA ASSIGN NA TIME
            if (!string.IsNullOrEmpty(cboVenues.Text) || !string.IsNullOrEmpty(cboReservationEndTime.Text) || !string.IsNullOrEmpty(cboReservationStartTime.Text))
            {
                SqlConnection conn = new SqlConnection(Extra.connectionString);
                try
                {
                    conn.Open();
                    getVenue(conn);

                    SqlCommand findOverlap = new SqlCommand("SELECT COUNT(*) FROM [Reservation] WHERE VenueID = @venueID AND ((ReservationStartTime < @endtime AND ReservationEndTime > @starttime)) AND ReservationDate = @reservationdate", conn);

                    DateTime reservationDate = DateTime.Parse(cboReservationDate.Text);
                    TimeSpan reservationStartTime = TimeSpan.Parse(cboReservationStartTime.Text);
                    TimeSpan reservationEndTime = TimeSpan.Parse(cboReservationEndTime.Text);

                    findOverlap.Parameters.AddWithValue("@venueID", venueid);
                    findOverlap.Parameters.AddWithValue("@endtime", reservationEndTime);
                    findOverlap.Parameters.AddWithValue("@starttime", reservationStartTime);
                    findOverlap.Parameters.AddWithValue("@reservationdate", reservationDate);

                    int count = (int)findOverlap.ExecuteScalar();

                    if(count > 0)
                    {
                        Extra.showWarningMessage("There is an overlap with your current reservation and another pre-set reservation. Please try again.");
                    }
                    else
                    {
                        counter += 1;
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

            if(counter == 3)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to reserve this venue? This cannot be edited once you submit it for approval.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(Extra.connectionString);

                    try
                    {
                        conn.Open();

                        DateTime reservationDate = DateTime.Parse(cboReservationDate.Text);
                        TimeSpan reservationStartTime = TimeSpan.Parse(cboReservationStartTime.Text);
                        TimeSpan reservationEndTime = TimeSpan.Parse(cboReservationEndTime.Text);
                        DateTime reservationCreationDate = DateTime.Now;

                        //INSERT RESERVATION
                        SqlCommand addReservation = new SqlCommand("INSERT INTO [Reservation] (accountID, VenueID, ReservationDate, ReservationStartTime, ReservationEndTime, ReservationCreationDate, ReservationStatus) VALUES (@accountid, @venueid, @reservationdate, @reservationstart, @reservationend, @reservationcreation, @reservationstatus)", conn);

                        addReservation.Parameters.AddWithValue("@accountID", Session.sessionUserID);
                        addReservation.Parameters.AddWithValue("@VenueID", venueid);
                        addReservation.Parameters.AddWithValue("@reservationdate", reservationDate);
                        addReservation.Parameters.AddWithValue("@reservationstart", reservationStartTime);
                        addReservation.Parameters.AddWithValue("@reservationend", reservationEndTime);
                        addReservation.Parameters.AddWithValue("@reservationcreation", reservationCreationDate);
                        addReservation.Parameters.AddWithValue("@reservationstatus", "ongoing");

                        int execute = addReservation.ExecuteNonQuery();

                        if (execute == 1)
                        {
                            DialogResult resulttwo = MessageBox.Show("Venue added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (resulttwo == DialogResult.OK)
                            {
                                cboVenues.SelectedIndex = 0;
                                cboReservationDate.Value = cboReservationDate.MinDate;
                                cboReservationStartTime.SelectedIndex = 0;
                                cboReservationEndTime.SelectedIndex = 0;
                            }
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