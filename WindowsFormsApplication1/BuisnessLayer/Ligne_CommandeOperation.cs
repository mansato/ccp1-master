using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BuisnessLayer
{
   public class Ligne_CommandeOperation
    {
        public static void ajoutlignecom(Produit produit, Ligne_commande ligncom)
        {
            DataLayer.CrudLigne_Commande.AjoutLignecom(produit, ligncom);
        }
    }
}
