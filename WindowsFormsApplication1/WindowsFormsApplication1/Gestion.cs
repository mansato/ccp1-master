using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLayer;
using BuisnessLayer;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {   dataGridView2.Rows.Clear();
           List<Produit> list_produit =  ProduitsOperation.lireproduit(textBox_lib.Text);
            foreach (var item in list_produit)
            {
                dataGridView2.Rows.Add(item.code_produit, item.libelle, item.prix);
            }
            
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_add_client_Click(object sender, EventArgs e)
        {
            Regex a = new Regex(@"^(([0-8][0-9])|(9[0-5])|(2[ab]))[0-9]{3}$");
            if (!a.IsMatch(textBox_cp.Text))
            {
                MessageBox.Show("Erreur sur le Code Postal");
                this.textBox_cp.Focus();
            }
            else
            {
                ModelLayer.Client client = new Client(textBox_nom.Text, textBox_prenom.Text);
                ModelLayer.Adresse addresse = new Adresse(textBox_adresse.Text, textBox_cp.Text, textBox_ville.Text);
                ClientOperation.ajoutclient(client, addresse);
                textBox_nom.Clear();
                textBox_prenom.Clear();
                textBox_adresse.Clear();
                textBox_cp.Clear();
                textBox_ville.Clear();
                comboBox_client.Items.Clear();
                foreach (var item in ClientOperation.lireNomClients())
                {
                    comboBox_client.Items.Add(item.nom);
                }
            }
        }

        private void button_add_prod_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit(textBox_libelle.Text,Convert.ToDecimal(textBox_prixu.Text));
            ProduitsOperation.ajoutproduit(produit);
            textBox_prixu.Clear();
            textBox_libelle.Clear();
            dataGridView1.Rows.Clear();
            foreach (var item in ProduitsOperation.lireproduits())
            {
                dataGridView1.Rows.Add(item.code_produit,item.libelle,item.prix);
            }

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            foreach (var item in ProduitsOperation.lireproduits())
            {
                dataGridView1.Rows.Add(item.code_produit, item.libelle, item.prix);
            }
            foreach (var item in ClientOperation.lireNomClients())
            {
                comboBox_client.Items.Add(item.nom);
            }
            radioButton7.Checked = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button_com.Visible = true;
            button_com_2.Visible = false;
            textBox_add_liv.Enabled = false;

            textBox_cp_liv.Enabled = false;

            textBox_ville_liv.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox_add_liv.Clear();

            textBox_cp_liv.Clear();

            textBox_ville_liv.Clear();
            button_com.Visible = false;
            button_com_2.Visible = true;

            textBox_add_liv.Enabled = true;

            textBox_cp_liv.Enabled = true;

            textBox_ville_liv.Enabled = true;
        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adresse adresse = AdresseOperation.lireAdresse(comboBox_client.SelectedItem.ToString());
            textBox_add_liv.Text = adresse.adresse.ToString();
            textBox_cp_liv.Text = adresse.code_postal.ToString();
            textBox_ville_liv.Text = adresse.ville.ToString();
        }

        private void button_add_com_Click(object sender, EventArgs e)
        {
           
            Regex a = new Regex(@"^[1-9]|[1-9]{$");
            if (!a.IsMatch(textBox_nb_art.Text))
            {
                MessageBox.Show("Erreur sur le nb article");
                this.textBox_nb_art.Focus();
            }
            else {
                int index = dataGridView2.CurrentRow.Index;
                string code_art = dataGridView2[0, index].Value.ToString();
                string libelle = dataGridView2[1, index].Value.ToString();
                string prixu = dataGridView2[2, index].Value.ToString();
                
                int b = dataGridView3.Rows.Count;
                if (b == 0)
                {
                    dataGridView3.Rows.Add(code_art, libelle, prixu, textBox_nb_art.Text);
                }
                else
                {
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[index].Cells[1].Value.ToString() == dataGridView3.Rows[i].Cells[1].Value.ToString())
                        {
                            int qte = Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value.ToString());
                            int c = qte + Convert.ToInt32(textBox_nb_art.Text);
                            dataGridView3.Rows.Add(code_art, libelle, prixu, c);
                            dataGridView3.Rows.RemoveAt(i);
                            return;
                        }
                    }
                    dataGridView3.Rows.Add(code_art, libelle, prixu, textBox_nb_art.Text);                    
                }

            }
        }

        private void button_com_Click(object sender, EventArgs e)
        {

            ModelLayer.Client client = new Client(comboBox_client.SelectedItem.ToString(),textBox_prenom.Text);
            ModelLayer.Adresse addresse = new Adresse(textBox_add_liv.Text, textBox_cp_liv.Text, textBox_ville_liv.Text);
            ModelLayer.Commande commande = new Commande(dateTimePicker1.Value);
            CommandeOperation.ajoutCommande(commande,client,addresse);

            int a = dataGridView3.Rows.Count;
            for (int i = 0; i < a ; i++)
            {
                string libelle = dataGridView3[1, i].Value.ToString();
                int qte =Convert.ToInt32(dataGridView3[3, i].Value.ToString());
                Ligne_commande ligncom = new Ligne_commande(qte);
                Produit produit = new Produit(libelle);
                Ligne_CommandeOperation.ajoutlignecom(produit,ligncom);
            }
            dataGridView3.Rows.Clear();
        }

        private void button_suppr_Click(object sender, EventArgs e)
        {
            int i = dataGridView3.CurrentRow.Index;
            dataGridView3.Rows.RemoveAt(i);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string codeart = dataGridView1[0, index].Value.ToString();
            string lib = dataGridView1[1, index].Value.ToString();
            string prixu = dataGridView1[2, index].Value.ToString();
            textBox1.Text = codeart;
            textBox_libelle.Text = lib;
            textBox_prixu.Text = prixu;

        }

        private void buttonmodif_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit(Convert.ToInt32(textBox1.Text),textBox_libelle.Text,Convert.ToDecimal(textBox_prixu.Text));
            ProduitsOperation.updateproduit(produit);
            textBox_libelle.Clear();
            textBox_prixu.Clear();
            dataGridView1.Rows.Clear();
            foreach (var item in ProduitsOperation.lireproduits())
            {
                dataGridView1.Rows.Add(item.code_produit, item.libelle, item.prix);
            }
        }

        private void button_suprimer_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string valeur = dataGridView1[0, index].Value.ToString();
            ProduitsOperation.deleteproduit(valeur);
            dataGridView1.Rows.Clear();
            foreach (var item in ProduitsOperation.lireproduits())
            {
                dataGridView1.Rows.Add(item.code_produit, item.libelle, item.prix);
            }
        }

        private void button_com_2_Click(object sender, EventArgs e)
        {
            ModelLayer.Client client = new Client(comboBox_client.SelectedItem.ToString(), textBox_prenom.Text);
            ModelLayer.Adresse addresse = new Adresse(textBox_add_liv.Text, textBox_cp_liv.Text, textBox_ville_liv.Text);
            ModelLayer.Commande commande = new Commande(dateTimePicker1.Value);
            CommandeOperation.ajoutCommande2(commande, client, addresse);

            int a = dataGridView3.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                string libelle = dataGridView3[1, i].Value.ToString();
                int qte = Convert.ToInt32(dataGridView3[3, i].Value.ToString());
                Ligne_commande ligncom = new Ligne_commande(qte);
                Produit produit = new Produit(libelle);
                Ligne_CommandeOperation.ajoutlignecom(produit, ligncom);
            }
            dataGridView3.Rows.Clear();
            textBox_add_liv.Clear();
            textBox_cp_liv.Clear();
            textBox_ville_liv.Clear();
            comboBox_client.Text = "";
            radioButton7.Checked = true;
        }
    }
}
