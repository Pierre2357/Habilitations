using Habilitations2024.controlleur;
using Habilitations2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habilitations2024.vue
{
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        public FrmAuthentification()
        {
            InitializeComponent();
            controller = new FrmAuthentificationController();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            if(!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                Admin admin = new Admin(txtNom.Text, txtPrenom.Text, txtPwd.Text);
                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frm = new FrmHabilitations();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
