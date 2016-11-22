using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ObjetListe
    {
        public ObservableCollection<Objet> objets { get; private set; } = new ObservableCollection<Objet>();

        public ObjetListe()
        {
            Chargement();
        }

        private void Chargement()
        {
            String current = Environment.CurrentDirectory;
            int nb = 0;
            Objet c;

            StreamReader file = new StreamReader(current+@"\objets.txt");

            if ((nb = Convert.ToInt32(file.ReadLine())) == 0)
            {
                return;
            }
            for (int i = 0; i < nb; i++)
            {
                c = new Objet();
                c.Nom = file.ReadLine();
                c.Image = file.ReadLine();
                c.ID = file.ReadLine();
                c.Prix = int.Parse(file.ReadLine());
                c.Vitesse = int.Parse(file.ReadLine());
                c.Sante = float.Parse(file.ReadLine());
                c.RegeSante = float.Parse(file.ReadLine());
                c.Mana = float.Parse(file.ReadLine());
                c.RegeMana = float.Parse(file.ReadLine());
                c.Physique = float.Parse(file.ReadLine());
                c.Magique = float.Parse(file.ReadLine());
                c.VitAttak = float.Parse(file.ReadLine());
                c.Armure = float.Parse(file.ReadLine());
                c.ResMagic = float.Parse(file.ReadLine());
                c.Critique = int.Parse(file.ReadLine());
                c.PeneArmure = int.Parse(file.ReadLine());
                c.PercentPeneA = int.Parse(file.ReadLine());
                c.PeneMagique = int.Parse(file.ReadLine());
                c.PercentPeneM = int.Parse(file.ReadLine());
                c.ReductionDelais = int.Parse(file.ReadLine());
                c.Passif = file.ReadLine();
                c.Actif = file.ReadLine();
                objets.Add(c);
            }
            file.Close();
        }

        /*public override string ToString()
        {
            String msg = "";
            foreach (var v in objets)
            {
                msg = msg + v + "\n";
            }
            return msg;
        }*/
    }
}
