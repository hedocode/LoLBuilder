using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Build : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public String Nom { get; set; }
        private Champion hero;
        public int Prix { get; set; } = 0;
        public string Image { get; set; }
        public Champion Hero
        {
            get { return hero; }
            set { hero = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Objet> Stack { get; set; } = new ObservableCollection<Objet>();

        public Build() { }

        private void OnPropertyChanged ([CallerMemberName]String PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public void Ajout(Objet o)
        {
            Hero.Armure += o.Armure;
            Hero.Critique += o.Critique;
            Hero.Magique += o.Magique;
            Hero.Mana += o.Mana;
            Hero.PeneArmure += o.PeneArmure;
            Hero.PeneMagique += o.PeneMagique;
            Hero.PercentPeneA += o.PercentPeneA;
            Hero.PercentPeneM += o.PercentPeneM;
            Hero.Physique += o.Physique;
            Hero.ResMagic += o.ResMagic;
            Hero.Sante += o.Sante;
            Hero.Vitesse += o.Vitesse;
            Hero.VitAttak += (Hero.VitAttak * (o.VitAttak / 100));
            Hero.RegeMana += (Hero.RegeMana * (o.RegeMana / 100));
            Hero.RegeSante += (Hero.RegeSante * (o.RegeSante / 100));
            Prix += o.Prix;
            Stack.Add(o);
        }
    }
}
