using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200519_ChacheDuomenu
{
    public partial class LogIn : Form
    {
        const string Vartototojas = "ABCDEF";
        const string Slaptazodis = "123456";
        Action SuccessFulLogIn;

        public LogIn(Action onSuccess)
        {
            InitializeComponent();
            SuccessFulLogIn = onSuccess;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Vartototojas == usernameText.Text && Slaptazodis == PasswordText.Text)
            {
                StreamWriter writer = new StreamWriter("prisijungimo.chache");
                writer.WriteLine(Vartototojas);
                writer.WriteLine("----------");
                writer.Flush();
                Close();
                SuccessFulLogIn();
            }
            else
            {
                MessageBox.Show("Netinkamas vartotojo vardas arba slaptazodis");
            }
        }
    }
}
