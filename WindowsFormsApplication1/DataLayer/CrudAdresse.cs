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
   public class CrudAdresse
    {
        public static void AjoutAdresse(Adresse adresse)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "insert into adresse values (@adresse,@cp,@ville)";
                    cmd.Parameters.Add(new SqlParameter("@adresse", SqlDbType.NVarChar)).Value = adresse.adresse;
                    cmd.Parameters.Add(new SqlParameter("@cp", SqlDbType.NVarChar)).Value = adresse.code_postal;
                    cmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.NVarChar)).Value = adresse.ville;
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Adresse lectureAdresse(string add)
        {
            Adresse adresse = new Adresse();
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "select ADRESSE,CODE_POSTAL,VILLE from client join ADRESSE on CLIENT.ID_ADRESSE=ADRESSE.ID_ADRESSE where client.NOM =@ida ";
                    cmd.Parameters.Add(new SqlParameter("@ida", SqlDbType.NVarChar)).Value = add;
                    cmd.Connection = conx;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            adresse.adresse = dr["adresse"].ToString();
                            adresse.code_postal = dr["code_postal"].ToString();
                            adresse.ville = dr["ville"].ToString();
                        }
                    }
                }
            }
            return adresse;

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

        public static List<Adresse> listAdresse()
        {
            List<Adresse> listeAdresse = new List<Adresse>();
            Adresse adresse;
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "select * from adresse";

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            adresse = new Adresse();
                            adresse.id_adresse = (int)dr["id_adresse"];
                            adresse.adresse = dr["adresse"].ToString();
                            adresse.code_postal = dr["code_postal"].ToString();
                            adresse.ville = dr["ville"].ToString();
                            listeAdresse.Add(adresse);
                        }
                    }
                }
            }
            return listeAdresse;
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
