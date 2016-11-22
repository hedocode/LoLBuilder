using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Data
{
    public class ChampionListe
    {
        public ObservableCollection<Champion> champions { get; private set; } = new ObservableCollection<Champion>();

        public ChampionListe()
        {
            Chargement();
        }

        private void Chargement()
        {
            String current = Environment.CurrentDirectory;
            String path = current+@"\champions.txt";
            int nb = 0;
            Champion c;

            StreamReader file = new StreamReader(path);

            if((nb = Convert.ToInt32(file.ReadLine())) == 0)
            {
                return;
            }
            for(int i =0; i < nb; i++)
            {
                c = new Champion();
                c.Nom = file.ReadLine();
                c.Desc = file.ReadLine();
                c.Role = file.ReadLine();
                c.Image = file.ReadLine();
                c.ID = file.ReadLine();
                c.Prix = int.Parse(file.ReadLine());
                c.Vitesse = int.Parse(file.ReadLine());
                c.Sante = float.Parse(file.ReadLine());
                c.ProgSante = float.Parse(file.ReadLine());
                c.RegeSante = float.Parse(file.ReadLine());
                c.ProgRegeSante = float.Parse(file.ReadLine());
                c.Mana = float.Parse(file.ReadLine());
                c.ProgMana = float.Parse(file.ReadLine());
                c.RegeMana = float.Parse(file.ReadLine());
                c.ProgRegeMana = float.Parse(file.ReadLine());
                c.Physique = float.Parse(file.ReadLine());
                c.ProgPhysique = float.Parse(file.ReadLine());
                c.Magique = float.Parse(file.ReadLine());
                c.VitAttak = float.Parse(file.ReadLine());
                c.ProgVitAttak = float.Parse(file.ReadLine());
                c.Armure = float.Parse(file.ReadLine());
                c.ProgArmure = float.Parse(file.ReadLine());
                c.ResMagic = float.Parse(file.ReadLine());
                c.ProgResMagic = float.Parse(file.ReadLine());
                c.Critique = int.Parse(file.ReadLine());
                c.PeneArmure = int.Parse(file.ReadLine());
                c.PercentPeneA = int.Parse(file.ReadLine());
                c.PeneMagique = int.Parse(file.ReadLine());
                c.PercentPeneM = int.Parse(file.ReadLine());
                c.Range = int.Parse(file.ReadLine());
                c.ProgRange = int.Parse(file.ReadLine());
                Sort s;
                for (int j = 0; j < 5; j++) {
                    s = new Sort();
                    s.Nom = file.ReadLine();
                    s.CoutM = file.ReadLine();
                    s.Desc = file.ReadLine();
                    s.Image = file.ReadLine();
                    s.Cooldown = file.ReadLine();
                    s.Ratio1 = int.Parse(file.ReadLine());
                    s.Ratio2 = int.Parse(file.ReadLine());
                    s.Ratio3 = int.Parse(file.ReadLine());
                    s.Ratio4 = int.Parse(file.ReadLine());
                    s.c = c;
                    c.sorts.Add(s);
                }
                champions.Add(c);
            }
            file.Close();
        }

        /*public override string ToString()
        {
            String msg = "";
            foreach(var v in champions)
            {
                msg = msg + "\n" + v;
            }
            return msg;
        }*/
    }
}
