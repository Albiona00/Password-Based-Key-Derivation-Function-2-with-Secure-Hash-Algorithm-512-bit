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
