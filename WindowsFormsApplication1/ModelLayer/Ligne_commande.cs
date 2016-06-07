using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class Ligne_commande
    {
        public int id_ligne { get; set; }
        public int no_commande { get; set; }
        public int qte_produit { get; set; }

        public Ligne_commande() { }

        public Ligne_commande(int qte)
        {
            this.qte_produit = qte;
          
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
