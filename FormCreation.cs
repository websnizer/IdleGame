using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
	public partial class FormCreation : Form
	{
		IdleGame m_idlegame; //Référence au créateur
        ExecIdleGame m_executeur;

		//Colors
		Color offColor = Color.FromArgb(255, 70, 131);
		Color mainColor = Color.FromArgb(178, 34, 34);
		Color darkColor = Color.FromArgb(86, 27, 27);


		//Constructeur
		public FormCreation(IdleGame p_idlegame)
		{
			m_idlegame = p_idlegame;
			InitializeComponent();
			mnu_main.Renderer = new MyRenderer();
            m_executeur = new ExecIdleGame();
            RemplirRaces();
            RemplirClasses(); 
		}

        //Remplir les races
        private void RemplirRaces()
        {
            //Récupéré les donnes dans la database
            DataTable Races = m_executeur.toutesRaces();
            cmb_race.ValueMember = "RacID";
            cmb_race.DisplayMember = "RacNom";
            cmb_race.DataSource = Races;

            cmb_race.SelectedIndex = 0;
        }

        //Remplir les classes selon la race choisie
        private void RemplirClasses()
        {
            //Récupéré les donnes dans la database
            int idRace; //id de la race
            Int32.TryParse(cmb_race.SelectedValue.ToString(), out idRace);

            DataTable ClassesPossibles = m_executeur.toutesClassesPossibles(idRace);
            cmb_classe.ValueMember = "ClaPosClasseID";
            cmb_classe.DisplayMember = "ClaNom";
            cmb_classe.DataSource = ClassesPossibles;
        }

        //Remplir les bonus de la race choisie
        private void RemplirBonusRaces()
        {
            if (cmb_race.Items.Count >= 1)
            {
                int idRace;
                Int32.TryParse(cmb_race.SelectedValue.ToString(), out idRace);

                DataTable bonusRace = m_executeur.bonusRaces(idRace);
                DataRow row = bonusRace.Rows[0];

                lbl_strbon.Text = (string)row["RacFor"];
                lbl_dexbon.Text = (string)row["RacDex"];    
                lbl_conbon.Text = (string)row["RacCon"];
                lbl_intbon.Text = (string)row["RacInt"];
                lbl_sagbon.Text = (string)row["RacSag"];
                lbl_chabon.Text = (string)row["RacCha"];

                int str;
                int dex;
                int con;
                int intel;
                int sag;
                int cha;
                Int32.TryParse(lbl_strbon.Text, out str);
                Int32.TryParse(lbl_dexbon.Text, out dex);
                Int32.TryParse(lbl_conbon.Text, out con);
                Int32.TryParse(lbl_intbon.Text, out intel);
                Int32.TryParse(lbl_sagbon.Text, out sag);
                Int32.TryParse(lbl_chabon.Text, out cha);
            }
        }

        //Génerer des stats aléatoires
        private void GenererStats()
        {
            Random rng = new Random();
            int force = rng.Next(7, 19);
            int dexterite = rng.Next(7, 19);
            int constitution = rng.Next(7, 19);
            int intelligence = rng.Next(7, 19);
            int sagesse = rng.Next(7, 19);
            int charisme = rng.Next(7, 19);
            int total = force + dexterite + constitution + intelligence + sagesse + charisme;

            txt_str.Text = force.ToString();
            txt_dex.Text = dexterite.ToString();
            txt_con.Text = constitution.ToString();
            txt_int.Text = intelligence.ToString();
            txt_sag.Text = sagesse.ToString();
            txt_cha.Text = charisme.ToString();

            if (total > 85)
                txt_totalstat.ForeColor = Color.Red;
            else if (total > 71)
                txt_totalstat.ForeColor = Color.Orange;
            else
                txt_totalstat.ForeColor = Color.Black;

            txt_totalstat.Text = total.ToString();
        }
        
        //Ajuster les classes selon la race choisie
        private void cmb_race_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirClasses();
            RemplirBonusRaces();
        }
        
        //Ajuster le message d'information à l'utilisateur lors du changement de difficulté
        private void cmb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox snd = (ComboBox)sender;
            lbl_info.Visible = (snd.SelectedIndex == 0) ? false : true;
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
            cmb_difficulte.SelectedIndex = 0;
		}//Form Load
		private void CharForm_Resize(object sender, EventArgs e)
		{
			pct_Agrandir.Left = this.Width - 60;
			pct_Fermer.Left = this.Width - 30;
			pct_Reduire.Left = this.Width - 90;
			PlacerLignes();
		}//Resize
		//Lignes
		private void PlacerLignes()
		{
			LeftLine.BackColor = offColor;
			LeftLine.Left = 0;
			LeftLine.Top = 0;
			LeftLine.Height = this.Height;
			LeftLine.Width = 1;

			RightLine.BackColor = offColor;
			RightLine.Left = this.Width - 1;
			RightLine.Top = 0;
			RightLine.Height = this.Height;
			RightLine.Width = 1;

			TopLine.BackColor = offColor;
			TopLine.Left = 0;
			TopLine.Top = 0;
			TopLine.Width = this.Width;
			TopLine.Height = 1;

			BottomLine.BackColor = offColor;
			BottomLine.Left = 0;
			BottomLine.Top = this.Height - 1;
			BottomLine.Width = this.Width;
			TopLine.Height = 1;

		}
		//Barre TOP
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
		}//Agrandir
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
		}
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
		private void saveToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			//((ToolStripMenuItem)sender).ForeColor = offColor;
		}//Bouton save
		private void saveToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			//((ToolStripMenuItem)sender).ForeColor = Color.White;
		}//Bouton save
		 //Menu déroulant
		private class MyRenderer : ToolStripProfessionalRenderer
		{
			public MyRenderer() : base(new MyColors()) { }
		}//Override des menus par défaut
        private void btn_cancelRecherche_Click(object sender, EventArgs e)
        {
            RemplirRaces();
        }
        private void txt_Nom_Enter(object sender, EventArgs e)
        {
            txt_Nom.Clear();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            GenererStats();
        }//Bouton generer aléatoire
        private void btn_ok_Click(object sender, EventArgs e)
        {
            int str;
            int dex;
            int con;
            int intel;
            int sag;
            int cha;
            int idRace;
            int idClasse;
            int diff;
            string nom;
            Int32.TryParse(txt_str.Text, out str);
            Int32.TryParse(txt_dex.Text, out dex);
            Int32.TryParse(txt_con.Text, out con);
            Int32.TryParse(txt_int.Text, out intel);
            Int32.TryParse(txt_sag.Text, out sag);
            Int32.TryParse(txt_cha.Text, out cha);
            Int32.TryParse(cmb_race.SelectedValue.ToString(), out idRace);
            Int32.TryParse(cmb_classe.SelectedValue.ToString(), out idClasse);
            Int32.TryParse(cmb_difficulte.SelectedIndex.ToString(), out diff);
            nom = txt_Nom.Text;
            int idPersoCreer;

            try
            {
                erreur(str, dex, con, intel, sag, cha, idRace, idClasse, diff, nom);
                idPersoCreer = m_executeur.creationPersonnage(nom, idRace, idClasse, str, dex, con, intel, sag, cha, diff + 1);
                m_idlegame.ShowJeu(idPersoCreer);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }//Bouton ok
        private void erreur(int p_str, int p_dex, int p_con, int p_int, int p_sag, int p_cha, int p_idRace, int p_idClasse, int p_diff, string p_nom)
        {
            if (    p_str == null || 
                    p_dex == null || 
                    p_con == null || 
                    p_int == null || 
                    p_sag == null || 
                    p_cha == null || 
                    p_idRace == null || 
                    p_idClasse == null || 
                    p_diff == null || 
                    p_nom == "")
            {
                throw new ErreurInvalide(string.Format("Impossible de créer le joueur, assurez vous d'avoir remplis tous les champs requis."));
            }
        }//Exception erreur
        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

    public class ErreurInvalide : Exception
    {
        public ErreurInvalide(string message)
           : base(message)
        {
        }
    }
}
