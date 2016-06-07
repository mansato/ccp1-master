using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Adresse
    {
        public int id_adresse { get; set; }
        public string adresse { get; set; }
        public string code_postal { get; set; }
        public string ville { get; set; }

        public Adresse() { }

        public Adresse(string add, string cp, string ville)
        {
            this.adresse = add;
            this.code_postal = cp;
            this.ville = ville;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
