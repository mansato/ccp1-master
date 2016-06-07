using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Produit
    {
        public int code_produit { get; set; }
        public string libelle { get; set; }
        public decimal prix { get; set; }

        public Produit() { }
        public Produit(string prod)
        {
            this.libelle = prod;
   
        }
        public Produit(int cp,string prod, decimal pu)
        {
            this.code_produit = cp;
            this.libelle = prod;
            this.prix = pu;
        }
        public Produit(string prod, decimal pu)
        {
            this.libelle = prod;
            this.prix = pu;
        }

        

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
