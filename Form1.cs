using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBKDF2_SHA512BIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Example parameters
                byte[] salt = GenerateSalt();
                int iterations = 1; // Number of iterations (adjust according to your security requirements)
                int derivedKeyLength = 64; // 64 bytes for SHA-512

                // Generate the derived key using PBKDF2-SHA512
                byte[] derivedKey = GenerateDerivedKey(password, salt, iterations, derivedKeyLength);

                // Convert the derived key to a hex string for storage or comparison
                string derivedKeyHex = BitConverter.ToString(derivedKey).Replace("-", "");

                // Now, you can use the derivedKeyHex as needed (e.g., compare it with stored hash)

                // For testing purposes, you can display the derived key in a message box
                MessageBox.Show("Login Successful!\nDerived Key (Hex): " + derivedKeyHex, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static byte[] GenerateSalt(int saltLength = 16)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[saltLength];
                rng.GetBytes(salt);
                return salt;
            }
        }
        static byte[] GenerateDerivedKey(string password, byte[] salt, int iterations, int derivedKeyLength)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA512))
            {
                return pbkdf2.GetBytes(derivedKeyLength);
            }
        }
    }
}
