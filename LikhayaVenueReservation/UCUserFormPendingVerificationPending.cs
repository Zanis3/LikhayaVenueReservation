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
    public partial class UCUserFormPendingVerificationPending : UserControl
    {
        public UCUserFormPendingVerificationPending()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.sessionUserID = 0;
            Session.sessionUsername = null;
            Session.sessionUserType = null;

            FormLogin login = new FormLogin();
            login.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }
    }
}
