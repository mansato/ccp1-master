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
  public class CrudProduit
    {
        public static void AjoutProduit(Produit produit)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "insert into produit values (@libelle,@pu)";
                    cmd.Parameters.Add(new SqlParameter("@libelle", SqlDbType.NVarChar)).Value = produit.libelle ;
                    cmd.Parameters.Add(new SqlParameter("@pu", SqlDbType.Decimal)).Value = produit.prix ;
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Produit> lectureProduit(string prod)
        {
            List<Produit> listeProduit = new List<Produit>();
            Produit produit;            
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "select * from produit where libelle like '%"+prod+"%' ";
                    cmd.Connection = conx;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            produit =  new Produit();
                            produit.code_produit = (int)dr["code_produit"];
                            produit.libelle = dr["libelle"].ToString();
                            produit.prix = (decimal)dr["prix_u"];
                            listeProduit.Add(produit);
                        }
                    }
                }
            }
            return listeProduit;

        }
        public static void modifierProduit(Produit produit)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "update produit set libelle=@lib,prix_u=@pu where code_produit=@prod";
                    cmd.Parameters.Add(new SqlParameter("@prod", SqlDbType.Int)).Value = produit.code_produit;
                    cmd.Parameters.Add(new SqlParameter("@lib", SqlDbType.NVarChar)).Value = produit.libelle;
                    cmd.Parameters.Add(new SqlParameter("@pu", SqlDbType.Decimal)).Value = produit.prix;
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public static List<Produit> listProduit()
        {
            List<Produit> listeProduit = new List<Produit>();
            Produit produit;
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    
                    cmd.CommandText = "select * from select_produit()";

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            produit = new Produit();
                            produit.code_produit = (int)dr["code_produit"];
                            produit.libelle = dr["libelle"].ToString();
                            produit.prix = (decimal)dr["prix_u"];
                            listeProduit.Add(produit);
                        }
                    }
                }
            }
            return listeProduit;
        }

        public static void deleteProduit(string prod)
        {
            using (SqlConnection conx = ConnectionDB.getConnection())
            {
                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = " delete from produit where code_produit= @prod";
                    cmd.Parameters.Add(new SqlParameter("@prod", SqlDbType.Int)).Value = prod;
                    cmd.Connection = conx;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
