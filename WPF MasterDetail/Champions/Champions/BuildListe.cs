using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BuildListe
    {
        public ChampionListe champList { get; set; } = new ChampionListe();
        public ObjetListe objList { get; set; } = new ObjetListe();
        public ObservableCollection<Build> Builds { get; set; } = new ObservableCollection<Build>();

        public BuildListe()
        {
            Chargement();
        }

        private void Chargement()
        {
            Build b;
            String current = Environment.CurrentDirectory;
            StreamReader file = new StreamReader(current + @"/build.txt");
            String ID;
            int nb = int.Parse(file.ReadLine());
            for (int i = 0; i < nb ; i++)
            {
                b = new Build();
                b.Nom = file.ReadLine();
                ID = file.ReadLine();
                foreach (var v in champList.champions)
                {
                    if (v.ID.Equals(ID)) { b.Hero = v; b.Image = v.Image; }
                }
                for(int j = 0; j < 6; j++)
                {
                    ID = file.ReadLine();
                    foreach(var v in objList.objets)
                    {
                        if (v.ID.Equals(ID)) { b.Ajout(v); }
                    }
                }
                Builds.Add(b);
            }
        }

        public void Sauvegarde()
        {
            String current = Environment.CurrentDirectory;
            List<String> text = new List<string>();
            text.Add(""+Builds.Count());
            foreach (var v in Builds)
            {
                text.Add(v.Nom);
                text.Add(v.Hero.ID);
                foreach(var s in v.Stack)
                {
                    text.Add(s.ID);
                }
            }
            if (File.Exists(current+@"\build.txt")) { File.Delete(current + @"\build.txt"); }
            File.AppendAllLines(current + @"\build.txt", text);
        }

        /*public override string ToString()
        {
            String msg = "";
            foreach(var v in Builds)
            {
                msg = msg + v + "\n";
            }
            return msg;
        }*/
    }
}
