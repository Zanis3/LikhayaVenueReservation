﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikhayaVenueReservation
{

    //CONVENIENCE PURPOSES
    internal static class Extra
    {
        //SQL CONNECTION STRING
        private static string directory = @"C:\Users\USER\source\repos\LikhayaVenueReservation\LikhayaVenueReservation\LikhayaVenueReservation.mdf";
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + directory + ";Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True";

        //DIRECTORY NG MDF NI ZION
        /*
         C:\Users\USER\source\repos\LikhayaVenueReservation\LikhayaVenueReservation\LikhayaVenueReservation.mdf
        */

        //DATE
        public static string getDate()
        {
            DateTime currentDate = DateTime.Now;

            return currentDate.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //LOG
        public static void log(string desc)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand logAction = new SqlCommand("INSERT INTO Log (LogTime, LogDescription) VALUES (@logtime, @logdesc)", conn);

                logAction.Parameters.AddWithValue("@logtime", getDate());
                logAction.Parameters.AddWithValue("@logdesc", desc);
                logAction.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                showException(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //EXCEPTION
        public static void showException(Exception ex)
        {
            MessageBox.Show($"Something went wrong. Please try again. ({ex.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //WARNING MESSAGE
        public static void showWarningMessage(string warning)
        {
            MessageBox.Show(warning, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //SUCCESS MESSAGE
        public static void showSucessMessage(string success)
        {
            MessageBox.Show(success, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //NOTICE MESSAGE
        public static void showNoticeMessage(string notice)
        {
            MessageBox.Show(notice, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    //SAVE SESSION DATA
    internal static class Session
    {
        public static int sessionUserID { get; set; }
        public static string sessionUsername { get; set; }
        public static string sessionPassword { get; set; }
        public static string sessionUserType { get; set; }
    }

    //PASSWORD HASHING
    internal class Password
    {
        public static string passwordHasher(string password)
        {
            byte[] saltBytes = new byte[16];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];

            Array.Copy(saltBytes, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        public static bool hashVerifier(string hashPass, string password)
        {
            byte[] hashBytes = Convert.FromBase64String(hashPass);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }

            return true;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
