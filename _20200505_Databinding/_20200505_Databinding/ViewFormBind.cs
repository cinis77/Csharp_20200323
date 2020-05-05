using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _20200505_Databinding
{
    public class ViewFormBind : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

		private string _Tekstas;

		public string Tekstas
		{
			get 
			{ 
				return _Tekstas; 
			}
			set 
			{
				if (value != _Tekstas)
				{
					_Tekstas = value;
					if (_Tekstas.ToCharArray().Count() > 5)
					{
						BindColor = Color.Green;
					}
					else
					{
						BindColor = Color.Red;
					}
					NotifyAboutChange("Tekstas");
				}
			}
		}

		private Color _BindColor;

		public Color BindColor
		{
			get 
			{ 
				return _BindColor; 
			}
			set 
			{
				if (value != _BindColor)
				{
					_BindColor = value;
					NotifyAboutChange("BindColor");
				}
			}
		}


		private void NotifyAboutChange(string info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}

	}
}
