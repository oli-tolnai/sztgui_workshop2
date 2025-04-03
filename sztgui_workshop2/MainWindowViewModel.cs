using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace sztgui_workshop2
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int avgHumanStrength;
        private int avgMutantStrength;

        public BindingList<SuperHero> HumanSuperHeroes { get; set; } = new BindingList<SuperHero>();

        public BindingList<SuperHero> MutantSuperHeroes { get; set; } = new BindingList<SuperHero>();


        public int AvgHumanStrength
        {
            get { return avgHumanStrength; }
            set {
                if (avgHumanStrength != value)
                {
                    avgHumanStrength = value;
                    OnPropertyChanged(nameof(AvgHumanStrength));
                }
            }
        }

        public int AvgMutantStrength
        {
            get { return avgMutantStrength; }
            set {
                if (avgMutantStrength != value)
                {
                    avgMutantStrength = value;
                    OnPropertyChanged(nameof(AvgMutantStrength));
                }
            }
        }


        public MainWindowViewModel()
        {
            this.HumanSuperHeroes = new BindingList<SuperHero>()
            {
                new SuperHero() { Name = "Batman", Strength = 30, Speed = 50, IsMutant = false },
                new SuperHero() { Name = "Superman", Strength = 20, Speed = 30, IsMutant = false },
                new SuperHero() { Name = "Spiderman", Strength = 50, Speed = 20, IsMutant = false }
            };
            this.MutantSuperHeroes = new BindingList<SuperHero>()
            {
                new SuperHero() { Name = "Wolverine", Strength = 90, Speed = 10, IsMutant = true },
                new SuperHero() { Name = "Storm", Strength = 85, Speed = 35, IsMutant = true },
                new SuperHero() { Name = "Cyclops", Strength = 80, Speed = 25, IsMutant = true }
            };
        }



        public void AddHero(SuperHero hero)
        {
            if (hero.IsMutant)
            {
                MutantSuperHeroes.Add(hero);
                AvgMutantStrength = (int)MutantSuperHeroes.Average(h => h.Strength);
            }
            else
            {
                HumanSuperHeroes.Add(hero);
                AvgHumanStrength = (int)HumanSuperHeroes.Average(h => h.Strength);
            }
        }

        public void SpeedUpHero(SuperHero hero)
        {
            if (hero.IsMutant)
            {
                hero.Speed += 10;
                AvgMutantStrength = (int)MutantSuperHeroes.Average(h => h.Strength);
            }
        }

        public void RemoveHero(SuperHero hero)
        {
            if (hero.IsMutant)
            {
                MutantSuperHeroes.Remove(hero);
                AvgMutantStrength = (int)MutantSuperHeroes.Average(h => h.Strength);
            }
            else
            {
                HumanSuperHeroes.Remove(hero);
                AvgHumanStrength = (int)HumanSuperHeroes.Average(h => h.Strength);
            }
        }









        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
