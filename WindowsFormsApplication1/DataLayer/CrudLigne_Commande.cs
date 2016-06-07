using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ModelLayer;

namespace DataLayer
{
    public class CrudLigne_Commande
    {
        public static void AjoutLignecom(Produit produit,Ligne_commande ligcom)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertion_Lignecommande";
                    SqlParameter produit_nom = new SqlParameter("@produit", SqlDbType.NVarChar);
                    produit_nom.Direction = ParameterDirection.Input;
                    produit_nom.Value = produit.libelle;
                    cmd.Parameters.Add(produit_nom);
                    SqlParameter produit_qte = new SqlParameter("@qte", SqlDbType.Int);
                    produit_qte.Direction = ParameterDirection.Input;
                    produit_qte.Value = ligcom.qte_produit;
                    cmd.Parameters.Add(produit_qte);
                     cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
