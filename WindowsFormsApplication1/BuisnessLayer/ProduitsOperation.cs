using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
namespace BuisnessLayer
{
   public class ProduitsOperation
    {

        public static void ajoutproduit(Produit produit)
        {
            CrudProduit.AjoutProduit(produit);
        }

        public static List<Produit> lireproduit(string cli)
        {
       
           
       
            return CrudProduit.lectureProduit(cli);
        }

        public static List<Produit> lireproduits()
        {
            List<Produit> mesproduit = new List<Produit>();
            mesproduit = CrudProduit.listProduit();
            return mesproduit;
        }

        public static void updateproduit(Produit produit)
        {
            CrudProduit.modifierProduit(produit);          
        }
        public static void deleteproduit(string prod)
        {
            CrudProduit.deleteProduit(prod);
        }
    }
}
