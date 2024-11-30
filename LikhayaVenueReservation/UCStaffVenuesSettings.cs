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
    public partial class UCStaffVenuesSettings : Form
    {
        private string venueID = "";

        public UCStaffVenuesSettings()
        {
            InitializeComponent();
        }

        public UCStaffVenuesSettings(string settings, string id = null) : this()
        {
            this.venueID = id;

            if(settings == "add")
            {
                UCStaffVenuesAddVenue addVenue = new UCStaffVenuesAddVenue();
                addUserControls(addVenue);
            }
            else if(settings == "update")
            {

            }
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlVenueContainer.Controls.Clear();
            pnlVenueContainer.Controls.Add(userControl);
        }
    }
}
