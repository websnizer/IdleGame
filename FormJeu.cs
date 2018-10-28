using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace IdleGame
{
	public partial class FormJeu : Form
	{
		IdleGame m_idlegame; //Référence au créateur
		List<Bitmap> m_allstatusbar;
		//Colors
		Color offColor = Color.FromArgb(255, 70, 131);
		Color mainColor = Color.FromArgb(178, 34, 34);
		Color darkColor = Color.FromArgb(86, 27, 27);
		int indimg; //Indice de l'image actuel

		//Constructeur
		public FormJeu(IdleGame p_idlegame)
		{
			m_idlegame = p_idlegame;
			InitializeComponent();
			mnu_main.Renderer = new MyRenderer();
			m_allstatusbar = new List<Bitmap>();
			indimg = 0;
			RemplirListeStatusBar();
			AvancementBarre();
		}

		//Remplir la liste des images pour la status bar
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
		
		//Changer d'image à tous les X milisecondes
		private void tick(object sender, EventArgs e)
		{
			img_statusbar.Image = m_allstatusbar[indimg];
			if (indimg == 34)
				indimg = 0;
			else
				indimg++;
		}

		//Thread:Timer qui débute
		private void AvancementBarre()
		{
			time_statusbar.Tick += new EventHandler(this.tick);
			time_statusbar.Start();
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
				grp_historique.Width = (this.Width - grp_top.Left - (grp_right.Width + 4)) / 2;
				grp_bottom.Width = (this.Width - grp_top.Left - (grp_right.Width + 4)) / 2;
				grp_historique.Left = this.Width - grp_right.Width - grp_bottom.Width;
				grp_historique.Visible = true;
			}
			else
			{
				grp_historique.Visible = false;
				grp_historique.Width = 735;
				grp_bottom.Width = 735;
				grp_top.Height = 348;
			}

			grp_left.Height = this.Height - grp_left.Top - 2;
			grp_right.Height = this.Height - grp_right.Top - 2;
			grp_historique.Top = grp_top.Height + grp_top.Top + 3;
			grp_bottom.Top = grp_top.Height + grp_top.Top + 3;
			img_bg.Height = grp_top.Height + grp_top.Top;
		}//On change size
		 //Lignes
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
