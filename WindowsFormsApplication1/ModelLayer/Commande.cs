using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class Commande
    {
        public int no_commande { get; set; }
        public int no_client { get; set; }
        public int id_adresse { get; set; }
        public DateTime date { get; set; }

        public Commande() { }

        public Commande(DateTime date)
        {
            this.date = date;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
