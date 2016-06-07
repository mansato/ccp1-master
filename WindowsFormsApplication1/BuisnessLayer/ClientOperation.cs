using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BuisnessLayer
{
    public class ClientOperation
    {

        public static void ajoutclient(Client client,Adresse adresse)
        {
            DataLayer.CrudeClient.AjoutClient(client, adresse);
        }

        public static Client lireNomClient(string cli)
        {
            Client client = new Client();
            client = CrudeClient.lectureClient(cli);
            return client;
        }

        public static List<Client> lireNomClients()
        {
            List<Client> mesclient = new List<Client>();
            mesclient = CrudeClient.listClient();
            return mesclient;
        }
    }
}
