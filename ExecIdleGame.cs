using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class ExecIdleGame
    {
        private SQL m_sql;

        public ExecIdleGame()
        {
            m_sql = new SQL();
        }

        public DataTable joueurHardcore()
        {
            return m_sql.executerProcData("sp_tousPersonnagesDifficulte", "Difficulte", 2);
        }

        public DataTable joueurStandard()
        {
            return m_sql.executerProcData("sp_tousPersonnagesDifficulte", "Difficulte", 1);
        }

        public DataTable rechercheJoueurHardcore(string p_nom)
        {
            return m_sql.executerProcData("sp_RecherchePersonnageHardcore", "Nom", p_nom);
        }

        public DataTable rechercheJoueurStandard(string p_nom)
        {
            return m_sql.executerProcData("sp_RecherchePersonnageStandard", "Nom", p_nom);
        }

        public DataTable rechercheRace(string p_race)
        {
            return m_sql.executerProcData("sp_rechercheRace", "Nom", p_race);
        }

        public DataTable rechercheClassePossible(string p_classe, int p_race)
        {
            string[] nomsParams = new string[2];
            Object[] valeursParams = new Object[2];

            nomsParams[0] = "Nom";
            nomsParams[1] = "ID";
            valeursParams[0] = p_classe;
            valeursParams[1] = p_race;
            
            return m_sql.executerProcData("sp_rechercheClassePossible", nomsParams, valeursParams);
        }

        public DataTable joueurStatistiques(int p_id)
        {
            return m_sql.executerProcData("sp_joueurStatistiques", "ID", p_id);
        }

        public DataTable joueurInformations(int p_id)
        {
            return m_sql.executerProcData("sp_joueurInformations", "ID", p_id);
        }

        public DataTable joueurCompetences(int p_id)
        {
            return m_sql.executerProcData("sp_joueurCompetences", "ID", p_id);
        }

        public DataTable joueurEquipements(int p_id)
        {
            return m_sql.executerProcData("sp_joueurEquipements", "ID", p_id);
        }

        public DataTable joueurInventaire(int p_id)
        {
            return m_sql.executerProcData("sp_joueurInventaire", "ID", p_id);
        }

        public DataTable joueurQuetes(int p_id)
        {
            return m_sql.executerProcData("sp_joueurQuete", "ID", p_id);
        }

        public DataTable toutesRaces()
        {
            return m_sql.executerProcData("sp_toutesRaces");
        }

        public DataTable toutesClassesPossibles(int p_id)
        {
            return m_sql.executerProcData("sp_toutesClassesPossibles", "ID", p_id);
        }

        public DataTable bonusRaces(int p_id)
        {
            return m_sql.executerProcData("sp_bonusRace", "ID", p_id);
        }

        public int creationPersonnage(string p_nom, int p_race, int p_classe, int p_for, int p_dex, int p_con, int p_int, int p_sag, int p_cha, int p_diff )
        {
            string[] nomsParams = new string[10];
            Object[] valeursParams = new Object[10];

            nomsParams[0] = "Nom";
            nomsParams[1] = "Race";
            nomsParams[2] = "Classe";
            nomsParams[3] = "For";
            nomsParams[4] = "Dex";
            nomsParams[5] = "Con";
            nomsParams[6] = "Int";
            nomsParams[7] = "Sag";
            nomsParams[8] = "Cha";
            nomsParams[9] = "Diff";
            valeursParams[0] = p_nom;
            valeursParams[1] = p_race;
            valeursParams[2] = p_classe;
            valeursParams[3] = p_for;
            valeursParams[4] = p_dex;
            valeursParams[5] = p_con;
            valeursParams[6] = p_int;
            valeursParams[7] = p_sag;
            valeursParams[8] = p_cha;
            valeursParams[9] = p_diff;

            return m_sql.executerAjout("sc_AjoutPerso", nomsParams, valeursParams);
        }
    }
}
