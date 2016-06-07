using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BuisnessLayer
{
   public class CommandeOperation
    {
        public static void ajoutCommande(Commande commande,Client client, Adresse adresse)
        {
            DataLayer.CrudCommande.AjoutCommande(commande, client, adresse);
        }
        public static void ajoutCommande2(Commande commande, Client client, Adresse adresse)
        {
            DataLayer.CrudCommande.AjoutCommande2(commande, client, adresse);
        }

    }
}
