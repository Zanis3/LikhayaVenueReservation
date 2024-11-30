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
    public partial class UCStaffVenuesAddVenue : UserControl
    {
        public UCStaffVenuesAddVenue()
        {
            InitializeComponent();
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            int counter = 0;

            //IF MAY EMPTY FIELD
            if(string.IsNullOrEmpty(txtVenueName.Text) || string.IsNullOrEmpty(txtVenueDescription.Text) || string.IsNullOrEmpty(cboVenueLocation.Text))
            {
                Extra.showWarningMessage("Some text fields are empty. Please try again.");
            }
            else
            {
                counter += 1;
            }

            //TEXT LIMITS
            if(!string.IsNullOrEmpty(txtVenueName.Text) && !string.IsNullOrEmpty(txtVenueDescription.Text))
            {
                if(txtVenueName.Text.Length < 5 || txtVenueName.Text.Length > 50)
                {
                    Extra.showWarningMessage("Venue Name must be between 5 to 50 characters long. Please try again.");
                }
                else if(txtVenueDescription.Text.Length < 5 || txtVenueDescription.Text.Length > 255)
                {
                    Extra.showWarningMessage("Venue Description must be between 5 to 255 characters long. Please try again.");
                }
                else
                {
                    counter += 1;
                }
            }

            //IF NAME ALREADY EXISTS
            if (!string.IsNullOrEmpty(txtVenueName.Text))
            {
                SqlConnection conn = new SqlConnection(Extra.connectionString);

                try
                {
                    conn.Open();

                    SqlCommand searchName = new SqlCommand("SELECT * FROM [Venue] WHERE VenueName = @venuename", conn);

                    searchName.Parameters.AddWithValue("@venuename", txtVenueName.Text);

                    SqlDataReader reader = searchName.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Extra.showWarningMessage("Venue with that name already exists. Please try again.");
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
                SqlConnection conn = new SqlConnection(Extra.connectionString);

                try
                {
                    conn.Open();

                    SqlCommand addVenue = new SqlCommand("INSERT INTO [Venue] (VenueName, VenueLocation, VenueDescription) VALUES (@venuename, @venueLocation, @venueDescription)", conn);

                    addVenue.Parameters.AddWithValue("@venuename", txtVenueName.Text);
                    addVenue.Parameters.AddWithValue("@venueLocation", cboVenueLocation.Text);
                    addVenue.Parameters.AddWithValue("@venueDescription", txtVenueDescription.Text);

                    int execute = addVenue.ExecuteNonQuery();

                    if(execute == 1)
                    {
                        DialogResult result = MessageBox.Show("Venue added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(result == DialogResult.OK)
                        {
                            txtVenueName.Text = null;
                            txtVenueDescription.Text = null;
                            cboVenueLocation.SelectedIndex = 0;
                        }
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
            }
        }
    }
}