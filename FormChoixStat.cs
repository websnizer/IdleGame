using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
    public partial class FormChoixStat : Form
    {
        int m_id; //Le id du joueur
        int temps; //temps écoulé en seconde
        List<int> listeIds;
        ExecIdleGame m_executeur;

        public FormChoixStat(int p_id)
        {
            InitializeComponent();
            m_executeur = new ExecIdleGame();
            listeIds = new List<int>();
            m_id = p_id;
            temps = 0;
            lbl_tempsrestant.Text = temps.ToString();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            temps++;
            lbl_tempsrestant.Text = temps.ToString();
            if (temps == 10)
            {
                m_executeur.augmenterStatHasard(m_id);
                this.Close();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_click(object sender, EventArgs e)
        {
            PictureBox snd = (PictureBox)sender;
            int stat;
            Int32.TryParse((string)snd.Tag, out stat);
            m_executeur.augmenterStat(m_id, stat);
            this.Close();
        }
    }
}
