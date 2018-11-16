using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

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
            catch (SqlException ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
            return true;
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

            DataTable table = organiserResultats(reader);

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

            DataTable table = organiserResultats(reader);

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

            DataTable table = organiserResultats(reader);

            reader.Close();
            m_cnx.Close();

            return table;
        }

        private DataTable organiserResultats(SqlDataReader p_reader) //Former une table avec les données
        {
            DataTable table = new DataTable(); //Table à retourner
            int nbCols = p_reader.FieldCount; //Nombre de colonnes

            for (int i = 0; i < nbCols; i++) //Colonnes
            {
                table.Columns.Add(p_reader.GetName(i)); //Les noms des champs
            }

            Object[] resultats = new Object[nbCols]; //Tableau des résultats

            while (p_reader.Read()) //Lire les données
            {
                p_reader.GetValues(resultats); //Stocker les valeurs de la rangée
                table.Rows.Add(resultats); //Ajouter la rangée à la table
            }

            return table;
        }

        public int executerProcInt(string p_proc, string[] p_params, Object[] p_values) //Exécuter une procédure avec des paramètres qui retourne des données
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande de type procédure
            for (int i = 0; i < p_params.Length; i++) //Ajouter les paramètres
            {
                cmd.Parameters.AddWithValue(p_params[i], p_values[i]);
            }

            SqlDataReader reader = cmd.ExecuteReader(); //Exécuter la procédure

            DataTable table = organiserResultats(reader);

            DataRow row = table.Rows[0];
            int dernierAjout;
            Int32.TryParse((string)row.ItemArray[0], out dernierAjout);

            reader.Close();
            m_cnx.Close();

            return dernierAjout;
        }

        public string executerProcStr(string p_proc, string p_params, Object p_values) //Exécuter une procédure avec un paramètres qui retourne des données
        {
            m_cnx.Open();

            SqlCommand cmd = new SqlCommand(p_proc, m_cnx); //Créer la commande
            cmd.CommandType = CommandType.StoredProcedure; //Commande de type procédure
            cmd.Parameters.AddWithValue(p_params, p_values);

            SqlDataReader reader = cmd.ExecuteReader(); //Exécuter la procédure

            DataTable table = organiserResultats(reader);

            DataRow row = table.Rows[0];
            string dernierAjout;
            dernierAjout = (string)row.ItemArray[0];

            reader.Close();
            m_cnx.Close();

            return dernierAjout;
        }
    }
}