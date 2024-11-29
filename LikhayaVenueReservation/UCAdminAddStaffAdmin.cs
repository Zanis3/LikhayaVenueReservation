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
    public partial class UCAdminAddStaffAdmin : UserControl
    {
        internal static bool staff { get; set; }
        internal static bool admin { get; set; }
        public UCAdminAddStaffAdmin()
        {
            InitializeComponent();
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin = true;
            staff = false;

            if (admin)
            {
                btnAdmin.BackColor = Color.White;
                btnAdmin.ForeColor = Color.SteelBlue;
                btnStaff.BackColor = Color.SteelBlue;
                btnStaff.ForeColor = Color.White;
            }

            UCAdminAddAdmin adminForm = new UCAdminAddAdmin();
            addUserControls(adminForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            admin = false;
            staff = true;

            if (staff)
            {
                btnAdmin.BackColor = Color.SteelBlue;
                btnAdmin.ForeColor = Color.White;
                btnStaff.BackColor = Color.White;
                btnStaff.ForeColor = Color.SteelBlue;
            }

            UCAdminAddStaff staffForm = new UCAdminAddStaff();
            addUserControls(staffForm);
        }
    }
}
