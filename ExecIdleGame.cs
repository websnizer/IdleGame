﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class ExecIdleGame
    {
        private SQL m_sql; //Boite à outil SQL

        public ExecIdleGame()
        {
            m_sql = new SQL();
        }

        //Récupérer la liste des joueurs de difficulté hardcore
        public DataTable joueurHardcore()
        {
            return m_sql.executerProcData("sp_tousPersonnagesDifficulte", "Difficulte", 2);
        }
        //Récupérer la liste des joueurs de difficulté standard
        public DataTable joueurStandard()
        {
            return m_sql.executerProcData("sp_tousPersonnagesDifficulte", "Difficulte", 1);
        }
        //Recherche dans la liste des joueurs hardcore selon le nom
        public DataTable rechercheJoueurHardcore(string p_nom)
        {
            return m_sql.executerProcData("sp_RecherchePersonnageHardcore", "Nom", p_nom);
        }
        //Recherche dans la liste des joueurs standard selon le nom
        public DataTable rechercheJoueurStandard(string p_nom)
        {
            return m_sql.executerProcData("sp_RecherchePersonnageStandard", "Nom", p_nom);
        }
        //Recherche dans la liste des Races selon le nom
        public DataTable rechercheRace(string p_race)
        {
            return m_sql.executerProcData("sp_rechercheRace", "Nom", p_race);
        }
        //Recherche dans la liste des Classes possible selon la race choisie et selon le nom
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
        //Récupérer les Statistiques (str, dex, con, ...) d'un joueur avec son ID
        public DataTable joueurStatistiques(int p_id)
        {
            return m_sql.executerProcData("sp_joueurStatistiques", "ID", p_id);
        }
        //Récupérer les Informations (nom, nivea, classe, ...) d'un joueur avec son ID
        public DataTable joueurInformations(int p_id)
        {
            return m_sql.executerProcData("sp_joueurInformations", "ID", p_id);
        }
        //Récupérer les Compétences d'un joueur avec son ID
        public DataTable joueurCompetences(int p_id)
        {
            return m_sql.executerProcData("sp_joueurCompetences", "ID", p_id);
        }
        //Récupérer les Equipements d'un joueur avec son ID
        public DataTable joueurEquipements(int p_id)
        {
            return m_sql.executerProcData("sp_joueurEquipements", "ID", p_id);
        }
        //Récupérer l'Inventaire (Items) d'un joueur avec son ID
        public DataTable joueurInventaire(int p_id)
        {
            return m_sql.executerProcData("sp_joueurInventaire", "ID", p_id);
        }
        //Récupérer les Quêtes d'un joueur avec son ID
        public DataTable joueurQuetes(int p_id)
        {
            return m_sql.executerProcData("sp_joueurQuete", "ID", p_id);
        }
        //Récupérer les races possibles
        public DataTable toutesRaces()
        {
            return m_sql.executerProcData("sp_toutesRaces");
        }
        //Récupérer toutes les classes possibles selon la race choisie
        public DataTable toutesClassesPossibles(int p_id)
        {
            return m_sql.executerProcData("sp_toutesClassesPossibles", "ID", p_id);
        }
        //Récupérer les bonus aux statistiques selon la race choisie
        public DataTable bonusRaces(int p_id)
        {
            return m_sql.executerProcData("sp_bonusRace", "ID", p_id);
        }
        //Création d'un personnages
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

            return m_sql.executerProcInt("sc_AjoutPerso", nomsParams, valeursParams);
        }
        //Récupérer les equipements temporaire du marchand
        public DataTable equipementsMarchand(int p_id)
        {
            return m_sql.executerProcData("sp_obtenirEquipMarchand", "PersoID", p_id);
        }
        //Acheter un équipement précis avec le id du joueur et le id de l'équipement
        public void buyEquip(int p_id, int p_equipid)
        {
            string[] nomsParams = new string[2];
            Object[] valeursParams = new Object[2];

            nomsParams[0] = "PersoID";
            nomsParams[1] = "EquID";
            valeursParams[0] = p_id;
            valeursParams[1] = p_equipid;

            m_sql.executerProcData("sp_ajouterEquipementJoueur", nomsParams, valeursParams);
        }
        //Skip l'achat automatique
        public void skipAchat(int p_id)
        {
            m_sql.executerProc("sp_SkipEtat", "PersoID", p_id);
        }
        //Supprimer un équipement acheter avec le id du joueur et le id de l'équipement
        public void supprimeMarchand(int p_id)
        {
            m_sql.executerProc("sp_SupprimeMarchand", "PersoID", p_id);
        }
        //Ajuster l'argent du personnage lors d'un achat
        public void ajusteArgent(int p_id, int p_argent)
        {
            string[] nomsParams = new string[2];
            Object[] valeursParams = new Object[2];

            nomsParams[0] = "PersoID";
            nomsParams[1] = "Argent";
            valeursParams[0] = p_id;
            valeursParams[1] = p_argent;

            m_sql.executerProcData("sp_ajusteArgent", nomsParams, valeursParams);
        }
        //Augmenter une statistique déterminée
        public void augmenterStat(int p_id, int p_stat)
        {
            string[] nomsParams = new string[2];
            Object[] valeursParams = new Object[2];

            nomsParams[0] = "PersoID";
            nomsParams[1] = "Stat";
            valeursParams[0] = p_id;
            valeursParams[1] = p_stat;

            m_sql.executerProcData("sp_AugmenterStat", nomsParams, valeursParams);
        }
        //Augmenter une statistique au hasard
        public void augmenterStatHasard(int p_id)
        {
            string nomsParams = "PersoID";
            int valeursParams = p_id;

            m_sql.executerProcData("sp_AugmenterStatHasard", nomsParams, valeursParams);
        }
        //Récupérer les PV max et PV actuel d'un monstre
        public DataTable pvMonstre(int p_id)
        {  
            return m_sql.executerProcData("sp_obtenirPvMonstre", "PersoID", p_id);
        }


        //Avertir le server de continuer la boucle d'action du joueur
        public string DoIt(int p_id)
        {
            return m_sql.executerProcStr("sp_Go2WOW", "PersoID", p_id);
        }
    }

    
}
