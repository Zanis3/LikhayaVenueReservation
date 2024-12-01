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
    public partial class UserScreen : Form
    {
        public UserScreen()
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

        private void btnReservations_Click(object sender, EventArgs e)
        {
            UCUserReservations reserve = new UCUserReservations();
            addUserControls(reserve);
        }
    }
}
