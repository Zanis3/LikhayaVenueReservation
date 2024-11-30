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
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            else if(btnShowPass.Text == "Hide")
            {
                btnShowPass.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
            
        }

        private void lblRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister reg = new FormRegister();
            reg.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtPassword.Text = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            //IF USERNAME IS NOT EMPTY
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                try
                {
                    conn.Open();
                    string userVerifyStatus = "pending";
                    SqlCommand findUsername = new SqlCommand("SELECT * FROM [Account] WHERE accountUsername = @username", conn);

                    findUsername.Parameters.AddWithValue("@username", txtID.Text);
                    SqlDataReader reader = findUsername.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        string hashPass = reader["accountPassword"].ToString();
                        string password = txtPassword.Text;
                        string userType = reader["accountType"].ToString();
                        int userID = Convert.ToInt16(reader["accountID"]);
                        bool passwordVerifier = Password.hashVerifier(hashPass, password);
                        userVerifyStatus = reader["accountStatus"].ToString();

                        //PAG MALI PASSWORD
                        if (passwordVerifier == false)
                        {
                            Extra.showWarningMessage("Wrong Username or Password. Please Try Again.");
                        }
                        else
                        {
                            Session.sessionUsername = txtID.Text;
                            Session.sessionUserType = userType;
                            Session.sessionUserID = userID;

                            Extra.log($"{userType} '{txtID.Text}' logged into their account.");

                            if (userType == "user")
                            {

                                if(userVerifyStatus == "verified")
                                {
                                    UserScreen user = new UserScreen();
                                    user.Show();
                                }
                                else
                                {
                                    UserFormPendingVerification user = new UserFormPendingVerification();
                                    user.Show();
                                }

                                this.Hide();
                            }
                            else if (userType == "admin")
                            {
                                AdminScreen admin = new AdminScreen();
                                admin.Show();
                                this.Hide();
                            }
                            else if(userType == "staff")
                            {
                                StaffScreen staff = new StaffScreen();
                                staff.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        //IF USERNAME IS NOT FOUND
                        DialogResult result = MessageBox.Show($"Username not found. Proceed with registration?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (result == DialogResult.Yes)
                        {
                            FormRegister register = new FormRegister();
                            register.Show();
                            this.Hide();
                        }
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
                Extra.showWarningMessage("Please fill in all fields to continue.");
            }
        }
    }
}
