using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikhayaVenueReservation
{
    public partial class UCAdminEditProfile : UserControl
    {
        public UCAdminEditProfile()
        {
            InitializeComponent();
            loadInfo();
        }

        private void loadInfo()
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();

                SqlCommand findUsername = new SqlCommand("SELECT * FROM [Account] WHERE accountUsername = @username", conn);

                findUsername.Parameters.AddWithValue("@username", Session.sessionUsername);

                SqlDataReader reader = findUsername.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtUsername.Text = reader["accountUsername"].ToString();
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

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (btnShowPassword.Text == "Show")
            {
                btnShowPassword.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else if (btnShowPassword.Text == "Hide")
            {
                btnShowPassword.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            if(btnEditUsername.Text == "Edit")
            {
                btnEditUsername.Text = "Save";
                btnEditUsername.BackColor = Color.ForestGreen;
                txtUsername.Enabled = true;
            }
            else if(btnEditUsername.Text == "Save")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit your username? This cannot be undone.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(Extra.connectionString);
                    int counter = 0;

                    if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        Extra.showWarningMessage("The field is empty. Please try again.");
                    }
                    else
                    {
                        counter += 1;
                    }

                    if((txtUsername.Text.Length < 5 || txtUsername.Text.Length > 25) && !string.IsNullOrEmpty(txtUsername.Text))
                    {
                        Extra.showWarningMessage("Username should only be between 5 and 25 characters long. Please try again.");
                    }
                    else
                    {
                        counter += 1;
                    }

                    if (!string.IsNullOrEmpty(txtUsername.Text))
                    {
                        string username = txtUsername.Text;
                        conn.Open();
                        try
                        {
                            SqlCommand findUsername = new SqlCommand("SELECT * FROM [Account] WHERE accountUsername = @username", conn);

                            findUsername.Parameters.AddWithValue("@username", username);

                            SqlDataReader reader = findUsername.ExecuteReader();
                            if (reader.HasRows)
                            {
                                Extra.showWarningMessage("Username already exists. Please try another username.");
                            }
                            else
                            {
                                counter++;
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
                    else
                    {
                        counter += 1;
                    }

                    if(counter == 3)
                    {
                        try
                        {
                            conn.Open();

                            SqlCommand findUsername = new SqlCommand("SELECT * FROM [Account] WHERE accountUsername = @username", conn);

                            findUsername.Parameters.AddWithValue("@username", Session.sessionUsername);

                            SqlDataReader reader = findUsername.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    SqlCommand editUsername = new SqlCommand("UPDATE [Account] SET accountUsername = @username WHERE accountUsername = @oldUsername", conn);

                                    editUsername.Parameters.AddWithValue("@username", txtUsername.Text);
                                    editUsername.Parameters.AddWithValue("@oldUsername", Session.sessionUsername);

                                    int edit = editUsername.ExecuteNonQuery();

                                    if (edit > 0)
                                    {
                                        Extra.showSucessMessage("Account username has been successfully changed.");
                                        Session.sessionUsername = txtUsername.Text;
                                    }
                                }

                                reader.Close();
                            }
                            else
                            {
                                Extra.showNoticeMessage("Something went wrong. Pleasee try again.");
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
                    
                    btnEditUsername.Text = "Edit";
                    btnEditUsername.BackColor = Color.SteelBlue;
                    txtUsername.Text = Session.sessionUsername;
                    txtUsername.Enabled = false;
                }
            }
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (btnEditPassword.Text == "Edit")
            {
                btnEditPassword.Text = "Save";
                btnEditPassword.BackColor = Color.ForestGreen;
                txtPassword.Enabled = true;
            }
            else if (btnEditPassword.Text == "Save")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit your password? This cannot be undone.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    if (txtPassword.Text.Length < 8)
                    {
                        Extra.showWarningMessage("Passwords is less than 8 characters. Please try again.");
                    }
                    else if (txtPassword.Text.Length > 255)
                    {
                        Extra.showWarningMessage("Passwords is more than 255 characters. Please try again.");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(Extra.connectionString);

                        try
                        {
                            conn.Open();

                            SqlCommand findUsername = new SqlCommand("SELECT * FROM [Account] WHERE accountUsername = @username", conn);

                            findUsername.Parameters.AddWithValue("@username", Session.sessionUsername);

                            SqlDataReader reader = findUsername.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    SqlCommand editPassword = new SqlCommand("UPDATE [Account] SET accountPassword = @password WHERE accountUsername = @username", conn);

                                    editPassword.Parameters.AddWithValue("@password", Password.passwordHasher(txtUsername.Text));
                                    editPassword.Parameters.AddWithValue("@username", Session.sessionUsername);

                                    int edit = editPassword.ExecuteNonQuery();

                                    if (edit > 0)
                                    {
                                        Extra.showSucessMessage("Account password has been successfully changed.");
                                        Session.sessionUsername = txtUsername.Text;
                                    }
                                }

                                reader.Close();
                            }
                            else
                            {
                                Extra.showNoticeMessage("Something went wrong. Pleasee try again.");
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

                    btnEditPassword.Text = "Edit";
                    btnEditPassword.BackColor = Color.SteelBlue;
                    txtPassword.Text = null;
                    txtPassword.Enabled = false;
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account? This cannot be undone.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                conn.Open();
                try
                {
                    SqlCommand findAdmins = new SqlCommand("SELECT COUNT(*) FROM [Account] WHERE accountType = @admin", conn);

                    findAdmins.Parameters.AddWithValue("@admin", "admin");

                    int adminCount = (int)findAdmins.ExecuteScalar();

                    if (adminCount < 2)
                    {
                        Extra.showNoticeMessage("You cannot delete your account because there is only one admin account");
                    }
                    else
                    {
                        SqlCommand deleteAccount = new SqlCommand("DELETE FROM [Account] WHERE accountUsername = @username", conn);

                        deleteAccount.Parameters.AddWithValue("@username", Session.sessionUsername);

                        int success = deleteAccount.ExecuteNonQuery();

                        if (success == 1)
                        {
                            DialogResult results = MessageBox.Show("Account deleted. Proceeding back to login screen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (results == DialogResult.OK)
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
                        else
                        {
                            Extra.showNoticeMessage("Account deletion failed. Please try again.");
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
        }
    }
}
