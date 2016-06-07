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
   public class CrudCommande
    {
        public static void AjoutCommande(Commande commande,Client client, Adresse adresse)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertion_commande";
                    SqlParameter nom_client = new SqlParameter("@nom", SqlDbType.NVarChar);
                    nom_client.Direction = ParameterDirection.Input;
                    nom_client.Value = client.nom;
                    cmd.Parameters.Add(nom_client);
                    SqlParameter adresse_client = new SqlParameter("@adresse", SqlDbType.NVarChar);
                    adresse_client.Direction = ParameterDirection.Input;
                    adresse_client.Value = adresse.adresse;
                    cmd.Parameters.Add(adresse_client);
                    SqlParameter cp_client = new SqlParameter("@codepostal", SqlDbType.NVarChar);
                    cp_client.Direction = ParameterDirection.Input;
                    cp_client.Value = adresse.code_postal;
                    cmd.Parameters.Add(cp_client);
                    SqlParameter ville_client = new SqlParameter("@ville", SqlDbType.NVarChar);
                    ville_client.Direction = ParameterDirection.Input;
                    ville_client.Value = adresse.ville;
                    cmd.Parameters.Add(ville_client);
                    SqlParameter date_commande = new SqlParameter("@date", SqlDbType.DateTime);
                    date_commande.Direction = ParameterDirection.Input;
                    date_commande.Value = commande.date;
                    cmd.Parameters.Add(date_commande);
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void AjoutCommande2(Commande commande, Client client, Adresse adresse)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertion_commande2";
                    SqlParameter nom_client = new SqlParameter("@nom", SqlDbType.NVarChar);
                    nom_client.Direction = ParameterDirection.Input;
                    nom_client.Value = client.nom;
                    cmd.Parameters.Add(nom_client);
                    SqlParameter adresse_client = new SqlParameter("@adresse", SqlDbType.NVarChar);
                    adresse_client.Direction = ParameterDirection.Input;
                    adresse_client.Value = adresse.adresse;
                    cmd.Parameters.Add(adresse_client);
                    SqlParameter cp_client = new SqlParameter("@codepostal", SqlDbType.NVarChar);
                    cp_client.Direction = ParameterDirection.Input;
                    cp_client.Value = adresse.code_postal;
                    cmd.Parameters.Add(cp_client);
                    SqlParameter ville_client = new SqlParameter("@ville", SqlDbType.NVarChar);
                    ville_client.Direction = ParameterDirection.Input;
                    ville_client.Value = adresse.ville;
                    cmd.Parameters.Add(ville_client);
                    SqlParameter date_commande = new SqlParameter("@date", SqlDbType.DateTime);
                    date_commande.Direction = ParameterDirection.Input;
                    date_commande.Value = commande.date;
                    cmd.Parameters.Add(date_commande);
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
