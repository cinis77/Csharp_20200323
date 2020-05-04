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
    public partial class AntraForma : Form
    {
        private Action BeUzsidarant;

        public AntraForma(Action beuzsidarant, Form1 tevas)
        {
            BeUzsidarant = beuzsidarant;
            InitializeComponent();
        }

        private void AntraForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            BeUzsidarant();
        }
    }
}
