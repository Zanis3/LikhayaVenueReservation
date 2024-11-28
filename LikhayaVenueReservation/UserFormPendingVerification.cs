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
    public partial class UserFormPendingVerification : Form
    {
        public UserFormPendingVerification()
        {
            InitializeComponent();
            loadPanel();
        }

        private void loadPanel()
        {
            int accountID = Session.sessionUserID;
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();
                SqlCommand findAccount = new SqlCommand("SELECT * FROM [Account] WHERE accountID = @accountID", conn);

                findAccount.Parameters.AddWithValue("@accountID", accountID);
                SqlDataReader reader = findAccount.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string accountStatus = reader["accountStatus"].ToString();

                    if(accountStatus == "pending")
                    {
                        UCUserFormPendingVerificationPending pending = new UCUserFormPendingVerificationPending();
                        addUserControls(pending);
                    }
                    else
                    {
                        UCUserFormPendingVerificationRejected rejected = new UCUserFormPendingVerificationRejected();
                        addUserControls(rejected);
                    }
                }
            }
            catch(Exception ex)
            {
                Extra.showException(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlAccountStatus.Controls.Clear();
            pnlAccountStatus.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
