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
    public partial class StaffScreen : Form
    {
        public StaffScreen()
        {
            InitializeComponent();
        }
        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to log-out?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (prompt == DialogResult.Yes)
            {
                Session.sessionUserID = 0;
                Session.sessionUsername = null;
                Session.sessionUserType = null;

                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnProfileButton_Click(object sender, EventArgs e)
        {
            UCStaffUserEditProfile profile = new UCStaffUserEditProfile();
            addUserControls(profile);
        }

        private void btnVenues_Click(object sender, EventArgs e)
        {
            UCStaffVenues venue = new UCStaffVenues();
            addUserControls(venue);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            UCStaffReservations reservations = new UCStaffReservations();
            addUserControls(reservations);
        }
    }
}
