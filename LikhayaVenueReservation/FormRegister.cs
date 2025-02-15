﻿using System;
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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            loadRejectedData();
        }

        private void loadRejectedData()
        {
            if(!string.IsNullOrEmpty(Session.sessionUsername))
            {
                SqlConnection conn = new SqlConnection(Extra.connectionString);

                try
                {
                    conn.Open();

                    //USER CLASSIFICATION
                    SqlCommand loadClassification = new SqlCommand("SELECT * FROM UserClassification WHERE accountID = @accountid", conn);

                    loadClassification.Parameters.AddWithValue("@accountid", Session.sessionUserID);

                    SqlDataReader readerClassification = loadClassification.ExecuteReader();

                    if (readerClassification.HasRows)
                    {
                        while (readerClassification.Read())
                        {
                            rdoUserClassStudent.Enabled = false;
                            rdoUserClassOutsider.Enabled = false;

                            if (readerClassification["UserClassification"].ToString() == "student")
                            {
                                rdoUserClassStudent.Checked = true;
                            }
                            else
                            {
                                rdoUserClassOutsider.Checked = true;
                            }
                        }
                        readerClassification.Close();
                    }

                    //UPDATE OTHER DATA
                    SqlCommand loadData = new SqlCommand("SELECT * FROM [AccountDetails] WHERE @accountID = accountID", conn);

                    loadData.Parameters.AddWithValue("@accountID", Session.sessionUserID);

                    SqlDataReader reader = loadData.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtMiddleName.Text = reader["MiddleName"].ToString();
                            txtUserClassification.Text = Session.sessionUsername;
                            txtUserClassification.Enabled = false;
                            txtPassword.Text = Session.sessionPassword;

                            txtUserGroup.Text = reader["UserGroup"].ToString();
                            txtUserDesignation.Text = reader["UserDesignation"].ToString();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult returnToLogin;

            if (!string.IsNullOrEmpty(Session.sessionUsername))
            {
                returnToLogin = MessageBox.Show("Are you sure you want to go back to the main menu? You will automatically be logged out, and you will need to log-in again to re-register.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                returnToLogin = MessageBox.Show("Are you sure you want to go back to the main menu? All information typed in will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (returnToLogin == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(Session.sessionUsername))
                {
                    Session.sessionPassword = null;
                    Session.sessionUserID = 0;
                    Session.sessionUsername = null;
                    Session.sessionUserType = null;
                }

                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void rdoUserClassStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUserClassStudent.Checked)
            {
                lblUserClassification.Text = "Student ID:";
                lblUserGroup.Text = "Org Name:";
            }
        }

        private void rdoUserClassOutsider_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUserClassOutsider.Checked)
            {
                lblUserClassification.Text = "Username:";
                lblUserGroup.Text = "Group Name:";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //CLEARS ALL TEXTBOXES
            DialogResult clear = MessageBox.Show("Are you sure you want clear all? All information typed in will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (clear == DialogResult.Yes)
            {
                txtLastName.Text = null;
                txtFirstName.Text = null;
                txtMiddleName.Text = null;

                rdoUserClassStudent.Checked = true;
                txtUserClassification.Text = null;
                txtUserGroup.Text = null;
                txtUserDesignation.Text = null;

                txtPassword.Text = null;
                txtConfirmPassword.Text = null;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            int counter = 0;

            //CHECKS WHETHER THE TEXTBOXES ARE EMPTY OR NOT (EXCEPT MIDDLE NAME)
            if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtUserClassification.Text) || string.IsNullOrEmpty(txtUserDesignation.Text) || string.IsNullOrEmpty(txtUserGroup.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                Extra.showWarningMessage("Some text fields are empty. Please try again.");
            }
            else
            {
                counter += 1;
            }

            //CHECKS IF PASSWORD AND CONFIRM PASSWORD MATCHES, IF PASSWORD LENGTH IS LESS THAN 8, IF PASSWORD LENGTH IS GREATER THAN 255
            if(txtPassword.Text != txtConfirmPassword.Text && txtPassword.Text.Length < 255)
            {
                Extra.showWarningMessage("Passwords do not match. Please try again.");
            }
            else if(txtPassword.Text.Length < 8)
            {
                Extra.showWarningMessage("Passwords is less than 8 characters. Please try again.");
            }
            else if (txtPassword.Text.Length > 255)
            {
                Extra.showWarningMessage("Passwords is more than 255 characters. Please try again.");
            }
            else
            {
                counter += 1;
            }

            //CHECKS IF A LOT OF TEXTBOXES ARE LESS THAN 2,3 OR MORE THAN 100 CHARACTERS LONG
            if (!string.IsNullOrEmpty(txtLastName.Text) || !string.IsNullOrEmpty(txtFirstName.Text) || !string.IsNullOrEmpty(txtUserDesignation.Text) || !string.IsNullOrEmpty(txtUserGroup.Text))
            {
                bool error = false;

                //LAST NAME
                if(txtLastName.Text.Length < 3)
                {
                    Extra.showWarningMessage("Last name is less than 3 characters long. Please Try Again.");
                    error = true;
                }
                else if(txtLastName.Text.Length > 100)
                {
                    Extra.showWarningMessage("Last name is more than 100 characters long. Please Try Again.");
                    error = true;
                }

                //FIRST NAME
                if (txtFirstName.Text.Length < 3)
                {
                    Extra.showWarningMessage("First name is less than 3 characters long. Please Try Again.");
                    error = true;
                }
                else if (txtFirstName.Text.Length > 100)
                {
                    Extra.showWarningMessage("First name is more than 100 characters long. Please Try Again.");
                    error = true;
                }

                //MIDDLE NAME
                if (!string.IsNullOrEmpty(txtMiddleName.Text))
                {
                    if (txtMiddleName.Text.Length < 3)
                    {
                        Extra.showWarningMessage("Middle name is less than 3 characters long. Please Try Again.");
                        error = true;
                    }
                    else if (txtMiddleName.Text.Length > 100)
                    {
                        Extra.showWarningMessage("Middle name is more than 100 characters long. Please Try Again.");
                        error = true;
                    }
                }

                //USER DESIGNATION
                if (txtUserDesignation.Text.Length < 2)
                {
                    Extra.showWarningMessage("User Designation is less than 2 characters long. Please Try Again.");
                    error = true;
                }
                else if (txtUserDesignation.Text.Length > 100)
                {
                    Extra.showWarningMessage("User Designation is more than 100 characters long. Please Try Again.");
                    error = true;
                }

                //USER GROUP
                if (txtUserGroup.Text.Length < 5)
                {
                    Extra.showWarningMessage("User Group is less than 5 characters long. Please Try Again.");
                    error = true;
                }
                else if (txtUserGroup.Text.Length > 100)
                {
                    Extra.showWarningMessage("User Group is more than 100 characters long. Please Try Again.");
                    error = true;
                }

                //IF NO ERRORS:
                if (error == false)
                {
                    counter += 1;
                }
            }

            //CHECKS IF STUDENT ID / USERNAME IS NOT EXACTLY NINE CHARACTERS LONG, USERNAME BETWEEN 5 AND 25
            if (rdoUserClassStudent.Checked && txtUserClassification.Text.Length != 9 && txtUserClassification.Text != null && !string.IsNullOrEmpty(txtUserClassification.Text))
            {
                Extra.showWarningMessage("Student ID must be nine characters long. Please try again.");
            }
            else if(rdoUserClassOutsider.Checked && (txtUserClassification.Text.Length < 5 || txtUserClassification.Text.Length > 25) && !string.IsNullOrEmpty(txtUserClassification.Text))
            {
                Extra.showWarningMessage("Username must be between five and twenty-five characters long. Please try again.");
            }
            else
            {
                counter += 1;
            }

            //CHECKS IF USERNAME ALREADY EXISTS
            if (!string.IsNullOrEmpty(txtUserClassification.Text) && string.IsNullOrEmpty(Session.sessionUsername))
            {
                string username = txtUserClassification.Text;
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

            if (counter == 4 && !string.IsNullOrEmpty(Session.sessionUsername))
            {
                updatedRejectedData();
            }
            else if(counter == 5)
            {
                try
                {
                    conn.Open();

                    //INSERTING DATA TO ACCOUNT TABLE
                    string username = txtUserClassification.Text;
                    string password = txtPassword.Text;
                    string hashPassword = Password.passwordHasher(password);
                    string accountType = "user";
                    string accountStatus = "pending";

                    SqlCommand executeReg = new SqlCommand("INSERT INTO [Account] (accountUsername, accountPassword, accountType, accountStatus) VALUES (@username, @password, @accountType, @accountStatus) SELECT SCOPE_IDENTITY()", conn);

                    executeReg.Parameters.AddWithValue("@username", username);
                    executeReg.Parameters.AddWithValue("@password", hashPassword);
                    executeReg.Parameters.AddWithValue("@accountType", accountType);
                    executeReg.Parameters.AddWithValue("@accountStatus", accountStatus);

                    int accountID = Convert.ToInt32(executeReg.ExecuteScalar());

                    //INSERTING DATA TO ACCOUNT DETAILS TABLE
                    string lastName = txtLastName.Text;
                    string firstName = txtFirstName.Text;
                    string middleName = txtMiddleName.Text;
                    string userGroup = txtUserGroup.Text;
                    string userDesignation = txtUserDesignation.Text;

                    SqlCommand executeRegTwo = new SqlCommand("INSERT INTO [AccountDetails] (accountID, LastName, FirstName, MiddleName, UserGroup, UserDesignation) VALUES (@accountID, @LastName, @FirstName, @MiddleName, @UserGroup, @UserDesignation)", conn);

                    executeRegTwo.Parameters.AddWithValue("@accountID", accountID);
                    executeRegTwo.Parameters.AddWithValue("@LastName", lastName);
                    executeRegTwo.Parameters.AddWithValue("@FirstName", firstName);
                    executeRegTwo.Parameters.AddWithValue("@MiddleName", middleName);
                    executeRegTwo.Parameters.AddWithValue("@UserGroup", userGroup);
                    executeRegTwo.Parameters.AddWithValue("@UserDesignation", userDesignation);

                    executeRegTwo.ExecuteNonQuery();

                    //INSERTING DATA TO USER CLASSIFICATION TABLE (USERS ONLY)
                    string userClassification;
                    if (rdoUserClassStudent.Checked)
                    {
                        userClassification = "student";
                    }
                    else
                    {
                        userClassification = "outsider";
                    }

                    SqlCommand executeRegThree = new SqlCommand("INSERT INTO [UserClassification] (accountID, UserClassification) VALUES (@accountID, @UserClassification)", conn);

                    executeRegThree.Parameters.AddWithValue("@accountID", accountID);
                    executeRegThree.Parameters.AddWithValue("@UserClassification", userClassification);

                    executeRegThree.ExecuteNonQuery();

                    Extra.log($"{accountType} '{username}' registered an account.");
                    Extra.showSucessMessage("Account registered! Please login to access your account.");
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

        private void updatedRejectedData()
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();
                bool passMatch = false;

                SqlCommand findAccount = new SqlCommand("SELECT * FROM [Account] WHERE accountID = @accountid", conn);

                findAccount.Parameters.AddWithValue("@accountid", Session.sessionUserID);

                SqlDataReader reader = findAccount.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        passMatch = Password.hashVerifier(reader["accountPassword"].ToString(), txtPassword.Text);
                    }

                    reader.Close();
                }

                if (passMatch == false)
                {
                    Extra.showWarningMessage("For Rejected Users: Please use the student id/username and password you registered your account with in order to avoid conflicts. Thank you.");
                }
                else
                {
                    SqlCommand updateStatus = new SqlCommand("UPDATE [Account] SET accountStatus = @accountStatus WHERE accountID = @accountid", conn);

                    updateStatus.Parameters.AddWithValue("@accountStatus", "pending");
                    updateStatus.Parameters.AddWithValue("@accountid", Session.sessionUserID);

                    updateStatus.ExecuteNonQuery();

                    SqlCommand updateAccount = new SqlCommand("UPDATE [AccountDetails] SET LastName = @lastname, FirstName = @firstName, MiddleName = @middleName, UserGroup = @usergroup, UserDesignation = @userdesignation WHERE accountID = @accountid", conn);

                    updateAccount.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    updateAccount.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                    updateAccount.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
                    updateAccount.Parameters.AddWithValue("@usergroup", txtUserGroup.Text);
                    updateAccount.Parameters.AddWithValue("@userdesignation", txtUserDesignation.Text);
                    updateAccount.Parameters.AddWithValue("@accountid", Session.sessionUserID);

                    int successA = updateAccount.ExecuteNonQuery();

                    if (successA == 1)
                    {
                        DialogResult result = MessageBox.Show("Re-Registration Successful. Please wait for an administrator to approve your account. You will log out automatically once you click 'OK'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            Session.sessionPassword = null;
                            Session.sessionUserID = 0;
                            Session.sessionUsername = null;
                            Session.sessionUserType = null;

                            FormLogin login = new FormLogin();
                            login.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        Extra.showWarningMessage("Something has gone wrong. Please try again.");
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
