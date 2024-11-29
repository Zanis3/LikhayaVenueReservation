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
    public partial class UCAdminAddAdmin : UserControl
    {
        public UCAdminAddAdmin()
        {
            InitializeComponent();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (btnShowPass.Text == "Show")
            {
                btnShowPass.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else if (btnShowPass.Text == "Hide")
            {
                btnShowPass.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (btnConfirmPassword.Text == "Show")
            {
                btnConfirmPassword.Text = "Hide";
                txtConfirmPassword.PasswordChar = '\0';
            }
            else if (btnConfirmPassword.Text == "Hide")
            {
                btnConfirmPassword.Text = "Show";
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);
            int counter = 0;

            //CHECKS WHETHER THE TEXTBOXES ARE EMPTY OR NOT (EXCEPT MIDDLE NAME)
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
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

            //CHECKS IF USERNAME IS NOT EXACTLY NINE CHARACTERS LONG, USERNAME BETWEEN 5 AND 25
            if ((txtUsername.Text.Length < 5 || txtUsername.Text.Length > 25) && !string.IsNullOrEmpty(txtUsername.Text))
            {
                Extra.showWarningMessage("Username must be between five and twenty-five characters long. Please try again.");
            }
            else
            {
                counter += 1;
            }

            //CHECKS IF USERNAME ALREADY EXISTS
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

            if (counter == 4)
            {
                try
                {
                    conn.Open();

                    //INSERTING DATA TO ACCOUNT TABLE
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string hashPassword = Password.passwordHasher(password);
                    string accountType = "admin";
                    string accountStatus = "verified";

                    SqlCommand executeReg = new SqlCommand("INSERT INTO [Account] (accountUsername, accountPassword, accountType, accountStatus) VALUES (@username, @password, @accountType, @accountStatus) SELECT SCOPE_IDENTITY()", conn);

                    executeReg.Parameters.AddWithValue("@username", username);
                    executeReg.Parameters.AddWithValue("@password", hashPassword);
                    executeReg.Parameters.AddWithValue("@accountType", accountType);
                    executeReg.Parameters.AddWithValue("@accountStatus", accountStatus);

                    int accountID = Convert.ToInt32(executeReg.ExecuteScalar());

                    if(accountID > 0)
                    {
                        Extra.log($"{accountType} '{username}' registered an account.");
                        Extra.showSucessMessage("Account registered! Please login to access your account.");
                    }
                    else
                    {
                        Extra.showWarningMessage("Something seems to have gone wrong when registering your account. Please try again.");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
            txtConfirmPassword.Text = null;
        }
    }
}
