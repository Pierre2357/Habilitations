using Habilitations2024.dal;
using Habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.controlleur
{
    public class FrmAuthentificationController
    {
        // objet d'accès aux opérations possibles sur Developpeur
        private readonly DeveloppeurAccess developpeurAccess;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public FrmAuthentificationController()
        {
            developpeurAccess = new DeveloppeurAccess();
        }

        public bool ControleAuthentification(Admin admin)
        {
            return developpeurAccess.ControleAuthentification(admin);
        }
    }
}
