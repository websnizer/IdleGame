using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace IdleGame
{
    public partial class FormJeu : Form
    {
        IdleGame m_idlegame; //Référence au créateur
        List<Bitmap> m_allstatusbar; //Toutes les images pour la status bar
        List<Bitmap> m_allcities; //Toutes les cities
        List<Bitmap> m_allcartes; //Toutes les cartes globale
        List<PictureBox> m_allhp; //Toutes les hp
        ExecIdleGame m_executeur; //L'Executeur de requête SQL
        int indimg; //Indice de l'image actuel
        int m_niv; //Le lvl du joueur
        int m_id; //Id du joueur
        
        //To delete: STATS
        int deaths = 0; //nombre de morts pendant la session
        int kills = 0; //nombre de kills pendant la session
        int sell = 0; //valeur des ventes $ pendant la session
        int COMPTEURTODELETE = 0; //Permet d'ajuster la vitesse de boucle

        Color offColor = Color.FromArgb(255, 70, 131);
        Color mainColor = Color.FromArgb(178, 34, 34);
        Color darkColor = Color.FromArgb(86, 27, 27);

        /**Initialisation de la form
         * p_idlegame : référence sur le contrôleur principal
         * p_id : le id du joueur
         */
        public FormJeu(IdleGame p_idlegame, int p_id)
        {
            //Initialisation des paramètres de bases
            m_id = p_id;
            m_idlegame = p_idlegame;
            InitializeComponent();
            mnu_main.Renderer = new MyRenderer();
            m_allstatusbar = new List<Bitmap>();
            m_allcities = new List<Bitmap>();
            m_allcartes = new List<Bitmap>();
            indimg = 0;
            m_niv = 0;
            m_executeur = new ExecIdleGame();
            RemplirListeStatusBar();
            RemplirListeCartes();
            RemplirListeVilles();
            RemplirListeHP();
            UpdateTout();
            AvancementBarre();
            pct_marchand.Parent = img_bg;
            lbl_hp.Parent = img_bg;
            pct_marchand.BackColor = Color.Transparent;
            lbl_info.Text = m_executeur.DoIt(m_id);
        }

        //Remplir le pannel des stats du perso(for, dex, con) du joueur
        private void RemplirStatsJoueur()
        {
            lst_persoStats.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurStats = m_executeur.joueurStatistiques(m_id);
            DataRow row = joueurStats.Rows[0];

            //Ajouter la Force dans le listview
            string For = (string)row["PerFor"];
            string[] statFor = { "FOR", For };
            var itemFor = new ListViewItem(statFor);
            lst_persoStats.Items.Add(itemFor);

            //Ajouter la Dexterite dans le listview
            string Dex = (string)row["PerDex"];
            string[] statDex = { "DEX", Dex };
            var itemDex = new ListViewItem(statDex);
            lst_persoStats.Items.Add(itemDex);

            //Ajouter la Constitution dans le listview
            string Con = (string)row["PerCon"];
            string[] statCon = { "CON", Con };
            var itemCon = new ListViewItem(statCon);
            lst_persoStats.Items.Add(itemCon);

            //Ajouter l'intelligence dans le listview
            string Int = (string)row["PerInt"];
            string[] statInt = { "INT", Int };
            var itemInt = new ListViewItem(statInt);
            lst_persoStats.Items.Add(itemInt);

            //Ajouter la Sagesse dans le listview
            string Sag = (string)row["PerSag"];
            string[] statSag = { "SAG", Sag };
            var itemSag = new ListViewItem(statSag);
            lst_persoStats.Items.Add(itemSag);

            //Ajouter le Charisme dans le listview
            string Cha = (string)row["PerCha"];
            string[] statCha = { "CHA", Cha };
            var itemCha = new ListViewItem(statCha);
            lst_persoStats.Items.Add(itemCha);

        }

        //Remplir le pannel des informations du perso
        private void RemplirInfoJoueur()
        {
            lst_persoInfo.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurInfos = m_executeur.joueurInformations(m_id);
            DataRow row = joueurInfos.Rows[0];

            //Nom
            string Nom = (string)row["PerNom"];
            string[] statNom = { "Nom", Nom };
            var itemNom = new ListViewItem(statNom);
            lst_persoInfo.Items.Add(itemNom);

            //Race
            string Race = (string)row["RacNom"];
            string[] statRace = { "Race", Race };
            var itemRace = new ListViewItem(statRace);
            lst_persoInfo.Items.Add(itemRace);

            //Classe
            string Classe = (string)row["ClaNom"];
            string[] statClasse = { "Classe", Classe };
            var itemClasse = new ListViewItem(statClasse);
            lst_persoInfo.Items.Add(itemClasse);

            //Ajouter les PV actuel dans le listview
            string PvActuel = (string)row["PerPvActuel"];
            string[] statPvActuel = { "PV", PvActuel };
            var itemPvActuel = new ListViewItem(statPvActuel);
            lst_persoInfo.Items.Add(itemPvActuel);

            //Ajouter les PV actuel dans le listview
            string PvMax = (string)row["PerPvMax"];
            string[] statPvMax = { "PV Max", PvMax };
            var itemPvMax = new ListViewItem(statPvMax);
            lst_persoInfo.Items.Add(itemPvMax);

            //Ajouter l'Energie Actuel dans le listview
            string Energie = (string)row["PerEnActuel"];
            string[] statEnergie = { "Energie", Energie };
            var itemEnergie = new ListViewItem(statEnergie);
            lst_persoInfo.Items.Add(itemEnergie);

            //Ajouter l'Energie Max dans le listview
            string EnergieMax = (string)row["PerEnMax"];
            string[] statEnergieMax = { "Energie Max", EnergieMax };
            var itemEnergieMax = new ListViewItem(statEnergieMax);
            lst_persoInfo.Items.Add(itemEnergieMax);

            //Ajouter la Difficulte dans le listview
            string Difficulte = (string)row["PerDifficulte"];
            string diffstr = (Difficulte == "1") ? "Normal" : "Hard";
            string[] statDifficulte = { "Difficulte", diffstr };
            var itemDifficulte = new ListViewItem(statDifficulte);
            lst_persoInfo.Items.Add(itemDifficulte);

            //Ajouter l'Expérience dans le listview
            string Exp = (string)row["PerExp"];
            string[] statExp = { "Expérience", Exp };
            var itemExp = new ListViewItem(statExp);
            lst_persoInfo.Items.Add(itemExp);

            //Ajouter le Niveau dans le listview
            string Niv = (string)row["PerNiv"];
            string[] statNiv = { "Niveau", Niv };
            var itemNiv = new ListViewItem(statNiv);
            lst_persoInfo.Items.Add(itemNiv);

            int niveau;
            Int32.TryParse((string)row["PerNiv"], out niveau);

            //Lorsqu'il monte de niveau
            if ((m_niv + 1) == niveau)
            {
                time_statusbar.Stop();
                FormChoixStat choixStat = new FormChoixStat(m_id);
                choixStat.ShowDialog();
                time_statusbar.Start();
                RemplirStatsJoueur();
                RemplirCompetences();
            }

            m_niv = niveau;

            //Ajouter le Niveau dans le listview
            string Cash = (string)row["PerArgent"];
            string[] statCash = { "Cash", Cash };
            var itemCash = new ListViewItem(statCash);
            lst_persoInfo.Items.Add(itemCash);

        }

        //Remplir le pannel des compétences du perso
        private void RemplirCompetences()
        {
            lst_persoCompetences.Items.Clear();
            DataTable joueurCompetences = m_executeur.joueurCompetences(m_id);
            foreach (DataRow row in joueurCompetences.Rows)
            {
                string Competence = (string)row["ComNom"]; //Récupérer le Nom de la compétence
                string Niveau = (string)row["ComNiv"]; //Récupérer le Niveau de la compétence
                lst_persoCompetences.Items.Add(Niveau + ": " + Competence);
            }

            if (joueurCompetences.Rows.Count == 0)
                lst_persoCompetences.Items.Add("Aucune compétence");
        }

        //Remplir le pannel des Equipements du perso
        private void RemplirEquipements()
        {
            lst_equipements.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurEquipements = m_executeur.joueurEquipements(m_id);

            foreach (DataRow row in joueurEquipements.Rows)
            {
                //Equipement
                string Equipement = (string)row["EquNom"]; //Récupérer le Nom de l'équipement
                string Nom = (string)row["CatNom"]; //Récupérer le Nom de la Catégorie de l'équipement
                string[] statEquipement = { Nom, Equipement };
                var itemEquipement = new ListViewItem(statEquipement);
                lst_equipements.Items.Add(itemEquipement);
            }

            if (joueurEquipements.Rows.Count == 0)
            {
                string[] vide = { "", "Vous etes tout nu *sur la plage*" };
                var itemVide = new ListViewItem(vide);
                lst_equipements.Items.Add(itemVide);
            }
        }

        //Remplir le pannel d'inventaire du perso
        private void RemplirInventaire()
        {
            lst_inventaire.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurInventaire = m_executeur.joueurInventaire(m_id);
            foreach (DataRow row in joueurInventaire.Rows)
            {
                //Equipement
                string Inventaire = (string)row["IteNom"]; //Récupérer le Nom de l'item
                string Nom = (string)row["InvQte"]; //Récupérer la quantitée de l'item
                string[] statInventaire = { Nom, Inventaire };
                var itemInventaire = new ListViewItem(statInventaire);
                lst_inventaire.Items.Add(itemInventaire);
            }

            if (joueurInventaire.Rows.Count == 0)
            {
                string[] vide = { "", "Vous n'avez pas d'items." };
                var itemVide = new ListViewItem(vide);
                lst_inventaire.Items.Add(itemVide);
            }
        }

        //Remplir le pannel des quêtes du perso
        private void RemplirQuetes()
        {
            lst_quetes.Items.Clear();
            DataTable joueurQuetes = m_executeur.joueurQuetes(m_id);
            foreach (DataRow row in joueurQuetes.Rows)
            {
                string Quete = (string)row["QueNom"]; //Récupérer le Nom de la Quête
                string Etat = (string)row["EtaNom"]; //Récupérer le Nom de l'État de la Quête
                lst_quetes.Items.Add(Etat + ": " + Quete);
            }

            if (joueurQuetes.Rows.Count == 0)
                lst_quetes.Items.Add("Aucune Quête");
        }

        //Remplir le pannel d'histoire du perso
        private void RemplirHistoire()
        {
            lst_histoire.Items.Clear();
            DataTable joueurQuetes = m_executeur.joueurQuetes(m_id);
            double quetesCount = joueurQuetes.Rows.Count;
            double actCount = Math.Ceiling(quetesCount / 10);
            //Chaque 10quêtes on augmente le numéro d'Act (l'histoire)
            for (int i = 1; i <= actCount; i++)
                lst_histoire.Items.Add("Act:" + i);
        }

        //Update tous les champs de l'écran
        private void UpdateTout()
        {
            RemplirInfoJoueur();
            RemplirStatsJoueur();
            RemplirCompetences();
            RemplirEquipements();
            RemplirInventaire();
            RemplirQuetes();
            RemplirHistoire();
        }

        /**Gérer l'affichage de l'image principale à l'écran
         * p_msg : le message retourner par le sql server
         */
        private void GestionImage(string p_msg)
        {
            //Affiche toujours la même map selon le niveau (change à tous les 5 niveaux)
            int city = (int)Math.Floor((double)(m_niv / 5));
            city = (city < m_allcities.Count) ? (int)Math.Floor((double)(m_niv / 5)) : m_allcities.Count - 1; //Si niveau trop élevé alors on affiche la derniere map de la liste

            //Changer l'image selon les messages provenant du server
            if (p_msg.Contains("attaque") || p_msg.Contains("appercevez")) //Lors d'un combat
            {
                GererImagesPV();
                pct_marchand.Visible = true;
                pct_marchand.Image = global::IdleGame.Properties.Resources.monstre;
            }
            else if (p_msg == "Vous continuez de combattre!" || p_msg.Contains("aventure") || p_msg.Contains("nouvel") || p_msg.Contains("recherche")) //Entre deux combats
            {
                pct_marchand.Visible = true;
                pct_marchand.Image = global::IdleGame.Properties.Resources.footprint;
                //Si niveau perso >50 afficher la carte plus sombre;
                img_bg.Image = (m_niv <= 50) ? m_allcartes[0] : m_allcartes[1];
                hideHP();
            }
            else if (p_msg == ("Vous etes mort.")) //Lorsque mort
            {
                pct_marchand.Visible = true;
                pct_marchand.Image = global::IdleGame.Properties.Resources.dead;
                hideHP();
            }
            else if (p_msg.Contains("marchand") || p_msg.Contains("vendez")) //Lorsque vous etes au marchand
            {
                pct_marchand.Visible = true;
                pct_marchand.Image = global::IdleGame.Properties.Resources.marchand;
                hideHP();
            }
            else if (p_msg.Contains("guérisseur")) //Lors d'une visite chez le guérisseur
            {
                pct_marchand.Visible = true;
                pct_marchand.Image = global::IdleGame.Properties.Resources.guerisseur;
                hideHP();
            }
            else if (p_msg.Contains("village")) //Lors du retour au village
            {
                pct_marchand.Visible = false;
                img_bg.Image = m_allcities[city];
                hideHP();
            }
        }

        /**Gérer le rafraichissement des informations affichés à l'écran
         * p_msg : le message retourner par le sql server
         */
        private void GestionUpdate(string p_msg)
        {
            if (p_msg.Contains("pv") || p_msg.Contains("soin") || p_msg.Contains("competence") || p_msg.Contains("Gagné") || p_msg.Contains("mort")) //Lors d'un ajustement des PV, d'expérience Gagné ou d'une Mort du personnage
            {
                RemplirInfoJoueur();
                GererImagesPV();
                RemplirInventaire();
            }
            else if (p_msg.Contains("guérisseur"))
            {
                RemplirInfoJoueur();
            }
            else if (p_msg.Contains("Aventure réussie")) //Lorsqu'une aventure est réussie
            {
                RemplirInfoJoueur();
                RemplirQuetes();
                RemplirHistoire();
            }
            else if (p_msg.Contains("Monstre tué")) //Lorsqu'un monstre meurt
            {
                RemplirInfoJoueur();
                RemplirInventaire();
            }
            else if (p_msg.Contains("vendez"))  //Lors de vente d'équipements ou inventaires
            {
                RemplirInventaire();
            }
            else if (p_msg.Contains("achetez") || p_msg.Contains("acheter")) //Lors d'achat d'équipements
            {
                RemplirEquipements();
            }
        }

        //Gérer l'affichage des points de vie du monstre à l'écran
        private void GererImagesPV()
        {
            DataTable tbl = m_executeur.pvMonstre(m_id); //Récupérer les points de vie d'un monstre avec son id
            DataRow row = tbl.Rows[0]; //La première ligne (la seule!)
            string pvMax = (string)row["PvMonstre"]; //Les point de vie maximum du monstre
            string pvActuel = (string)row["PvActuelMonstre"]; //Les points de vie actuels du monstre
            int pvMaxi;
            int pvActueli;
            Int32.TryParse(pvMax, out pvMaxi);
            Int32.TryParse(pvActuel, out pvActueli);

            lbl_hp.Text = pvActuel + "/" + pvMax;
            lbl_hp.BringToFront();

            //Calcul du pourcentage de vie actuelle / vie maximale
            int pourcentage = (int)Math.Round((double)pvActueli / (double)pvMaxi * 100);

            Color couleur; //Couleur des carrés de vie
            if (pourcentage > 50)
                couleur = Color.Green;
            else if (pourcentage <= 50 && pourcentage > 25)
                couleur = Color.Orange;
            else
                couleur = Color.Red;

            //Affichage de la barre de point de vie
            int compteHP = m_allhp.Count;
            for (int i = 0; i < compteHP; i++)
            {
                m_allhp[i].Visible = true;
                if ( (i * 10) >= pourcentage)
                    m_allhp[i].BackColor = Color.DarkGray;
                else
                    m_allhp[i].BackColor = couleur;
            }
        }

        //Cacher les PV d'un monstre
        private void hideHP()
        {
            int compteHP = m_allhp.Count;
            for (int i = 0; i < compteHP; i++)
            {
                m_allhp[i].Visible = false;
            }
            lbl_hp.Text = "";
        }

        //Gestion des statistiques de la session actuelle
        private void GestionStats(string p_msg)
        {
            if (p_msg == ("Vous etes mort.")) //Ajout d'un death
            {
                deaths++;
                lbl_deathsd.Text = deaths.ToString() + " mort";
            }
            else if (p_msg.Contains("Monstre tué")) //Ajout d'un kill
            {
                kills++;
                lbl_killsd.Text = kills.ToString() + " tués";
            }
            else if (p_msg.Contains("Vous vendez ")) //Ajout de $ à la bourse
            {
                string[] split = p_msg.Split(':');
                int price;
                string valeuritem = split[1].Remove(split[1].Length - 1);
                Int32.TryParse(valeuritem, out price);
                sell += price;
                lbl_cashd.Text = sell.ToString() + "$ vendu";
            }
        }

        //Changer l'image de la scrollbar à tous les X milisecondes
        private void tick(object sender, EventArgs e)
		{
            if (img_statusbar.Image == m_allstatusbar[34]) //Si la barre d'avancement est pleine
            {
                string msg; //La réponse de la base de donnée (l'État du jeu)
                msg = m_executeur.DoIt(m_id); //Appel au contrôleur de la base de donnée
                lbl_info.Text = msg;
                GestionImage(msg);

                //Si le server répond que c'est le temps de choisir des items à acheter
                if (msg == "Vous négogiez avec le marchand pour acheter des équipements.")
                {
                    time_statusbar.Stop();
                    FormChoixEquipement choixEquipement = new FormChoixEquipement(m_id);
                    choixEquipement.ShowDialog();
                    time_statusbar.Start();
                    RemplirEquipements();
                }

                GestionStats(msg);

                //TODELETE: Sert à accélérer le processus. Update l'interface à toutes les X actions
                if (COMPTEURTODELETE == 1)
                {
                    GestionUpdate(msg); //À garder
                    GestionStats(msg); //À garder
                    COMPTEURTODELETE = 0;
                }
                COMPTEURTODELETE ++;
                //Fin to delete
            }

            //Ajuster la barre d'avancement
			img_statusbar.Image = m_allstatusbar[indimg];
            if (indimg == 34)
                indimg = 0;
            else
                indimg++;
		}

		//Thread pour la barre d'avancement ( barre de statut )
		private void AvancementBarre()
		{
			time_statusbar.Tick += new EventHandler(this.tick);
			time_statusbar.Start();
		}

        //Changer le tick
        private void nud_Tick2_ValueChanged(object sender, EventArgs e)
        {
            int interval;
            Int32.TryParse(nud_Tick2.Text, out interval);
            time_statusbar.Interval = (interval > 10) ? interval : 10;
        }

        //Remplir les listes d'images
        private void RemplirListeCartes()
        {
            m_allcartes.Add(global::IdleGame.Properties.Resources.MAP);
            m_allcartes.Add(global::IdleGame.Properties.Resources.DARKMAP);
        }
        private void RemplirListeVilles()
        {
            m_allcities.Add(global::IdleGame.Properties.Resources.city1);
            m_allcities.Add(global::IdleGame.Properties.Resources.city2);
            m_allcities.Add(global::IdleGame.Properties.Resources.city3);
            m_allcities.Add(global::IdleGame.Properties.Resources.city4);
            m_allcities.Add(global::IdleGame.Properties.Resources.city5);
            m_allcities.Add(global::IdleGame.Properties.Resources.city6);
            m_allcities.Add(global::IdleGame.Properties.Resources.city7);
            m_allcities.Add(global::IdleGame.Properties.Resources.city8);
            m_allcities.Add(global::IdleGame.Properties.Resources.city9);
            m_allcities.Add(global::IdleGame.Properties.Resources.city10);
            m_allcities.Add(global::IdleGame.Properties.Resources.city11);
            m_allcities.Add(global::IdleGame.Properties.Resources.city12);
            m_allcities.Add(global::IdleGame.Properties.Resources.city13);
            m_allcities.Add(global::IdleGame.Properties.Resources.city14);
            m_allcities.Add(global::IdleGame.Properties.Resources.city15);
            m_allcities.Add(global::IdleGame.Properties.Resources.city16);
            m_allcities.Add(global::IdleGame.Properties.Resources.city17);
            m_allcities.Add(global::IdleGame.Properties.Resources.city18);
            m_allcities.Add(global::IdleGame.Properties.Resources.city19);
            m_allcities.Add(global::IdleGame.Properties.Resources.city20);
            m_allcities.Add(global::IdleGame.Properties.Resources.city21);
            m_allcities.Add(global::IdleGame.Properties.Resources.city22);
            m_allcities.Add(global::IdleGame.Properties.Resources.city23);
            m_allcities.Add(global::IdleGame.Properties.Resources.city24);
            m_allcities.Add(global::IdleGame.Properties.Resources.city25);
            m_allcities.Add(global::IdleGame.Properties.Resources.city26);
            m_allcities.Add(global::IdleGame.Properties.Resources.city27);
            m_allcities.Add(global::IdleGame.Properties.Resources.city28);
            m_allcities.Add(global::IdleGame.Properties.Resources.city29);
            m_allcities.Add(global::IdleGame.Properties.Resources.city30);
            m_allcities.Add(global::IdleGame.Properties.Resources.city31);
            m_allcities.Add(global::IdleGame.Properties.Resources.city32);
            m_allcities.Add(global::IdleGame.Properties.Resources.city33);
            m_allcities.Add(global::IdleGame.Properties.Resources.city34);
            m_allcities.Add(global::IdleGame.Properties.Resources.city35);
            m_allcities.Add(global::IdleGame.Properties.Resources.city36);
            m_allcities.Add(global::IdleGame.Properties.Resources.city37);
            m_allcities.Add(global::IdleGame.Properties.Resources.city38);
            m_allcities.Add(global::IdleGame.Properties.Resources.city39);
        }
        private void RemplirListeStatusBar()
        {
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar1);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar2);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar3);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar4);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar5);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar6);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar7);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar8);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar9);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar10);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar11);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar12);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar13);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar14);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar15);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar16);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar17);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar18);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar19);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar20);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar21);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar22);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar23);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar24);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar25);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar26);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar27);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar28);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar29);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar30);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar31);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar32);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar33);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.bar34);
            m_allstatusbar.Add(global::IdleGame.Properties.Resources.barempty);
        }
        private void RemplirListeHP()
        {
            m_allhp = new List<PictureBox>();
            m_allhp.Add(pct_hp1);
            m_allhp.Add(pct_hp2);
            m_allhp.Add(pct_hp3);
            m_allhp.Add(pct_hp4);
            m_allhp.Add(pct_hp5);
            m_allhp.Add(pct_hp6);
            m_allhp.Add(pct_hp7);
            m_allhp.Add(pct_hp8);
            m_allhp.Add(pct_hp9);
            m_allhp.Add(pct_hp10);
        }









        // Interface //
        private System.Drawing.Point newpoint;
		private int x, y;
		private void CharForm_Load(object sender, EventArgs e)
		{
			pct_Agrandir.Left = this.Width - 60;
			pct_Fermer.Left = this.Width - 30;
			pct_Reduire.Left = this.Width - 60;
			PlacerLignes();
			mnu_main.BackColor = mainColor;
		}//Form Load
		private void CharForm_Resize(object sender, EventArgs e)
		{
			pct_Agrandir.Left = this.Width - 60;
			pct_Fermer.Left = this.Width - 30;
			pct_Reduire.Left = this.Width - 90;
			PlacerLignes();
		}//Resize
		private void FormJeu_SizeChanged(object sender, EventArgs e)
		{
			grp_top.Width = this.Width - grp_top.Left - (grp_right.Width + 4);
			grp_right.Left = this.Width - grp_right.Width - 1;
			img_bg.Width = grp_top.Width;

			if (this.WindowState == FormWindowState.Maximized)
			{
				grp_top.Height = this.Height * 69/100;
			}
			else
			{
				grp_bottom.Width = 735;
				grp_top.Height = 348;
			}

			grp_left.Height = this.Height - grp_left.Top - 2;
			grp_right.Height = this.Height - grp_right.Top - 2;
			grp_bottom.Top = grp_top.Height + grp_top.Top + 3;
			img_bg.Height = grp_top.Height + grp_top.Top;
		}//On change size
		//Barre du haut
		private void top_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				newpoint = Control.MousePosition;
				newpoint.X -= (x);
				newpoint.Y -= (y);
				this.Location = newpoint;
			}
		}//MouseMove TOP
		private void pct_Fermer_Click(object sender, EventArgs e)
		{
			Close();
		}//Fermer
		private void pct_Agrandir_Click(object sender, EventArgs e)
		{
			this.WindowState = (this.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
		}//Agrandir7
		private void pct_Reduire_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}//Reduire
		private void pct_icon_Click(object sender, EventArgs e)
		{
			mnu_main.Show(this, pct_icon.Location.X, pct_icon.Location.Y + 25);
		}//Menu Icone
		private void top_MouseDown(object sender, MouseEventArgs e)
		{
			x = Control.MousePosition.X - this.Location.X;
			y = Control.MousePosition.Y - this.Location.Y;
		}//MouseClick TOP
		private void top_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.WindowState = (this.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
		}
		private void pct_Reduire_MouseLeave(object sender, EventArgs e)
		{
			pct_Reduire.Image = global::IdleGame.Properties.Resources.underscore;
			pct_Reduire.BackColor = mainColor;
		}//Reduire Hover
		private void pct_Reduire_MouseMove(object sender, MouseEventArgs e)
		{
			pct_Reduire.Image = global::IdleGame.Properties.Resources.underscore2;
			pct_Reduire.BackColor = darkColor;
		}//Reduire Hover
		private void pct_Agrandir_MouseLeave(object sender, EventArgs e)
		{
			pct_Agrandir.Image = global::IdleGame.Properties.Resources.ss;
			pct_Agrandir.BackColor = mainColor;
		}//Agrandir Hover
		private void pct_Agrandir_MouseMove(object sender, MouseEventArgs e)
		{
			pct_Agrandir.Image = global::IdleGame.Properties.Resources.ss2;
			pct_Agrandir.BackColor = darkColor;
		}//Agrandir Hover
		private void pct_Fermer_MouseLeave(object sender, EventArgs e)
		{
			pct_Fermer.Image = global::IdleGame.Properties.Resources.xx;
			pct_Fermer.BackColor = mainColor;
		}//Fermer Hover
		private void pct_Fermer_MouseMove(object sender, MouseEventArgs e)
		{
			pct_Fermer.Image = global::IdleGame.Properties.Resources.xx2;
			pct_Fermer.BackColor = Color.Red;
		}//Fermer Hover
		private void pct_icon_MouseMove(object sender, MouseEventArgs e)
		{
			pct_icon.Image = global::IdleGame.Properties.Resources.icon2;
			pct_icon.BackColor = darkColor;
		}//Menu Icone Hover
		private void pct_icon_MouseLeave(object sender, EventArgs e)
		{
			pct_icon.Image = global::IdleGame.Properties.Resources.icon;
			pct_icon.BackColor = mainColor;
		}//Menu Icone Hover
		//Menu buttons
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}//Bouton Close
         //Lignes contour
        private void PlacerLignes()
        {
            line_LeftLine.BackColor = offColor;
            line_LeftLine.Left = 0;
            line_LeftLine.Top = 0;
            line_LeftLine.Height = this.Height;
            line_LeftLine.Width = 1;

            line_RightLine.BackColor = offColor;
            line_RightLine.Left = this.Width - 1;
            line_RightLine.Top = 0;
            line_RightLine.Height = this.Height;
            line_RightLine.Width = 1;

            line_TopLine.BackColor = offColor;
            line_TopLine.Left = 0;
            line_TopLine.Top = 0;
            line_TopLine.Width = this.Width;
            line_TopLine.Height = 1;

            line_BottomLine.BackColor = offColor;
            line_BottomLine.Left = 0;
            line_BottomLine.Top = this.Height - 1;
            line_BottomLine.Width = this.Width;
            line_TopLine.Height = 1;

        }
        //Pannels
        private void ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			ListView listview = (ListView)sender;
			e.NewWidth = listview.Columns[e.ColumnIndex].Width;
		}//Column change size
		private void spl_feuillePerso_Panel1_SizeChanged(object sender, EventArgs e)
		{
			lst_persoInfo.Height = ((Panel)sender).Height - 17;
		}//PannelChange
		private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
		{
			lst_persoStats.Height = ((Panel)sender).Height - 20;
		}//Pannel change size
		private void spl_statscompetences_Panel2_SizeChanged(object sender, EventArgs e)
		{
			lst_persoCompetences.Height = ((Panel)sender).Height - 20;
		}//Pannel change size
		private void spl_feuillePerso_Panel2_SizeChanged(object sender, EventArgs e)
		{
			spl_statscompetences.Height = (spl_feuillePerso.Height - spl_feuillePerso.Panel1.Height);
		}//Pannel change size
		private void splitContainer1_Panel1_SizeChanged_1(object sender, EventArgs e)
		{
			lst_histoire.Height = ((Panel)sender).Height - 21;
		}//Pannel change size
		private void spl_histoquetes_Panel2_SizeChanged(object sender, EventArgs e)
		{
			lst_quetes.Height = ((Panel)sender).Height - 22;
		}//Pannel change size
		 //Menu déroulant
		private class MyRenderer : ToolStripProfessionalRenderer
		{
			public MyRenderer() : base(new MyColors()) { }
		}//Override des menus par défaut
        private class MyColors : ProfessionalColorTable
		{
			public override Color MenuItemSelected
			{
				get { return Color.FromArgb(86, 27, 27); }
			}
			public override Color MenuItemBorder
			{
				get { return Color.Black; }
			}
		}//Override des couleurs par défaut
	}
}
