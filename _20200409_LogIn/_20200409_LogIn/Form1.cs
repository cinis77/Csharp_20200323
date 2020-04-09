using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200409_LogIn
{
   

    public partial class Form1 : Form
    {
        List<Vartotojai> Vartotojais;

        public Form1()
        {
            InitializeComponent();
            Vartotojais = new List<Vartotojai>();
            UzpildytiVartotojuMasyva();
        }

        private void UzpildytiVartotojuMasyva()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("vartotojai.txt");
            string line = null;
            while((line = reader.ReadLine())!= null)
            {
                Vartotojai vart = new Vartotojai();
                var data = line.Split(' ');
                vart.UserName = data[0];
                vart.Slaptazodis = data[1];
                Vartotojais.Add(vart);
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            foreach(Vartotojai vart in Vartotojais)
            {
                if (vart.UserName == UserNameTextBox.Text && vart.Slaptazodis == PasswordBox.Text)
                {
                    MessageBox.Show("Prisijungti pavyko");
                    break;
                }
            }
        }
    }

    class Vartotojai
    {
        public string UserName { get; set; }
        public string Slaptazodis { get; set; }
    }

}
