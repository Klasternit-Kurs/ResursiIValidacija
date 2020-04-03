using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResursiIValidacija
{
	public class Osoba : INotifyPropertyChanged
	{
		private string ime;
		public string Ime 
		{ 
			get => ime;

			set
			{
				ime = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ime"));
			}
		}

		private int godine = 20;
		public int Godine
		{
			get => godine;

			set
			{
				godine = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Godine"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public override string ToString() => Ime;
		public Osoba(string i)
		{
			Ime = i;
		}
		public Osoba() { }
	}
}
