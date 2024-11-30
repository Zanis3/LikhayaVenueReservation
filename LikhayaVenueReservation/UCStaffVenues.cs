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
    public partial class UCStaffVenues : UserControl
    {
        private UCStaffVenuesSettings viewVenue;

        public UCStaffVenues()
        {
            InitializeComponent();
            tblViewVenues.AutoGenerateColumns = true;
            loadVenueData("SELECT * FROM [Venue]");
            tblViewVenues.CellClick += tblViewVenues_CellClick;
        }

        private void tblViewVenues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblViewVenues.Rows[e.RowIndex];
                string venueID = selectedRow.Cells["VenueID"].Value.ToString();

                if (viewVenue == null || viewVenue.IsDisposed)
                {
                    viewVenue = new UCStaffVenuesSettings("update", venueID);
                }
                else
                {
                    viewVenue.Close();
                    viewVenue = new UCStaffVenuesSettings("update", venueID);
                }

                viewVenue.ShowDialog();
                viewVenue.BringToFront();
                viewVenue.Focus();
            }
        }

        private void loadVenueData(string query, string searchValue = null)
        {
            tblViewVenues.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            string searchQuery = txtSearchVenue.Text;

            try
            {
                conn.Open();
                SqlCommand viewAllVenues = new SqlCommand(query, conn);

                viewAllVenues.Parameters.AddWithValue("@searchvalue", searchQuery);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewAllVenues);
                DataTable venueData = new DataTable();
                dataAdapter.Fill(venueData);

                if (venueData.Rows.Count > 0)
                {
                    tblViewVenues.DataSource = venueData;
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
            string query = @"SELECT * FROM [Venue] WHERE (VenueID = @searchvalue OR VenueName LIKE @searchValue OR VenueLocation LIKE @searchvalue OR VenueDescription LIKE @searchvalue)";

            string searchValue = txtSearchVenue.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                searchValue = "%";
            }
            else
            {
                searchValue = "%" + searchValue + "%";
            }

            loadVenueData(query, searchValue);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            loadVenueData("SELECT * FROM [Venue]");
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            UCStaffVenuesSettings addVenue = new UCStaffVenuesSettings("add");
            addVenue.Show();
        }
    }
}
