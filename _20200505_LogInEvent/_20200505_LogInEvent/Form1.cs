using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200505_LogInEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SlaptazodisText.MouseEnter += TextBoxMouseEnter;
            SlaptazodisText.MouseLeave += TextBoxMouseLeave;
        }


        private void TextBoxMouseEnter(object sender, EventArgs e)
        {
            TextBox textBoksas = (TextBox)sender;
            textBoksas.PasswordChar = '\0';
        }

        private void TextBoxMouseLeave(object sender, EventArgs e)
        {
            TextBox textBoksas = (TextBox)sender;
            textBoksas.PasswordChar = '*';
        }
    }
}
