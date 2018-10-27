using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
	public class IdleGame
	{
		FormMenu m_menu;

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

	}
}
