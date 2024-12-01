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
    public partial class UCUserReservationSettings : Form
    {
        private string reservationID = "";
        public UCUserReservationSettings()
        {
            InitializeComponent();
        }

        public UCUserReservationSettings(string settings, string id = null) : this()
        {
            this.reservationID = id;

            if (settings == "add")
            {
                UCUserAddReservation addReservation = new UCUserAddReservation();
                addUserControls(addReservation);
            }
            else if (settings == "update")
            {
                UCUserReservationReadUpdateDelete updateReservation = new UCUserReservationReadUpdateDelete(id);
                addUserControls(updateReservation);
            }
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlReservationContainer.Controls.Clear();
            pnlReservationContainer.Controls.Add(userControl);
        }
    }
}
