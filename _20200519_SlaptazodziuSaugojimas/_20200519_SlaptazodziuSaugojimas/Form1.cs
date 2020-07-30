using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _20200519_SlaptazodziuSaugojimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HashMd5_Click(object sender, EventArgs e)
        {
            var md5 = new MD5CryptoServiceProvider();

            var data = UTF8Encoding.UTF8.GetBytes(VartotojoSlaptazodis.Text);
            // 0x41 => A
            // 0x31 => 1 
            var sifruotiDuomenis = md5.ComputeHash(data);
            md5HashSlaptazodis.Text = Encoding.UTF8.GetString(sifruotiDuomenis);

        }

        private void SHA1button_Click(object sender, EventArgs e)
        {
            var sha1 = new SHA1CryptoServiceProvider();

            var data = UTF8Encoding.UTF8.GetBytes(VartotojoSlaptazodis.Text);
            var sifruotiDuomenys = sha1.ComputeHash(data);

            SHA1Text.Text = Encoding.UTF8.GetString(sifruotiDuomenys);
        }

        private void HashWithSalt_Click(object sender, EventArgs e)
        {
            byte[] salt;

            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(VartotojoSlaptazodis.Text, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);

            HashWithSaltText.Text = Convert.ToBase64String(hashbytes);
        }

        private void UnhashSalt_Click(object sender, EventArgs e)
        {
            byte[] hashbytes = Convert.FromBase64String(HashWithSaltText.Text);
            byte[] salt = new byte[16];
            Array.Copy(hashbytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(SlaptazodisText.Text, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashbytes[i+16] != hash[i])
                {
                    SlaptazodisText.BackColor = Color.Red;
                    break;
                }
            }
        }
    }
}
