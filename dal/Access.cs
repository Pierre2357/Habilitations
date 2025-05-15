using Habilitations2024.bddmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.dal
{
    public class Access
    {
        //Chaine de connexion à la bdd
        private static readonly string connectionString = "Server=localhost;Database=habilitations;User Id=habilitations;Password=motdepasseuser;";
        //Instance unique de la classe
        private static Access instance = null;
        //Objet d'accès aux données
        public BddManager Manager { get; }

        /// <summary>
        /// Constructeur de la classe Access
        /// </summary>
        private Access()
        {
            try
            {
                this.Manager = BddManager.getInstance(connectionString);
            }
            catch
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création de l'instance unique de la classe (si elle n'esiste pas déjà)
        /// </summary>
        /// <returns>L'instance unique de la classe</returns>
        public static Access getInstance()
        {
            if(instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
