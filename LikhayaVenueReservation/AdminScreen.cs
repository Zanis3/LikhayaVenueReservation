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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        private void btnProfileButton_Click(object sender, EventArgs e)
        {
            pnlProfileButtons.Visible = !pnlProfileButtons.Visible;

            if(pnlProfileButtons.Visible == true)
            {
                btnProfileButton.BackColor = Color.White;
                pnlProfileButtons.BringToFront();
            }
            else
            {
                btnProfileButton.BackColor = Color.Transparent;
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to log-out?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(prompt == DialogResult.Yes)
            {
                Session.sessionUserID = 0;
                Session.sessionUsername = null;
                Session.sessionUserType = null;

                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {

        }
    }
}
