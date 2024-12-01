using System;
using System.CodeDom.Compiler;
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
    public partial class UCStaffVenuesReadUpdateDeleteVenue : UserControl
    {
        private string venueID = "";
        public UCStaffVenuesReadUpdateDeleteVenue()
        {
            InitializeComponent();
        }

        public UCStaffVenuesReadUpdateDeleteVenue(string id) : this()
        {
            venueID = id;
            loadVenue(venueID);
        }

        private void loadVenue(string id)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();

                SqlCommand loadVenue = new SqlCommand("SELECT * FROM [Venue] WHERE VenueID = @venueid", conn);

                loadVenue.Parameters.AddWithValue("@venueid", Convert.ToInt16(id));

                SqlDataReader reader = loadVenue.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtVenueName.Text = reader["VenueName"].ToString();
                        cboVenueLocation.Text = reader["VenueLocation"].ToString();
                        txtVenueDescription.Text = reader["VenueDescription"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No data found for the given VenueID.", "Error");
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

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
            if(btnUpdateVenue.Text == "Update Venue")
            {
                btnUpdateVenue.Text = "Confirm Update";
                btnDeleteVenue.Enabled = false;
                txtVenueName.Enabled = true;
                cboVenueLocation.Enabled = true;
                txtVenueDescription.Enabled = true;

            }
            else if(btnUpdateVenue.Text == "Confirm Update")
            {
                int counter = 0;

                //IF MAY EMPTY FIELD
                if (string.IsNullOrEmpty(txtVenueName.Text) || string.IsNullOrEmpty(txtVenueDescription.Text) || string.IsNullOrEmpty(cboVenueLocation.Text))
                {
                    Extra.showWarningMessage("Some text fields are empty. Please try again.");
                }
                else
                {
                    counter += 1;
                }

                //TEXT LIMITS
                if (!string.IsNullOrEmpty(txtVenueName.Text) && !string.IsNullOrEmpty(txtVenueDescription.Text))
                {
                    if (txtVenueName.Text.Length < 5 || txtVenueName.Text.Length > 50)
                    {
                        Extra.showWarningMessage("Venue Name must be between 5 to 50 characters long. Please try again.");
                    }
                    else if (txtVenueDescription.Text.Length < 5 || txtVenueDescription.Text.Length > 255)
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

                        SqlCommand searchName = new SqlCommand("SELECT * FROM [Venue] WHERE VenueName = @venuename AND VenueID != @venueid", conn);

                        searchName.Parameters.AddWithValue("@venuename", txtVenueName.Text);
                        searchName.Parameters.AddWithValue("@venueid", venueID);

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

                if (counter == 3)
                {
                    SqlConnection conn = new SqlConnection(Extra.connectionString);

                    try
                    {
                        conn.Open();

                        SqlCommand updateVenue = new SqlCommand("UPDATE [Venue] SET VenueName = @venuename, VenueLocation = @venuelocation, VenueDescription = @venuedescription WHERE VenueID = @venueid", conn);

                        updateVenue.Parameters.AddWithValue("@venuename", txtVenueName.Text);
                        updateVenue.Parameters.AddWithValue("@venuelocation", cboVenueLocation.Text);
                        updateVenue.Parameters.AddWithValue("@venuedescription", txtVenueDescription.Text);
                        updateVenue.Parameters.AddWithValue("@venueid", venueID);

                        int execute = updateVenue.ExecuteNonQuery();

                        if (execute == 1)
                        {
                            DialogResult result = MessageBox.Show("Venue updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (result == DialogResult.OK)
                            {
                                btnUpdateVenue.Text = "Update Venue";
                                btnDeleteVenue.Enabled = true;
                                txtVenueName.Enabled = false;
                                cboVenueLocation.Enabled = false;
                                txtVenueDescription.Enabled = false;
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

        private void btnDeleteVenue_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this venue? This cannot be undone.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            SqlConnection conn = new SqlConnection(Extra.connectionString);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand deleteVenue = new SqlCommand("DELETE FROM [Venue] WHERE VenueID = @venueid", conn);

                    deleteVenue.Parameters.AddWithValue("@venueid", venueID);

                    int success = deleteVenue.ExecuteNonQuery();

                    if (success > 0)
                    {
                        DialogResult resulttwo = MessageBox.Show("Venue successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resulttwo == DialogResult.OK)
                        {
                            Form parentForm = this.FindForm();
                            if (parentForm != null)
                            {
                                parentForm.Hide();
                            }
                        }
                    }
                    else
                    {
                        Extra.showWarningMessage("Venue deletion failed. Please check the account ID.");
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
