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

                SqlCommand loadReservation = new SqlCommand("SELECT * FROM [Reservation] WHERE ReservationID = @reservationid", conn);

                loadReservation.Parameters.AddWithValue("@reservationid", Convert.ToInt16(id));

                SqlDataReader reader = loadReservation.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //ADD DITO UNG TEXTBOX DATA ETC
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
    }
}
