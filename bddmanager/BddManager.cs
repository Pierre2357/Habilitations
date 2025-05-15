using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.bddmanager
{
    public class BddManager
    {
        /// <summary>
        /// Instance unique de la classe
        /// </summary>
        private static BddManager instance = null;

        /// <summary>
        /// Objet de connexion de la BDD à partir d'un chaine de connexion
        /// </summary>
        private readonly MySqlConnection connexion;

        /// <summary>
        /// Constructeur pour créer la connexion et l'ouvrir
        /// </summary>
        /// <param name="StringConnection">chaine de connexion</param>
        public BddManager(string StringConnection)
        {
            connexion = new MySqlConnection(StringConnection);
            connexion.Open();
        }

        /// <summary>
        /// Création de l'unique instance de la classe (si il n'en existe pas déja une)
        /// </summary>
        /// <param name="Stringconnection">chaine de connexion</param>
        /// <returns>L'instance unique de la classe</returns>
        public static BddManager getInstance(string Stringconnection)
        {
            //Vérifie si il n'existe pas déja une instance de la classe
            if (instance == null)
            {
                //Crée l'instance unique de la classe
                instance = new BddManager(Stringconnection);
            }
            //Retourne l'instance unique de la classe
            return instance;
        }

        /// <summary>
        /// Execution d'une requête autre que "SELECT"
        /// </summary>
        /// <param name="StringQuery">Requête SQL à executer autre que "SELECT"</param>
        /// <param name="parameters">dictionnaire contenant les paramètres</param>
        public void ReqUpdate(string StringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand commande = new MySqlCommand(StringQuery, connexion);
            if(!(parameters is null))
            {
                foreach(KeyValuePair<string, object> parameter in parameters)
                {
                    commande.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            commande.Prepare();
            commande.ExecuteNonQuery();
        }

        /// <summary>
        /// Execution d'une requête "SELECT"
        /// </summary>
        /// <param name="StringQuery">Requête "SELECT"</param>
        /// <param name="parameters">Dictionnaire contenant les paramètres</param>
        /// <returns>Valeurs demandées</returns>
        public List<Object[]> ReqSelect(string StringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand commande = new MySqlCommand(StringQuery, connexion);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    commande.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            commande.Prepare();
            MySqlDataReader reader = commande.ExecuteReader();
            int nbCols = reader.FieldCount;
            List<Object[]> records = new List<object[]>();
            while (reader.Read())
            {
                Object[] attributs = new object[nbCols];
                reader.GetValues(attributs);
                records.Add(attributs);
            }
            reader.Close();
            return records;
        }
    }
}
