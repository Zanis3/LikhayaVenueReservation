using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikhayaVenueReservation
{
    public partial class UCAdminViewAccountsDetails : Form
    {
        private string accountID = "";
        private string accountType = "";
        private string accountStatus = "";
        public UCAdminViewAccountsDetails()
        {
            InitializeComponent();
        }

        public UCAdminViewAccountsDetails(string id) : this()
        {
            this.accountID = id;
            lblAccountID.Text = "Account ID: " + id;
            loadAccountData();
        }

        public void loadAccountData()
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();

                SqlCommand receiveAccount = new SqlCommand("SELECT a.accountUsername, a.accountType, a.accountStatus, d.LastName, d.FirstName, d.MiddleName, d.UserGroup, d.UserDesignation FROM AccountDetails d LEFT JOIN Account a ON a.accountID = d.accountID WHERE a.accountID = @id", conn);

                receiveAccount.Parameters.AddWithValue("@id", accountID);

                SqlDataReader reader = receiveAccount.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        txtMiddleName.Text = reader["MiddleName"].ToString();
                        txtUserGroup.Text = reader["UserGroup"].ToString();
                        txtUserDesignation.Text = reader["UserDesignation"].ToString();
                        txtUserClassification.Text = reader["accountUsername"].ToString();
                        accountType = reader["accountType"].ToString();
                        accountStatus = reader["accountStatus"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    Extra.showNoticeMessage("Something went wrong. Please try again.");
                    this.Close();
                }

                lblAccountType.Text = "Account Type: " + accountType;
                lblAccountStatus.Text = "Account Status: " + accountStatus;

                if (accountType == "user")
                {
                    SqlCommand userClass = new SqlCommand("SELECT * FROM [UserClassification] WHERE accountID = @accountID", conn);

                    userClass.Parameters.AddWithValue("@accountID", accountID);

                    SqlDataReader readertwo = userClass.ExecuteReader();

                    if (readertwo.HasRows)
                    {
                        while (readertwo.Read())
                        {
                            if (readertwo["UserClassification"].ToString() == "student")
                            {
                                rdoStudent.Checked = true;
                                lblUserClassification.Text = "Student ID:";
                            }
                            else
                            {
                                rdoOutsider.Checked = true;
                                lblUserClassification.Text = "Username:";
                            }
                        }

                        readertwo.Close();
                    }
                    else
                    {
                        Extra.showNoticeMessage("Something went wrong. Please try again.");
                        this.Close();
                    }

                    if(accountStatus == "verified")
                    {
                        btnVerifyAccount.Enabled = false;
                        btnRejectAccount.Enabled = false;
                    }
                    else if(accountStatus == "rejected")
                    {
                        btnVerifyAccount.Enabled = false;
                        btnRejectAccount.Enabled = false;
                        lblReasonRejection.Visible = true;
                        txtReason.Visible = true;
                        txtReason.Enabled = false;

                        SqlCommand getReason = new SqlCommand("SELECT * FROM [AccountRejection] WHERE accountID = @accountID", conn);

                        getReason.Parameters.AddWithValue("@accountID", accountID);

                        SqlDataReader readerthree = getReason.ExecuteReader();

                        if (readerthree.HasRows)
                        {
                            while (readerthree.Read())
                            {
                                txtReason.Text = readerthree["AccountRejection"].ToString();
                            }

                            readerthree.Close();
                        }
                        else
                        {
                            Extra.showNoticeMessage("Something went wrong. Please try again.");
                            this.Close();
                        }
                    }
                }
                else if(accountType == "staff")
                {
                    rdoOutsider.Checked = false;
                    rdoStudent.Checked = false;
                    btnVerifyAccount.Enabled = false;
                    btnRejectAccount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Extra.showException(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnVerifyAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to verify this account? This cannot be undone.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            SqlConnection conn = new SqlConnection(Extra.connectionString);
            
            if(result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand verifyAccount = new SqlCommand("UPDATE [Account] SET accountStatus = @accountStatus WHERE accountID = @accountID", conn);

                    verifyAccount.Parameters.AddWithValue("@accountID", accountID);
                    verifyAccount.Parameters.AddWithValue("@accountStatus","verified");

                    int success = verifyAccount.ExecuteNonQuery();

                    if (success > 0)
                    {
                        Extra.showSucessMessage("Account status updated successfully.");
                        lblAccountStatus.Text = "Account Status: verified";
                        btnVerifyAccount.Enabled = false;
                        btnRejectAccount.Enabled = false;
                    }
                    else
                    {
                        Extra.showWarningMessage("Account update failed. Please check the account ID.");
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

        private void btnReject_Click(object sender, EventArgs e)
        {
            if(btnRejectAccount.Text == "Reject")
            {
                lblReasonRejection.Visible = true;
                txtReason.Visible = true;
                btnRejectAccount.Text = "Confirm Rejection";
            }
            else if(btnRejectAccount.Text == "Confirm Rejection")
            {
                if (string.IsNullOrEmpty(txtReason.Text))
                {
                    Extra.showNoticeMessage("Please provide a reason for account rejection before continuing.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to reject this account? This cannot be undone.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(result == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(Extra.connectionString);
                        try
                        {
                            conn.Open();
                            SqlCommand rejectAccount = new SqlCommand("UPDATE [Account] SET accountStatus = @accountStatus WHERE accountID = @accountID", conn);

                            rejectAccount.Parameters.AddWithValue("@accountID", accountID);
                            rejectAccount.Parameters.AddWithValue("@accountStatus", "rejected");

                            int success = rejectAccount.ExecuteNonQuery();

                            if (success > 0)
                            {
                                Extra.showSucessMessage("Account status updated successfully.");
                                lblAccountStatus.Text = "Account Status: rejected";
                                btnVerifyAccount.Enabled = false;
                                btnRejectAccount.Enabled = false;
                                txtReason.Enabled = false;
                            }
                            else
                            {
                                Extra.showWarningMessage("Account update failed. Please check the account ID.");
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
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account? This cannot be undone.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            SqlConnection conn = new SqlConnection(Extra.connectionString);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand deleteAccount = new SqlCommand("DELETE * FROM [Account] WHERE accountID = @accountID");

                    deleteAccount.Parameters.AddWithValue("@accountID", accountID);

                    int success = deleteAccount.ExecuteNonQuery();

                    if (success > 0)
                    {
                        Extra.showSucessMessage("Account status updated successfully.");
                        DialogResult resulttwo = MessageBox.Show("Account successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(resulttwo == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        Extra.showWarningMessage("Account update failed. Please check the account ID.");
                    }
                }
                catch (Exception ex)
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
}
