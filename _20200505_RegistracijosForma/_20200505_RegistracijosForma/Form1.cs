using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200505_RegistracijosForma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindingClass bind = new BindingClass();
            VartotojoVardas.DataBindings.Add("Text", bind, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            VartotojoVardas.DataBindings.Add("ForeColor", bind, "ForUserColor");
            SlaptazodisTekstas.DataBindings.Add("Text", bind, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            SlaptazodisTekstas.DataBindings.Add("ForeColor", bind, "ForePassword");
            EmailText.DataBindings.Add("Text", bind, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            EmailText.DataBindings.Add("ForeColor", bind, "ForeEmail");

        }
    }
}
