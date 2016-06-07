namespace WindowsFormsApplication1
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_client = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_suprimer = new System.Windows.Forms.Button();
            this.buttonmodif = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add_prod = new System.Windows.Forms.Button();
            this.textBox_prixu = new System.Windows.Forms.TextBox();
            this.textBox_libelle = new System.Windows.Forms.TextBox();
            this.label_prix_u = new System.Windows.Forms.Label();
            this.label_LIBELLE = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_add_client = new System.Windows.Forms.Button();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_com_2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.textBox_lib = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ville_liv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_cp_liv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_nb_art = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_add_liv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add_com = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_com = new System.Windows.Forms.Button();
            this.button_suppr = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Code_Produit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIBELLE_com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_U_COM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Code_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_client.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_client
            // 
            this.tab_client.Controls.Add(this.tabPage1);
            this.tab_client.Controls.Add(this.tabPage2);
            this.tab_client.Controls.Add(this.tabPage3);
            this.tab_client.Location = new System.Drawing.Point(12, 39);
            this.tab_client.Name = "tab_client";
            this.tab_client.SelectedIndex = 0;
            this.tab_client.Size = new System.Drawing.Size(879, 646);
            this.tab_client.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button_suprimer);
            this.tabPage1.Controls.Add(this.buttonmodif);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button_add_prod);
            this.tabPage1.Controls.Add(this.textBox_prixu);
            this.tabPage1.Controls.Add(this.textBox_libelle);
            this.tabPage1.Controls.Add(this.label_prix_u);
            this.tabPage1.Controls.Add(this.label_LIBELLE);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PRODUIT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // button_suprimer
            // 
            this.button_suprimer.Location = new System.Drawing.Point(606, 376);
            this.button_suprimer.Name = "button_suprimer";
            this.button_suprimer.Size = new System.Drawing.Size(121, 67);
            this.button_suprimer.TabIndex = 8;
            this.button_suprimer.Text = "Suprimer";
            this.button_suprimer.UseVisualStyleBackColor = true;
            this.button_suprimer.Click += new System.EventHandler(this.button_suprimer_Click);
            // 
            // buttonmodif
            // 
            this.buttonmodif.Location = new System.Drawing.Point(380, 376);
            this.buttonmodif.Name = "buttonmodif";
            this.buttonmodif.Size = new System.Drawing.Size(121, 67);
            this.buttonmodif.TabIndex = 7;
            this.buttonmodif.Text = "Modifier";
            this.buttonmodif.UseVisualStyleBackColor = true;
            this.buttonmodif.Click += new System.EventHandler(this.buttonmodif_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(380, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 280);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code art";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "libelle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "prix u";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button_add_prod
            // 
            this.button_add_prod.Location = new System.Drawing.Point(132, 277);
            this.button_add_prod.Name = "button_add_prod";
            this.button_add_prod.Size = new System.Drawing.Size(148, 93);
            this.button_add_prod.TabIndex = 5;
            this.button_add_prod.Text = "AJOUTER";
            this.button_add_prod.UseVisualStyleBackColor = true;
            this.button_add_prod.Click += new System.EventHandler(this.button_add_prod_Click);
            // 
            // textBox_prixu
            // 
            this.textBox_prixu.Location = new System.Drawing.Point(132, 149);
            this.textBox_prixu.MaxLength = 50;
            this.textBox_prixu.Name = "textBox_prixu";
            this.textBox_prixu.Size = new System.Drawing.Size(148, 20);
            this.textBox_prixu.TabIndex = 4;
            // 
            // textBox_libelle
            // 
            this.textBox_libelle.Location = new System.Drawing.Point(132, 90);
            this.textBox_libelle.Name = "textBox_libelle";
            this.textBox_libelle.Size = new System.Drawing.Size(148, 20);
            this.textBox_libelle.TabIndex = 3;
            // 
            // label_prix_u
            // 
            this.label_prix_u.AutoSize = true;
            this.label_prix_u.Location = new System.Drawing.Point(17, 152);
            this.label_prix_u.Name = "label_prix_u";
            this.label_prix_u.Size = new System.Drawing.Size(86, 13);
            this.label_prix_u.TabIndex = 2;
            this.label_prix_u.Text = "PRIX UNITAIRE";
            // 
            // label_LIBELLE
            // 
            this.label_LIBELLE.AutoSize = true;
            this.label_LIBELLE.Location = new System.Drawing.Point(17, 93);
            this.label_LIBELLE.Name = "label_LIBELLE";
            this.label_LIBELLE.Size = new System.Drawing.Size(49, 13);
            this.label_LIBELLE.TabIndex = 1;
            this.label_LIBELLE.Text = "LIBELLE";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_add_client);
            this.tabPage2.Controls.Add(this.textBox_ville);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_cp);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_adresse);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_prenom);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox_nom);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLIENT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_add_client
            // 
            this.button_add_client.Location = new System.Drawing.Point(160, 332);
            this.button_add_client.Name = "button_add_client";
            this.button_add_client.Size = new System.Drawing.Size(160, 106);
            this.button_add_client.TabIndex = 10;
            this.button_add_client.Text = "AJOUTER";
            this.button_add_client.UseVisualStyleBackColor = true;
            this.button_add_client.Click += new System.EventHandler(this.button_add_client_Click);
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(160, 252);
            this.textBox_ville.MaxLength = 50;
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(160, 20);
            this.textBox_ville.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ville";
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(160, 196);
            this.textBox_cp.MaxLength = 5;
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.Size = new System.Drawing.Size(160, 20);
            this.textBox_cp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code Postal";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(160, 145);
            this.textBox_adresse.MaxLength = 50;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(160, 20);
            this.textBox_adresse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(160, 96);
            this.textBox_prenom.MaxLength = 50;
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(160, 20);
            this.textBox_prenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(160, 48);
            this.textBox_nom.MaxLength = 50;
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(160, 20);
            this.textBox_nom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_com_2);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.radioButton8);
            this.tabPage3.Controls.Add(this.radioButton7);
            this.tabPage3.Controls.Add(this.textBox_lib);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textBox_ville_liv);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox_cp_liv);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox_nb_art);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox_add_liv);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button_add_com);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBox_client);
            this.tabPage3.Controls.Add(this.button_rechercher);
            this.tabPage3.Controls.Add(this.button_com);
            this.tabPage3.Controls.Add(this.button_suppr);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(871, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "COMMANDE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_com_2
            // 
            this.button_com_2.Location = new System.Drawing.Point(710, 407);
            this.button_com_2.Name = "button_com_2";
            this.button_com_2.Size = new System.Drawing.Size(119, 150);
            this.button_com_2.TabIndex = 24;
            this.button_com_2.Text = "COMMANDER";
            this.button_com_2.UseVisualStyleBackColor = true;
            this.button_com_2.Click += new System.EventHandler(this.button_com_2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(629, 344);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(373, 300);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(103, 17);
            this.radioButton8.TabIndex = 22;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "adresse different";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(205, 300);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(91, 17);
            this.radioButton7.TabIndex = 21;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Adresse client";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // textBox_lib
            // 
            this.textBox_lib.Location = new System.Drawing.Point(157, 77);
            this.textBox_lib.MaxLength = 50;
            this.textBox_lib.Name = "textBox_lib";
            this.textBox_lib.Size = new System.Drawing.Size(100, 20);
            this.textBox_lib.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Libellé";
            // 
            // textBox_ville_liv
            // 
            this.textBox_ville_liv.Location = new System.Drawing.Point(486, 344);
            this.textBox_ville_liv.Name = "textBox_ville_liv";
            this.textBox_ville_liv.Size = new System.Drawing.Size(100, 20);
            this.textBox_ville_liv.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ville";
            // 
            // textBox_cp_liv
            // 
            this.textBox_cp_liv.Location = new System.Drawing.Point(373, 344);
            this.textBox_cp_liv.Name = "textBox_cp_liv";
            this.textBox_cp_liv.Size = new System.Drawing.Size(100, 20);
            this.textBox_cp_liv.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Code Postal";
            // 
            // textBox_nb_art
            // 
            this.textBox_nb_art.Location = new System.Drawing.Point(729, 137);
            this.textBox_nb_art.MaxLength = 50;
            this.textBox_nb_art.Name = "textBox_nb_art";
            this.textBox_nb_art.Size = new System.Drawing.Size(100, 20);
            this.textBox_nb_art.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nb d\'article";
            // 
            // textBox_add_liv
            // 
            this.textBox_add_liv.Location = new System.Drawing.Point(205, 345);
            this.textBox_add_liv.Name = "textBox_add_liv";
            this.textBox_add_liv.Size = new System.Drawing.Size(157, 20);
            this.textBox_add_liv.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adresse Livraison";
            // 
            // button_add_com
            // 
            this.button_add_com.Location = new System.Drawing.Point(710, 168);
            this.button_add_com.Name = "button_add_com";
            this.button_add_com.Size = new System.Drawing.Size(119, 112);
            this.button_add_com.TabIndex = 8;
            this.button_add_com.Text = "AJOUTER";
            this.button_add_com.UseVisualStyleBackColor = true;
            this.button_add_com.Click += new System.EventHandler(this.button_add_com_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Client";
            // 
            // comboBox_client
            // 
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(63, 344);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(121, 21);
            this.comboBox_client.TabIndex = 6;
            this.comboBox_client.SelectedIndexChanged += new System.EventHandler(this.comboBox_client_SelectedIndexChanged);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(445, 65);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(105, 43);
            this.button_rechercher.TabIndex = 5;
            this.button_rechercher.Text = "RECHERCHER";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_com
            // 
            this.button_com.Location = new System.Drawing.Point(710, 407);
            this.button_com.Name = "button_com";
            this.button_com.Size = new System.Drawing.Size(119, 150);
            this.button_com.TabIndex = 4;
            this.button_com.Text = "COMMANDER";
            this.button_com.UseVisualStyleBackColor = true;
            this.button_com.Click += new System.EventHandler(this.button_com_Click);
            // 
            // button_suppr
            // 
            this.button_suppr.Location = new System.Drawing.Point(241, 562);
            this.button_suppr.Name = "button_suppr";
            this.button_suppr.Size = new System.Drawing.Size(127, 52);
            this.button_suppr.TabIndex = 3;
            this.button_suppr.Text = "SUPPRIMER";
            this.button_suppr.UseVisualStyleBackColor = true;
            this.button_suppr.Click += new System.EventHandler(this.button_suppr_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_Produit2,
            this.LIBELLE_com,
            this.PRIX_U_COM,
            this.QTE});
            this.dataGridView3.Location = new System.Drawing.Point(17, 407);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(645, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // Code_Produit2
            // 
            this.Code_Produit2.HeaderText = "Code Produit";
            this.Code_Produit2.Name = "Code_Produit2";
            this.Code_Produit2.ReadOnly = true;
            // 
            // LIBELLE_com
            // 
            this.LIBELLE_com.HeaderText = "LIBELLE";
            this.LIBELLE_com.Name = "LIBELLE_com";
            this.LIBELLE_com.ReadOnly = true;
            // 
            // PRIX_U_COM
            // 
            this.PRIX_U_COM.HeaderText = "Prix Unitaire";
            this.PRIX_U_COM.Name = "PRIX_U_COM";
            this.PRIX_U_COM.ReadOnly = true;
            // 
            // QTE
            // 
            this.QTE.HeaderText = "QTE";
            this.QTE.Name = "QTE";
            this.QTE.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_Produit,
            this.Libelle,
            this.PRIX_U});
            this.dataGridView2.Location = new System.Drawing.Point(17, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(645, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // Code_Produit
            // 
            this.Code_Produit.HeaderText = "Code Produit";
            this.Code_Produit.Name = "Code_Produit";
            this.Code_Produit.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "LIBELLE";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // PRIX_U
            // 
            this.PRIX_U.HeaderText = "PRIX UNITAIRE";
            this.PRIX_U.Name = "PRIX_U";
            this.PRIX_U.ReadOnly = true;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 688);
            this.Controls.Add(this.tab_client);
            this.Name = "Gestion";
            this.Text = "Gestion_Commande";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.tab_client.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_client;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add_prod;
        private System.Windows.Forms.TextBox textBox_prixu;
        private System.Windows.Forms.TextBox textBox_libelle;
        private System.Windows.Forms.Label label_prix_u;
        private System.Windows.Forms.Label label_LIBELLE;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_cp_liv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_nb_art;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_add_liv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add_com;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_com;
        private System.Windows.Forms.Button button_suppr;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button_add_client;
        private System.Windows.Forms.TextBox textBox_ville_liv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_lib;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Produit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIBELLE_com;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_U_COM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_suprimer;
        private System.Windows.Forms.Button buttonmodif;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button_com_2;
    }
}

