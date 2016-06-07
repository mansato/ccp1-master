using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BuisnessLayer
{
   public class AdresseOperation
    {
        public static Adresse  lireAdresse(string cli)
        {
            Adresse adresse = new Adresse();
            adresse = CrudAdresse.lectureAdresse(cli);
            return adresse;
        }
    }
}
