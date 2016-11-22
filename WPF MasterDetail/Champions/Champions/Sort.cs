using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Sort
    {
        public String Nom { get; set; }
        public String CoutM { get; set; }
        public String Desc { get; set; }
        public string Image { get; set; }
        public string Cooldown { get; set; }
        public int Ratio1 { get; set; }
        public int Ratio2 { get; set; }
        public int Ratio3 { get; set; }
        public int Ratio4 { get; set; }
        public Champion c { get; set; }

        public string SpellInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\t\t");
                sb.AppendLine(Nom);
                sb.Append("\t\t");
                sb.AppendLine(string.Format("Coût : {0}",CoutM));
                sb.Append("\t\t");
                sb.AppendLine(Cooldown);
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine(string.Format(Desc,Ratio1,Ratio2,Ratio3,Ratio4));
                return sb.ToString();
            }

        }

        public Sort() { }

        /*public override string ToString()
        {
            return Nom;
        }*/
    }
}
