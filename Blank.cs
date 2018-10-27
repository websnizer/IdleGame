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
	public partial class Blank : Form
	{
		IdleGame m_idlegame; //Référence au créateur

		//Colors
		Color offColor = Color.FromArgb(255, 70, 131);
		Color mainColor = Color.FromArgb(178, 34, 34);
		Color darkColor = Color.FromArgb(86, 27, 27);

		//Constructeur
		public Blank(IdleGame p_idlegame)
		{
			m_idlegame = p_idlegame;
			InitializeComponent();
			mnu_main.Renderer = new MyRenderer();
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
