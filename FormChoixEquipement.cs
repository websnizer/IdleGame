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
    public partial class FormChoixEquipement : Form
    {
        int m_id; //Le id du joueur
        int temps; //temps écoulé en seconde
        int m_cash; //Le $ du joueur
        bool m_achat;
        bool m_items;
        List<int> listeIds;
        ExecIdleGame m_executeur;

        public FormChoixEquipement(int p_id)
        {
            InitializeComponent();
            m_executeur = new ExecIdleGame();
            listeIds = new List<int>();
            m_id = p_id;
            temps = 0;
            m_items = false;
            m_achat = false;
            lbl_tempsrestant.Text = temps.ToString();
            AfficheEquipements();
            RecupererArgent();
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            temps++;
            lbl_tempsrestant.Text = temps.ToString();
            if (temps == 10)
            {
                this.Close();
            }
        }
        private void RecupererArgent()
        {
            //Récupéré les donnes dans la database
            DataTable joueurInfos = m_executeur.joueurInformations(m_id);
            DataRow row = joueurInfos.Rows[0];

            //Ajouter le Niveau dans le listview
            string Cash = (string)row["PerArgent"];

            Int32.TryParse(Cash, out m_cash);
            lbl_argent.Text = Cash + "$";
        }
        private void AfficheEquipements()
        {
            int indiceEquip = 1;
            int parseID;
            DataTable equipements = m_executeur.equipementsMarchand(m_id);
            foreach (DataRow row in equipements.Rows)
            {
                m_items = true;
                //Création d'Équipement dynamique
                string eID = (string)row["EquID"];
                string eNOM = (string)row["EquNom"];
                string eSTR = (string)row["EquFor"];
                string eDEX = (string)row["EquDex"];
                string eCON = (string)row["EquCon"];
                string eINT = (string)row["EquInt"];
                string eSAG = (string)row["EquCha"];
                string eCHA = (string)row["EquSag"];
                string eCATNom = (string)row["CatNom"];
                string ePRIX = (string)row["EquPrix"];
                string eNIV = (string)row["EquNiv"];
                Int32.TryParse(eID, out parseID);
                listeIds.Add(parseID);

                if ( indiceEquip == 1)
                {
                    pnl_item1.Visible = true;
                    lbl_nom1.Text = eNOM;
                    lbl_strd1.Text = eSTR;
                    lbl_dexd1.Text = eDEX;
                    lbl_cond1.Text = eCON;
                    lbl_intd1.Text = eINT;
                    lbl_sagd1.Text = eSAG;
                    lbl_chad1.Text = eCHA;
                    lbl_cat1.Text = eCATNom;
                    lbl_nivd1.Text = eNIV;
                    lbl_prixd1.Text = ePRIX;
                    btn_buy1.Tag = parseID;
                }
                else if (indiceEquip == 2)
                {
                    pnl_item2.Visible = true;
                    lbl_nom2.Text = eNOM;
                    lbl_strd2.Text = eSTR;
                    lbl_dexd2.Text = eDEX;
                    lbl_cond2.Text = eCON;
                    lbl_intd2.Text = eINT;
                    lbl_sagd2.Text = eSAG;
                    lbl_chad2.Text = eCHA;
                    lbl_cat2.Text = eCATNom;
                    lbl_nivd2.Text = eNIV;
                    lbl_prixd2.Text = ePRIX;
                    btn_buy2.Tag = parseID;
                }
                else if (indiceEquip == 3)
                {
                    pnl_item3.Visible = true;
                    lbl_nom3.Text = eNOM;
                    lbl_strd3.Text = eSTR;
                    lbl_dexd3.Text = eDEX;
                    lbl_cond3.Text = eCON;
                    lbl_intd3.Text = eINT;
                    lbl_sagd3.Text = eSAG;
                    lbl_chad3.Text = eCHA;
                    lbl_cat3.Text = eCATNom;
                    lbl_nivd3.Text = eNIV;
                    lbl_prixd3.Text = ePRIX;
                    btn_buy3.Tag = parseID;
                }
                else if (indiceEquip == 4)
                {
                    pnl_item4.Visible = true;
                    lbl_nom4.Text = eNOM;
                    lbl_strd4.Text = eSTR;
                    lbl_dexd4.Text = eDEX;
                    lbl_cond4.Text = eCON;
                    lbl_intd4.Text = eINT;
                    lbl_sagd4.Text = eSAG;
                    lbl_chad4.Text = eCHA;
                    lbl_cat4.Text = eCATNom;
                    lbl_nivd4.Text = eNIV;
                    lbl_prixd4.Text = ePRIX;
                    btn_buy4.Tag = parseID;
                }
                else if (indiceEquip == 5)
                {
                    pnl_item5.Visible = true;
                    lbl_nom5.Text = eNOM;
                    lbl_strd5.Text = eSTR;
                    lbl_dexd5.Text = eDEX;
                    lbl_cond5.Text = eCON;
                    lbl_intd5.Text = eINT;
                    lbl_sagd5.Text = eSAG;
                    lbl_chad5.Text = eCHA;
                    lbl_cat5.Text = eCATNom;
                    lbl_nivd5.Text = eNIV;
                    lbl_prixd5.Text = ePRIX;
                    btn_buy5.Tag = parseID;
                }
                indiceEquip++;
            }
            if (!m_items)
                lbl_choix.Text = "Le marchands n'a aucun item pour vous. :'(";
        }
        private void btn_click(object sender, EventArgs e)
        {
            if (!m_achat)
            {
                m_achat = true;
                m_executeur.supprimeMarchand(m_id);
            }

            PictureBox snd = (PictureBox)sender;
            snd.Visible = false;
            int m_equipid = (int)snd.Tag;
            int prixItem = 0;

            if (snd.Name == "btn_buy1")
                Int32.TryParse(lbl_prixd1.Text, out prixItem);
            else if (snd.Name == "btn_buy2")
                Int32.TryParse(lbl_prixd2.Text, out prixItem);
            else if (snd.Name == "btn_buy3")
                Int32.TryParse(lbl_prixd3.Text, out prixItem);
            else if (snd.Name == "btn_buy4")
                Int32.TryParse(lbl_prixd4.Text, out prixItem);
            else if (snd.Name == "btn_buy5")
                Int32.TryParse(lbl_prixd5.Text, out prixItem);

            if ( m_cash >= prixItem)
            {
                m_executeur.buyEquip(m_id, m_equipid);
                m_executeur.ajusteArgent(m_id, prixItem);
                RecupererArgent();
            }
            else
            {
                MessageBox.Show("Argent insuffisant! " + prixItem.ToString());
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            m_executeur.supprimeMarchand(m_id);
            m_executeur.skipAchat(m_id);
            this.Close();
        }

        private void FormChoixEquipement_Load(object sender, EventArgs e)
        {
            if (!m_items)
            {
                m_executeur.skipAchat(m_id);
                this.Close();
            }
        }
    }
}
