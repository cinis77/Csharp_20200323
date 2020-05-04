using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200504_DelegataiWinFormos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MinimizaOpenButton_Click(object sender, EventArgs e)
        {
            Action action = UzsidarantVaikui;
            action += SpalvosKeitimas;
            AntraForma forma = new AntraForma(action);
            forma.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void UzsidarantVaikui()
        {
            WindowState = FormWindowState.Normal;
        }

        private void SpalvosKeitimas()
        {
            BackColor = Color.Red;
        }
    }
}
