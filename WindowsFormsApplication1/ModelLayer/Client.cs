using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Client
    {
        public int code_client { get; set; }
        public int id_adresse { get; set; }
        public string nom{ get; set; }
        public string prenom { get; set; }

        public Client() { }

        public Client( string nom, string pré)
        {
            this.nom = nom;
            this.prenom = pré;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
