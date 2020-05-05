using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200505_RegistracijosForma
{
    class BindingClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

		private string _userName;

		public string UserName
		{
			get 
			{ 
				return _userName; 
			}
			set 
			{
				if (value != _userName)
				{
					_userName = value;
					if (_userName.ToCharArray().Length < 6)
					{
						ForUserColor = Color.Red;
					}
					else
					{
						ForUserColor = Color.Black;
					}
					NotifyChange("UserName");
				}
			}
		}

		private Color _ForUserColor;

		public Color ForUserColor
		{
			get 
			{ 
				return _ForUserColor;
			}
			set 
			{
				if (value != _ForUserColor)
				{
					_ForUserColor = value;
					NotifyChange("ForUserColor");
				}
			}
		}

		private string _Password;

		public string PassWord
		{
			get 
			{ 
				return _Password; }

			set 
			{
				if (_Password != value)
				{
					_Password = value;
					if (_Password.ToCharArray().Length < 8)
					{
						ForePassword = Color.Red;
					}
					else
					{
						ForePassword = Color.Black;
					}	
					NotifyChange("Password");
				}
			}
		}

		private string _Email;

		public string Email
		{
			get 
			{ 
				return _Email; 
			}
			set 
			{
				if (_Email != value)
				{
					_Email = value;
					if (_Email.Contains("@") && _Email.Contains("."))
					{
						ForeEmail = Color.Black;
					}
					else
					{
						ForeEmail = Color.Red;
					}
					NotifyChange("Email");
				}
			}
		}

		private Color _ForeEmail;

		public Color ForeEmail
		{
			get 
			{ 
				return _ForeEmail; 
			}
			set 
			{
				if (value != _ForeEmail)
				{
					_ForeEmail = value;
					NotifyChange("ForeEmail");
				}
			}
		}



		private Color _ForeParsword;

		public Color ForePassword
		{
			get 
			{ 
				return _ForeParsword; 
			}
			set 
			{
				if (_ForeParsword != value)
				{
					_ForeParsword = value;
					NotifyChange("ForePassword");
				}
			}
		}




		private void NotifyChange(string info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}
	}
}
