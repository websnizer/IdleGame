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
        ExecIdleGame m_executeur; //L'Executeur de requête SQL
        int indimg; //Indice de l'image actuel
        int m_niv; //Le lvl du joueur
        int m_id; //Id du joueur
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
            UpdateTout();
            AvancementBarre();

           lbl_info.Text = m_executeur.DoIt(m_id);
        }

        //Remplir le pannel des stats (for, dex, con) du joueur
        private void RemplirStatsJoueur()
        {
            lst_persoStats.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurStats = m_executeur.joueurStatistiques(m_id);
            DataRow row = joueurStats.Rows[0];
            
            //Ajouter la Force dans le listview
            string For = (string)row["PerFor"];
            string[] statFor = { "FOR", For};
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

        //Remplir le pannel des informations du joueur
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
            string diffstr = (Difficulte == "1") ? "Normal" : "Easy"; 
            string[] statDifficulte = { "Difficulte", diffstr };
            var itemDifficulte = new ListViewItem(statDifficulte);
            lst_persoInfo.Items.Add(itemDifficulte);

            //Ajouter l'Expérience dans le listview
            string Exp = (string)row["PerExp"];
            string[] statExp= { "Expérience", Exp };
            var itemExp = new ListViewItem(statExp);
            lst_persoInfo.Items.Add(itemExp);

            //Ajouter le Niveau dans le listview
            string Niv = (string)row["PerNiv"];
            string[] statNiv = { "Niveau", Niv };
            var itemNiv = new ListViewItem(statNiv);
            lst_persoInfo.Items.Add(itemNiv);
            Int32.TryParse((string)row["PerNiv"], out m_niv);

            //Ajouter le Niveau dans le listview
            string Cash = (string)row["PerArgent"];
            string[] statCash = { "Cash", Cash };
            var itemCash = new ListViewItem(statCash);
            lst_persoInfo.Items.Add(itemCash);

        }

        //Remplir le pannel des compétences
        private void RemplirCompetences()
        {
            lst_persoCompetences.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurCompetences = m_executeur.joueurCompetences(m_id);

            foreach (DataRow row in joueurCompetences.Rows)
            {
                //Competence
                string Competence = (string)row["ComNom"];
                string Niveau = (string)row["ComNiv"];
                lst_persoCompetences.Items.Add(Niveau + ": " + Competence);
            }

            if (joueurCompetences.Rows.Count == 0)
                lst_persoCompetences.Items.Add("Aucune compétence");
        }

        //Remplir le pannel des Equipements
        private void RemplirEquipements()
        {
            lst_equipements.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurEquipements = m_executeur.joueurEquipements(m_id);

            foreach (DataRow row in joueurEquipements.Rows)
            {
                //Equipement
                string Equipement = (string)row["EquNom"];
                string Nom = (string)row["CatNom"];
                string[] statEquipement = { Nom, Equipement };
                var itemEquipement = new ListViewItem(statEquipement);
                lst_equipements.Items.Add(itemEquipement);
            }

            if (joueurEquipements.Rows.Count == 0)
            {
                string[] vide = { "", "You are naked." };
                var itemVide = new ListViewItem(vide);
                lst_equipements.Items.Add(itemVide);
            }
        }

        //Remplir le pannel d'inventaire 
        private void RemplirInventaire()
        {
            lst_inventaire.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurInventaire = m_executeur.joueurInventaire(m_id);

            foreach (DataRow row in joueurInventaire.Rows)
            {
                //Equipement
                string Inventaire = (string)row["IteNom"];
                string Nom = (string)row["InvQte"];
                string[] statInventaire = { Nom, Inventaire };
                var itemInventaire = new ListViewItem(statInventaire);
                lst_inventaire.Items.Add(itemInventaire);
            }

            if (joueurInventaire.Rows.Count == 0)
            {
                string[] vide = { "", "You have no item yet." };
                var itemVide = new ListViewItem(vide);
                lst_inventaire.Items.Add(itemVide);
            }
        }

        //Remplir le pannel des quêtes
        private void RemplirQuetes()
        {
            lst_quetes.Items.Clear();
            //Récupéré les donnes dans la database
            DataTable joueurQuetes = m_executeur.joueurQuetes(m_id);

            foreach (DataRow row in joueurQuetes.Rows)
            {
                //Competence
                string Quete = (string)row["QueNom"];
                string Etat = (string)row["EtaNom"];
                lst_quetes.Items.Add(Etat + ": " + Quete);
            }

            if (joueurQuetes.Rows.Count == 0)
                lst_quetes.Items.Add("Aucune Quête");
        }

        //Remplir le pannel d'histoire
        private void RemplirHistoire()
        {
            lst_histoire.Items.Clear();
            DataTable joueurQuetes = m_executeur.joueurQuetes(m_id);
            double quetesCount = joueurQuetes.Rows.Count;
            double actCount = Math.Ceiling(quetesCount / 5);
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

        /**Gérer l'affichage de l'image
         * p_msg : le message retourner par le sql server
         */
        private void GestionImage(string p_msg)
        {
            //Affichage toujours la même map selon le niveau (change à tous les 5 niveaux)
            int city = (int)Math.Floor((double)(m_niv / 5));
            city = (city < m_allcities.Count) ? (int)Math.Floor((double)(m_niv / 5)) : m_allcities.Count - 1;
            //Changer l'image selon les informations provenant du server
            if ( p_msg.Contains("Combat") )
                img_bg.Image = global::IdleGame.Properties.Resources.monstre;
            else if ( p_msg.Contains("MAP") )
                img_bg.Image = (m_niv <= 50) ? m_allcartes[0] : m_allcartes[1];
            else if ( p_msg.Contains("") )
                img_bg.Image = m_allcities[city];
        }

        //Changer d'image de la scrollbar à tous les X milisecondes
        private void tick(object sender, EventArgs e)
		{
            if (img_statusbar.Image == m_allstatusbar[34]) //Si la barre est pleine
            {
                string msg = m_executeur.DoIt(m_id);
                if (msg == "Vous négogiez avec le marchand.")
                {
                    time_statusbar.Stop();
                    FormChoixEquipement choixEquipement = new FormChoixEquipement(m_id);
                    choixEquipement.ShowDialog();
                    time_statusbar.Start();
                }
                UpdateTout();
                GestionImage(msg);
                lbl_info.Text = msg;
            }

			img_statusbar.Image = m_allstatusbar[indimg];
			if (indimg == 34)
				indimg = 0;
			else
				indimg++;
		}

		//Debut du thread pour la barre de statut
		private void AvancementBarre()
		{
			time_statusbar.Tick += new EventHandler(this.tick);
			time_statusbar.Start();
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


        //Changer le tick
        private void nud_Tick2_ValueChanged(object sender, EventArgs e)
        {
            int interval;
            Int32.TryParse(nud_Tick2.Text, out interval);
            time_statusbar.Interval = (interval > 5) ? interval : 5;
        }


        // Interface //
        private System.Drawing.Point newpoint;
		private int x, y;
		private void CharForm_Load(object sender, EventArgs e)
		{
			pct_Agrandir.Left = this.Width - 60;
			pct_Fermer.Left = this.Width - 30;
			pct_Reduire.Left = this.Width - 90;
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
			lst_histoire.Height = ((Panel)sender).Height - 20;
		}//Pannel change size
		private void spl_histoquetes_Panel2_SizeChanged(object sender, EventArgs e)
		{
			lst_quetes.Height = ((Panel)sender).Height - 20;
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
