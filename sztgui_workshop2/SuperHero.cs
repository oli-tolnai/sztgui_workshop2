using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sztgui_workshop2
{
    public class SuperHero : INotifyPropertyChanged
    {
		private string name;

		private int strength;

		private int speed;

		private bool isMutant;

		public bool IsMutant
		{
			get { return isMutant; }
			set { isMutant = value; OnPropertyChanged(); }
		}


		public int Speed
		{
			get { return speed; }
			set { speed = value; OnPropertyChanged(); }
		}


		public int Strength
		{
			get { return strength; }
			set { strength = value; OnPropertyChanged(); }
		}


		public string Name
		{
			get { return name; }
			set { name = value; OnPropertyChanged(); }
		}

        public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?
				.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
