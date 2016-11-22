using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Objet
    {
        public String Nom { get; set; }
        public String Image { get; set; }
        public String ID { get; set; }
        public int Prix { get; set; }

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
        public int ReductionDelais { get; set; }

        public string Passif { get; set; }
        public string Actif { get; set; }

        public string StatsInfo
        {
            get
            {
                StringBuilder sb= new StringBuilder();
                if (Vitesse!=0)
                {
                    sb.AppendLine(String.Format("Vitesse de déplacement : {0}",Vitesse));
                }
                if (Critique!=0)
                {
                    sb.AppendLine(String.Format("Chances de Critique : {0}%", Critique));
                }
                if (PeneArmure != 0)
                {
                    sb.AppendLine(String.Format("Penetration d'armure : {0}", PeneArmure));
                }
                if (PercentPeneA != 0)
                {
                    sb.AppendLine(String.Format("Penetration d'armure : {0}%", PercentPeneA));
                }
                if (PeneMagique != 0)
                {
                    sb.AppendLine(String.Format("Penetration Magique : {0}", PeneMagique));
                }
                if (PercentPeneM!= 0)
                {
                    sb.AppendLine(String.Format("Penetration Magique : {0}%", PercentPeneM));
                }
                if (Sante != 0)
                {
                    sb.AppendLine(String.Format("PV : {0}", Sante));
                }
                if (RegeSante != 0)
                {
                    sb.AppendLine(String.Format("Regenération de PV: {0}", RegeSante));
                }
                if (Mana != 0)
                {
                    sb.AppendLine(String.Format("Mana : {0}", Mana));
                }
                if (RegeMana != 0)
                {
                    sb.AppendLine(String.Format("RegeMana : {0}", RegeMana));
                }
                if (Physique != 0)
                {
                    sb.AppendLine(String.Format("Physique : {0}", Physique));
                }
                if (Magique != 0)
                {
                    sb.AppendLine(String.Format("Puissance : {0}", Magique));
                }
                if (Armure != 0)
                {
                    sb.AppendLine(String.Format("Armure : {0}", Armure));
                }
                if (ResMagic != 0)
                {
                    sb.AppendLine(String.Format("Resistace Magique: {0}", ResMagic));
                }
                if (VitAttak != 0)
                {
                    sb.AppendLine(String.Format("Vitesse d'attaque : {0}%", VitAttak));
                }
                if (Passif != null)
                {
                    sb.AppendLine(Passif);
                }
                if (Actif != null)
                {
                    sb.AppendLine(Actif);
                }
                return sb.ToString();
            }
        }

        public Objet() { }

        /*public override string ToString()
        {
            return Nom + "\t" + ID;
        }*/
    }
}
