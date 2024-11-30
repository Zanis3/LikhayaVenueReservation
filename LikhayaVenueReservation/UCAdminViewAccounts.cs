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
    public partial class UCAdminViewAccounts : UserControl
    {
        private UCAdminViewAccountsDetails viewAccounts;
        public UCAdminViewAccounts()
        {
            InitializeComponent();
            tblViewAccounts.AutoGenerateColumns = true;
            loadAccountData("SELECT a.accountID, a.accountUsername, b.UserClassification, a.accountStatus FROM Account a LEFT JOIN UserClassification b ON a.accountID = b.accountID WHERE a.accountType = @accountType");
            tblViewAccounts.CellClick += tblViewAccounts_CellClick;
        }

        private void tblViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = tblViewAccounts.Rows[e.RowIndex];
                string accountID = selectedRow.Cells["accountID"].Value.ToString();

                if (viewAccounts == null || viewAccounts.IsDisposed)
                {
                    viewAccounts = new UCAdminViewAccountsDetails(accountID);
                    viewAccounts.ShowDialog();
                    viewAccounts.BringToFront();
                    viewAccounts.Focus();
                }
                else
                {
                    viewAccounts.Close();
                    viewAccounts = new UCAdminViewAccountsDetails(accountID);
                    viewAccounts.ShowDialog();
                    viewAccounts.BringToFront();
                    viewAccounts.Focus();
                }
            }
        }

        private void loadAccountData(string query, string searchValue = null)
        {
            tblViewAccounts.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            string searchQuery = txtSearchBox.Text;

            try
            {
                conn.Open();
                SqlCommand viewAllAccounts = new SqlCommand(query, conn);

                if (rdoUser.Checked)
                {
                    viewAllAccounts.Parameters.AddWithValue("@accountType", "user");
                }
                else if (rdoStaff.Checked)
                {
                    viewAllAccounts.Parameters.AddWithValue("@accountType", "staff");
                }

                viewAllAccounts.Parameters.AddWithValue("@searchvalue", searchQuery);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewAllAccounts);
                DataTable accountData = new DataTable();
                dataAdapter.Fill(accountData);

                if (accountData.Rows.Count > 0)
                {
                    tblViewAccounts.DataSource = accountData;
                }
                else
                {
                    Extra.showNoticeMessage("No data found.");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadAccountData("SELECT a.accountID, a.accountUsername, b.UserClassification, a.accountStatus FROM Account a LEFT JOIN UserClassification b ON a.accountID = b.accountID WHERE a.accountType = @accountType AND a.accountUsername LIKE @searchvalue", txtSearchBox.Text);
        }

        private void rdoUser_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchBox.Text = null;
            loadAccountData("SELECT a.accountID, a.accountUsername, b.UserClassification, a.accountStatus FROM Account a LEFT JOIN UserClassification b ON a.accountID = b.accountID WHERE a.accountType = @accountType");
        }

        private void rdoStaff_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchBox.Text = null;
            loadAccountData("SELECT accountID, accountUsername, accountStatus FROM Account WHERE accountType = @accountType");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchBox.Text = null;
            rdoUser.Checked = true;
            loadAccountData("SELECT a.accountID, a.accountUsername, b.UserClassification, a.accountStatus FROM Account a LEFT JOIN UserClassification b ON a.accountID = b.accountID WHERE a.accountType = @accountType");
        }
    }
}
