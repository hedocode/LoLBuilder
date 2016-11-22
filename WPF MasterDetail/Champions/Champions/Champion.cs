using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Champion
    {
        public String Nom { get; set; }
        public String Desc { get; set; }
        public String Role { get; set; }
        public String Image { get; set; }
        public String ID { get; set; }
        public int Prix { get; set; }

        public ObservableCollection<Sort> sorts { get; set; } = new ObservableCollection<Sort>();

        public int Vitesse { get; set; }
        public int Critique { get; set; }
        public int PeneArmure { get; set; }
        public int PercentPeneA { get; set; }
        public int PeneMagique { get; set; }
        public int PercentPeneM { get; set; }

        public float Sante { get; set; }
        public float RegeSante { get; set; }
        public float Mana { get; set; }
        public float RegeMana { get; set; }

        public float Physique { get; set; }
        public float Magique { get; set; }
        public float Armure { get; set; }
        public float ResMagic { get; set; }
        public float VitAttak { get; set; }

        public float ProgSante { get; set; }
        public float ProgRegeSante { get; set; }
        public float ProgMana { get; set; }
        public float ProgRegeMana { get; set; }
        public float ProgPhysique { get; set; }
        public float ProgArmure { get; set; }
        public float ProgResMagic { get; set; }
        public float ProgVitAttak { get; set; }
        public float Range { get; set; }
        public float ProgRange { get; set; }

        public Champion() { }

        /*public override string ToString()
        {
            String msg;
            msg = Nom + "(" + Role + ")"+"\n";
            foreach(var v in sorts)
            {
                msg = msg + "\n" + v;
            }
            return msg;
        }*/
    }
}
