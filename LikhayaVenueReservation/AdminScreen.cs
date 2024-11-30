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

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
        }
        private void btnProfileButton_Click(object sender, EventArgs e)
        {
            UCAdminEditProfile profile = new UCAdminEditProfile();
            addUserControls(profile);
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            UCAdminAddStaffAdmin addAcc = new UCAdminAddStaffAdmin();
            addUserControls(addAcc);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            UCAdminViewAccounts viewAccs = new UCAdminViewAccounts();
            addUserControls(viewAccs);
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            UCViewLogs log = new UCViewLogs();
            addUserControls(log);
        }
    }
}
