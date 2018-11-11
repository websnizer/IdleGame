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
	public partial class FormMenu : Form
	{
		IdleGame m_idlegame; //Référence au créateur
        ExecIdleGame m_executeur; //Executeur pour SQL
        int m_ID; //ID du joueur selectionné dans un des listbox

		//Colors
		Color offColor = Color.FromArgb(255, 70, 131);
		Color mainColor = Color.FromArgb(178, 34, 34);
		Color darkColor = Color.FromArgb(86, 27, 27);

		//Constructeur
		public FormMenu(IdleGame p_idlegame)
		{
            m_executeur = new ExecIdleGame();
            m_idlegame = p_idlegame;
			InitializeComponent();
			mnu_main.Renderer = new MyRenderer();
            m_ID = 0;
		}


        public void InitialiseJoueur()
        {
            DataTable joueurHC = m_executeur.joueurHardcore();  
            lst_hardcore.ValueMember = "PerID";
            lst_hardcore.DisplayMember = "PerNom";
            lst_hardcore.DataSource = joueurHC;

            DataTable joueurSC = m_executeur.joueurStandard();
            lst_standard.ValueMember = "PerID";
            lst_standard.DisplayMember = "PerNom";
            lst_standard.DataSource = joueurSC;
        }

        private void rechercheHardcore(object sender, EventArgs e)
        {
            rechercheHC();
        }

        private void rechercheStandard(object sender, EventArgs e)
        {
            rechercheSC();
        }

        private void btn_loadgame_Click(object sender, EventArgs e)
        {
            if (m_ID > 0)
                m_idlegame.ShowJeu(m_ID);
            else
                MessageBox.Show("Veuillez selectionner un joueur avant.");
        }

        private void lbl_cancelSC_Click(object sender, EventArgs e)
        {
            txt_standard.Text = "";
            rechercheSC();
        }

        private void lbl_cancelHC_Click(object sender, EventArgs e)
        {
            txt_hardcore.Text = "";
            rechercheHC();
        }

        private void pct_goStandard_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Image = global::IdleGame.Properties.Resources.okhover;
        }

        private void pct_goStandard_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = global::IdleGame.Properties.Resources.ok;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_standard_Enter(object sender, EventArgs e)
        {
            TextBox snd = (TextBox)sender;
            snd.Clear();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox snd = (ListBox)sender;
            if (snd.SelectedIndex >= 0)
                Int32.TryParse(snd.SelectedValue.ToString(), out m_ID);
        }

        private void lst_Click(object sender, EventArgs e)
        {
            ListBox snd = (ListBox)sender;
            ListBox otherbox = (snd == lst_hardcore) ? lst_standard : lst_hardcore;
            otherbox.SelectedIndex = -1;
        }

        private void txt_standard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rechercheSC();
        }

        private void txt_hardcore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rechercheHC();
        }

        private void rechercheHC()
        {
            m_ID = 0;
            DataTable joueurHC = m_executeur.rechercheJoueurHardcore(txt_hardcore.Text);
            lst_hardcore.ValueMember = "PerID";
            lst_hardcore.DisplayMember = "PerNom";
            lst_hardcore.DataSource = joueurHC;
        }

        private void rechercheSC()
        {
            m_ID = 0;
            DataTable joueurSC = m_executeur.rechercheJoueurStandard(txt_standard.Text);
            lst_standard.ValueMember = "PerID";
            lst_standard.DisplayMember = "PerNom";
            lst_standard.DataSource = joueurSC;
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
            InitialiseJoueur();
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
		}
		private void saveToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			//((ToolStripMenuItem)sender).ForeColor = Color.White;
		}
		private void btn_newgame_MouseMove(object sender, MouseEventArgs e)
		{
			((PictureBox)sender).Image = global::IdleGame.Properties.Resources.bouton_new_game_hover;
		}
		private void btn_newgame_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).Image = global::IdleGame.Properties.Resources.bouton_new_game;
		}
		private void btn_loadgame_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).Image = global::IdleGame.Properties.Resources.bouton_load_game;
		}
		private void btn_loadgame_MouseMove(object sender, MouseEventArgs e)
		{
			((PictureBox)sender).Image = global::IdleGame.Properties.Resources.bouton_load_game_hover;
		}
		private void btn_exit_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).Image = global::IdleGame.Properties.Resources.bouton_exit;
		}
		private void btn_exit_MouseMove(object sender, MouseEventArgs e)
		{
			((PictureBox)sender).Image = global::IdleGame.Properties.Resources.bouton_exit_hover;
		}
		private void btn_newgame_Click(object sender, EventArgs e)
		{
			//m_idlegame.HideMenu();
			m_idlegame.ShowCreation();
		}
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
