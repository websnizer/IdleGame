using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
	public class IdleGame
	{
		FormMenu m_menu; //Form du menu principal
		FormCreation m_creation; //Form de création de personnage
		FormJeu m_jeu; //Form du jeu

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			IdleGame idlegame = new IdleGame();
		}

		public IdleGame()
		{
			m_menu = new FormMenu(this);
			m_menu.Show();
			Application.Run();
		}

		//Affichage de la form de création
		public void ShowCreation()
		{
			m_creation = new FormCreation(this);
			m_creation.ShowDialog();
		}

		//Affichage de la form de création
		public void ShowJeu()
		{
			m_jeu = new FormJeu(this);
			m_jeu.Show();
		}


		//Cacher le menu
		public void HideMenu()
		{
			m_menu.Hide();
		}


	}
}
