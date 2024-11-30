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
    public partial class UCUserFormPendingVerificationRejected : UserControl
    {
        public UCUserFormPendingVerificationRejected()
        {
            InitializeComponent();
            loadReason();
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

        private void btnReRegister_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }

        private void loadReason()
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();
                SqlCommand getReason = new SqlCommand("SELECT TOP 1 * FROM [Rejection] WHERE accountID = @accountID ORDER BY RejectionID DESC", conn);

                getReason.Parameters.AddWithValue("@accountID", Session.sessionUserID);

                SqlDataReader reader = getReason.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtReason.Text = reader["ReasonDesc"].ToString();
                    }

                    reader.Close();
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
    }
}
