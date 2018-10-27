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
		//colors
		//pinkish = 255, 70, 131
		//red = 178, 34, 34
		//darkred = 86, 27, 27 	   561B1B
		private System.Drawing.Point newpoint;
		private int x, y;
		IdleGame m_idlegame;

		//Constructeur
		public FormMenu(IdleGame p_idlegame)
		{
			m_idlegame = p_idlegame;
			InitializeComponent();
			mnu_main.Renderer = new MyRenderer();
		} //Constructeur












		// Interface //
		private void CharForm_Load(object sender, EventArgs e)
		{
			pct_Agrandir.Left = this.Width - 60;
			pct_Fermer.Left = this.Width - 30;
			pct_Reduire.Left = this.Width - 90;
		}//Form Load
		private void CharForm_Resize(object sender, EventArgs e)
		{
			pct_Agrandir.Left = this.Width - 60;
			pct_Fermer.Left = this.Width - 30;
			pct_Reduire.Left = this.Width - 90;
		}//Resize
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
			pct_Reduire.BackColor = Color.Firebrick;
		}//Reduire Hover
		private void pct_Reduire_MouseMove(object sender, MouseEventArgs e)
		{
			pct_Reduire.Image = global::IdleGame.Properties.Resources.underscore2;
			pct_Reduire.BackColor = Color.FromArgb(86, 27, 27);
		}//Reduire Hover
		private void pct_Agrandir_MouseLeave(object sender, EventArgs e)
		{
			pct_Agrandir.Image = global::IdleGame.Properties.Resources.ss;
			pct_Agrandir.BackColor = Color.Firebrick;
		}//Agrandir Hover
		private void pct_Agrandir_MouseMove(object sender, MouseEventArgs e)
		{
			pct_Agrandir.Image = global::IdleGame.Properties.Resources.ss2;
			pct_Agrandir.BackColor = Color.FromArgb(86, 27, 27);
		}//Agrandir Hover
		private void pct_Fermer_MouseLeave(object sender, EventArgs e)
		{
			pct_Fermer.Image = global::IdleGame.Properties.Resources.xx;
			pct_Fermer.BackColor = Color.Firebrick;
		}//Fermer Hover
		private void pct_Fermer_MouseMove(object sender, MouseEventArgs e)
		{
			pct_Fermer.Image = global::IdleGame.Properties.Resources.xx2;
			pct_Fermer.BackColor = Color.Red;
		}//Fermer Hover
		private void pct_icon_MouseMove(object sender, MouseEventArgs e)
		{
			pct_icon.Image = global::IdleGame.Properties.Resources.icon2;
			pct_icon.BackColor = Color.FromArgb(86, 27, 27);
		}//Menu Icone Hover
		private void pct_icon_MouseLeave(object sender, EventArgs e)
		{
			pct_icon.Image = global::IdleGame.Properties.Resources.icon;
			pct_icon.BackColor = Color.Firebrick;
		}//Menu Icone Hover
		//Menu buttons
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}//Bouton Close
		//Menu déroulant
		private class MyRenderer : ToolStripProfessionalRenderer
		{
			public MyRenderer() : base(new MyColors()) { }
		}//Override des menus par défaut
		private class MyColors : ProfessionalColorTable
		{
			public override Color MenuItemSelected
			{
				get { return Color.Maroon; }
			}
			public override Color MenuItemBorder
			{
				get { return Color.Black; }
			}
		}//Override des couleurs par défaut
	}
}
