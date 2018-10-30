using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IdleGame
{
    public class SQL
    {
        private const string DataSource = "den1.mssql3.gear.host"; //Pour la chaine de connection
        private const string UserID = "idlegame"; //Pour la chaine de connection
        private const string Password = "Xd5ZboF~8T6?"; //Pour la chaine de connection
        private const string InitialCatalog = "IdleGame"; //Pour la chaine de connection
        private SqlConnection m_cnx; //La connection

        public SQL() //Constructeur
        {
            //Construire la chaine de connection
            SqlConnectionStringBuilder cnxString = new SqlConnectionStringBuilder();
            cnxString.DataSource = DataSource;
            cnxString.UserID = UserID;
            cnxString.Password = Password;
            cnxString.InitialCatalog = InitialCatalog;
            //Tester la connection
            SqlConnection cnxTest = new SqlConnection();
            cnxTest.ConnectionString = cnxString.ConnectionString;
            if (verifierCnx(cnxTest))
            {
                m_cnx = cnxTest;
            }
        }

        private bool verifierCnx(SqlConnection p_cnxTest) //Vérifier la connection
        {
            try
            {
                p_cnxTest.Open();
                p_cnxTest.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        public void test()
        {
            m_cnx.Open();

            string requete = "SELECT * FROM dbo.Personnages WHERE PerNiv = 0;";

            SqlCommand cmd = new SqlCommand(requete, m_cnx);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            int nbCols = reader.FieldCount;
            for (int i = 0; i < nbCols; i++) 
            {
                table.Columns.Add(reader.GetName(i));
            }

            Object[] resultats = new Object[nbCols];
            while (reader.Read()) //Lire les données
            {
                reader.GetValues(resultats);
                table.Rows.Add(resultats);
            }

            int rows = table.Rows.Count;
            string nom = table.Rows[0].Field<string>("PerNom");

            reader.Close();
            m_cnx.Close();
        }

        public void executerProc(string p_proc) //Exécuter une procédure sans paramètres
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande type procédure
            cmd.ExecuteNonQuery(); //Exécuter la procédure

            m_cnx.Close();
        }

        public void executerProc(string p_proc, string p_param, Object p_value) //Exécuter une procédure avec un paramètre
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande de type procédure
            cmd.Parameters.AddWithValue(p_param, p_value); //Ajouter le paramètre
            cmd.ExecuteNonQuery();

            m_cnx.Close();
        }

        public void executerProc(string p_proc, string[] p_params, Object[] p_values) //Exécuter une procédure avec des paramètres
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande de type procédure
            for (int i = 0; i < p_params.Length; i++) //Ajouter les paramètres
            {
                cmd.Parameters.AddWithValue(p_params[i], p_values[i]);
            }
            cmd.ExecuteNonQuery();

            m_cnx.Close();
        }

        public DataTable executerProcData(string p_proc) //Exécuter une procédure sans paramètres qui retourne des données
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande type procédure
            SqlDataReader reader = cmd.ExecuteReader(); //Exécuter la procédure

            DataTable table = new DataTable(); //Table à retourner
            int nbCols = reader.FieldCount; //Nombre de colonnes
            for (int i = 0; i < nbCols; i++) //Colonnes
            {
                table.Columns.Add(reader.GetName(i));
            }

            Object[] resultats = new Object[nbCols]; //Tableau des résultats
            while (reader.Read()) //Lire les données
            {
                reader.GetValues(resultats);
                table.Rows.Add(resultats);
            }

            reader.Close();
            m_cnx.Close();

            return table;
        }

        public DataTable executerProcData(string p_proc, string p_param, Object p_value) //Exécuter une procédure avec un paramètre qui retourne des données
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande de type procédure
            cmd.Parameters.AddWithValue(p_param, p_value); //Ajouter le paramètre
            SqlDataReader reader = cmd.ExecuteReader(); //Exécuter la procédure

            DataTable table = new DataTable(); //Table à retourner
            int nbCols = reader.FieldCount; //Nombre de colonnes
            for (int i = 0; i < nbCols; i++) //Colonnes
            {
                table.Columns.Add(reader.GetName(i));
            }

            Object[] resultats = new Object[nbCols]; //Tableau des résultats
            while (reader.Read()) //Lire les données
            {
                reader.GetValues(resultats);
                table.Rows.Add(resultats);
            }

            reader.Close();
            m_cnx.Close();

            return table;
        }

        public DataTable executerProcData(string p_proc, string[] p_params, Object[] p_values) //Exécuter une procédure avec des paramètres qui retourne des données
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande de type procédure
            for (int i = 0; i < p_params.Length; i++) //Ajouter les paramètres
            {
                cmd.Parameters.AddWithValue(p_params[i], p_values[i]);
            }
            SqlDataReader reader = cmd.ExecuteReader(); //Exécuter la procédure

            DataTable table = new DataTable(); //Table à retourner
            int nbCols = reader.FieldCount; //Nombre de colonnes
            for (int i = 0; i < nbCols; i++) //Colonnes
            {
                table.Columns.Add(reader.GetName(i));
            }

            Object[] resultats = new Object[nbCols]; //Tableau des résultats
            while (reader.Read()) //Lire les données
            {
                reader.GetValues(resultats);
                table.Rows.Add(resultats);
            }

            reader.Close();
            m_cnx.Close();

            return table;
        }
    }
}
