using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Habilitations2024.controlleur;
using Habilitations2024.model;
using MySql.Data.MySqlClient;

namespace Habilitations2024.vue
{
    public partial class FrmHabilitations : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifDeveloppeur = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private BindingSource bdgDeveloppeurs = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgProfils = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgFiltres = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmHabilitationsController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmHabilitations()
        {
            InitializeComponent();
            Init();
        }
        
        /// <summary>
        /// Initialisation
        /// </summary>
        private void Init()
        {
            controller = new FrmHabilitationsController();
            RemplirListeDeveloppeurs();
            RemplirListeProfils();
            RemplirListeFiltres();
            EnCoursDeModifDeveloppeur(false);
            EnCoursDeModifPwd(false);
        }

        /// <summary>
        /// Affiche les developpeurs
        /// </summary>
        private void RemplirListeDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = controller.GetLesDeveloppeurs(cboFiltres.Text);
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvDeveloppeur.DataSource = bdgDeveloppeurs;
            dgvDeveloppeur.Columns["iddeveloppeur"].Visible = false;
            dgvDeveloppeur.Columns["pwd"].Visible = false;
            dgvDeveloppeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les profils
        /// </summary>
        private void RemplirListeProfils()
        {
            List<Profil> lesProfils = controller.GetLesProfils();
            bdgProfils.DataSource = lesProfils;
            cboProfil.DataSource = bdgProfils;
        }

        private void EnCoursDeModifDeveloppeur(bool modif)
        {
            enCoursDeModifDeveloppeur = modif;
            grbLesDeveloppeurs.Enabled = !modif;
            if (modif)
            {
                grbDeveloppeur.Text = "modifier un développeur";
            }
            else
            {
                grbDeveloppeur.Text = "ajouter un développeur";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        private void EnCoursDeModifPwd(bool modif)
        {
            grbPwd.Enabled = modif;
            grbLesDeveloppeurs.Enabled = !modif;
            grbDeveloppeur.Enabled = !modif;
            txtPwd1.Text = "";
            txtPwd2.Text = "";
        }

        /// <summary>
        /// Demande de suppression d'un developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeSupprdev_Click(object sender, EventArgs e)
        {
            if(dgvDeveloppeur.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if(MessageBox.Show("Voulez-vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " ?", "Confirmation de supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregDev_Click(object sender, EventArgs e)
        {
            if(!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboProfil.SelectedIndex != -1)
            {
                Profil profil = (Profil)bdgProfils.List[bdgProfils.Position];
                if (enCoursDeModifDeveloppeur)
                {
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = txtPrenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    controller.UpdateDeveloppeur(developpeur);
                }
                else
                {
                    Developpeur developpeur = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil);
                    controller.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                EnCoursDeModifDeveloppeur(false);
            }
        }

        /// <summary>
        /// Demande de modification d'un developpeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeModifDev_Click(object sender, EventArgs e)
        {
            if(dgvDeveloppeur.SelectedRows.Count > 0)
            {
                EnCoursDeModifDeveloppeur(true);
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                cboProfil.SelectedIndex = cboProfil.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Informations");
            }
        }

        /// <summary>
        /// Annuler l'ajout ou la modification d'un developpeur
        /// Vide toutes les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulDev_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifDeveloppeur(false);
            }
        }

        /// <summary>
        /// Demande de changement de mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeChangePwd_Click(object sender, EventArgs e)
        {
            if(dgvDeveloppeur.SelectedRows.Count > 0)
            {
                EnCoursDeModifPwd(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement de la modification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPwd_Click(object sender, EventArgs e)
        {
            if(!txtPwd1.Text.Equals("") && !txtPwd2.Text.Equals("") && txtPwd1.Text.Equals(txtPwd2.Text))
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                developpeur.Pwd = txtPwd1.Text;
                controller.UpdatePwd(developpeur);
                EnCoursDeModifPwd(false);
            }
            else
            {
                MessageBox.Show("Les 2 zones doivent être remplies et de contenu identique", "Information");
            }
        }

        /// <summary>
        /// Demande d'annulation de la modification du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulPwd_Click(object sender, EventArgs e)
        {
            EnCoursDeModifPwd(false);
        }

        /// <summary>
        /// Affiche les profils
        /// </summary>
        private void RemplirListeFiltres()
        {
            List<Profil> lesFiltres = new List<Profil>();
            lesFiltres.Add(new Profil(0, ""));
            List<Profil> lesProfils = controller.GetLesProfils();
            for(int i = 0; i < lesProfils.Count; i++)
            {
                lesFiltres.Add(lesProfils[i]);
            }
            bdgFiltres.DataSource = lesFiltres;
            cboFiltres.DataSource = bdgFiltres;
        }

        private void cboFiltres_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirListeDeveloppeurs();
        }

        public DataGridView getDgvDeveloppeurs()
        {
            return this.dgvDeveloppeur;
        }
    }
}
