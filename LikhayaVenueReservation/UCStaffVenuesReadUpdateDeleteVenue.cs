using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikhayaVenueReservation
{
    public partial class UCStaffVenuesReadUpdateDeleteVenue : UserControl
    {
        public UCStaffVenuesReadUpdateDeleteVenue()
        {
            InitializeComponent();
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

            }
        }

        private void btnDeleteVenue_Click(object sender, EventArgs e)
        {

        }
    }
}
