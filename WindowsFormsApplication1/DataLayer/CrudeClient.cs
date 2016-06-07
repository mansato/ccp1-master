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
   public class CrudeClient
    {
        public static void AjoutClient(Client client,Adresse adresse)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertion_client";
                    SqlParameter nom_client = new SqlParameter("@nom", SqlDbType.NVarChar);
                    nom_client.Direction = ParameterDirection.Input;
                    nom_client.Value = client.nom;
                    cmd.Parameters.Add(nom_client);
                    SqlParameter prenom_client = new SqlParameter("@prenom", SqlDbType.NVarChar);
                    prenom_client.Direction = ParameterDirection.Input;
                    prenom_client.Value = client.prenom;
                    cmd.Parameters.Add(prenom_client);
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
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Client lectureClient(string client)
        {
            Client clients = new Client();
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "select * from client where no_client=@cli ";
                    cmd.Parameters.Add(new SqlParameter("@cli", SqlDbType.Int)).Value = client;
                    cmd.Connection = conx;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            clients.code_client = (int)dr["NO_CLIENT"];
                            clients.nom= dr["NOM"].ToString();
                            clients.prenom= dr["PRENOM"].ToString();
                        }
                    }
                }
            }
            return clients;

        }
        public static void modifierAdresse(Adresse adresse)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "update adresse set adresse=@adresse,code_postal=@cp,ville=@ville where id_adresse=@ida";
                    cmd.Parameters.Add(new SqlParameter("@ida", SqlDbType.Int)).Value = adresse.id_adresse;
                    cmd.Parameters.Add(new SqlParameter("@adresse", SqlDbType.NVarChar)).Value = adresse.adresse;
                    cmd.Parameters.Add(new SqlParameter("@cp", SqlDbType.NVarChar)).Value = adresse.code_postal;
                    cmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.NVarChar)).Value = adresse.ville;
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public static List<Client> listClient()
        {
            List<Client> listeClient = new List<Client>();
            Client client;
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                                       
                    cmd.CommandText = "select * from select_client";

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            client = new Client();
                            client.id_adresse = (int)dr["no_client"];
                            client.nom = dr["nom"].ToString();
                            client.prenom = dr["prenom"].ToString();
                            listeClient.Add(client);
                        }
                    }
                }
            }
            return listeClient;
        }

        public static void deleteAdresse(string add)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = " delete from adresse where id_adresse= @ida";
                    cmd.Parameters.Add(new SqlParameter("@ida", SqlDbType.Int)).Value = add;
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
