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
    public partial class UCAdminAddStaff : UserControl
    {
        public UCAdminAddStaff()
        {
            InitializeComponent();
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

                txtUserClassification.Text = null;
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
            if (txtPassword.Text != txtConfirmPassword.Text && txtPassword.Text.Length < 255)
            {
                Extra.showWarningMessage("Passwords do not match. Please try again.");
            }
            else if (txtPassword.Text.Length < 8)
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
                if (txtLastName.Text.Length < 3)
                {
                    Extra.showWarningMessage("Last name is less than 3 characters long. Please Try Again.");
                    error = true;
                }
                else if (txtLastName.Text.Length > 100)
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

                //IF NO ERRORS:
                if (error == false)
                {
                    counter += 1;
                }

                //CHECKS IF USERNAME IS NOT EXACTLY NINE CHARACTERS LONG, USERNAME BETWEEN 5 AND 25
                if ((txtUserClassification.Text.Length < 5 || txtUserClassification.Text.Length > 25) && !string.IsNullOrEmpty(txtUserClassification.Text))
                {
                    Extra.showWarningMessage("Username must be between five and twenty-five characters long. Please try again.");
                }
                else
                {
                    counter += 1;
                }

                //CHECKS IF USERNAME ALREADY EXISTS
                if (!string.IsNullOrEmpty(txtUserClassification.Text))
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

                if (counter == 5)
                {
                    try
                    {
                        conn.Open();

                        //INSERTING DATA TO ACCOUNT TABLE
                        string username = txtUserClassification.Text;
                        string password = txtPassword.Text;
                        string hashPassword = Password.passwordHasher(password);
                        string accountType = "staff";
                        string accountStatus = "verified";

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

                        Extra.log($"{accountType} '{username}' registered an account.");
                        Extra.showSucessMessage("Account registered! Please login to access your account.");
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
}
