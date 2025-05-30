namespace Habilitations2024.vue
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDeveloppeur = new System.Windows.Forms.DataGridView();
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.cboFiltres = new System.Windows.Forms.ComboBox();
            this.btnDemandeChangePwd = new System.Windows.Forms.Button();
            this.btnDemandeSupprdev = new System.Windows.Forms.Button();
            this.btnDemandeModifDev = new System.Windows.Forms.Button();
            this.grbDeveloppeur = new System.Windows.Forms.GroupBox();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAnnulDev = new System.Windows.Forms.Button();
            this.btnEnregDev = new System.Windows.Forms.Button();
            this.grbPwd = new System.Windows.Forms.GroupBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblEncore = new System.Windows.Forms.Label();
            this.btnAnnulPwd = new System.Windows.Forms.Button();
            this.btnEnregPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeur)).BeginInit();
            this.grbLesDeveloppeurs.SuspendLayout();
            this.grbDeveloppeur.SuspendLayout();
            this.grbPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeveloppeur
            // 
            this.dgvDeveloppeur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDeveloppeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeur.Location = new System.Drawing.Point(6, 19);
            this.dgvDeveloppeur.MultiSelect = false;
            this.dgvDeveloppeur.Name = "dgvDeveloppeur";
            this.dgvDeveloppeur.RowHeadersVisible = false;
            this.dgvDeveloppeur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeur.Size = new System.Drawing.Size(629, 235);
            this.dgvDeveloppeur.TabIndex = 0;
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.cboFiltres);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeChangePwd);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeSupprdev);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeModifDev);
            this.grbLesDeveloppeurs.Controls.Add(this.dgvDeveloppeur);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(12, 12);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(641, 291);
            this.grbLesDeveloppeurs.TabIndex = 1;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "les développeurs";
            // 
            // cboFiltres
            // 
            this.cboFiltres.FormattingEnabled = true;
            this.cboFiltres.Location = new System.Drawing.Point(521, 262);
            this.cboFiltres.Name = "cboFiltres";
            this.cboFiltres.Size = new System.Drawing.Size(114, 21);
            this.cboFiltres.TabIndex = 4;
            this.cboFiltres.SelectedIndexChanged += new System.EventHandler(this.cboFiltres_SelectedIndexChanged);
            // 
            // btnDemandeChangePwd
            // 
            this.btnDemandeChangePwd.Location = new System.Drawing.Point(168, 260);
            this.btnDemandeChangePwd.Name = "btnDemandeChangePwd";
            this.btnDemandeChangePwd.Size = new System.Drawing.Size(87, 23);
            this.btnDemandeChangePwd.TabIndex = 3;
            this.btnDemandeChangePwd.Text = "changer pwd";
            this.btnDemandeChangePwd.UseVisualStyleBackColor = true;
            this.btnDemandeChangePwd.Click += new System.EventHandler(this.btnDemandeChangePwd_Click);
            // 
            // btnDemandeSupprdev
            // 
            this.btnDemandeSupprdev.Location = new System.Drawing.Point(87, 260);
            this.btnDemandeSupprdev.Name = "btnDemandeSupprdev";
            this.btnDemandeSupprdev.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSupprdev.TabIndex = 2;
            this.btnDemandeSupprdev.Text = "supprimer";
            this.btnDemandeSupprdev.UseVisualStyleBackColor = true;
            this.btnDemandeSupprdev.Click += new System.EventHandler(this.btnDemandeSupprdev_Click);
            // 
            // btnDemandeModifDev
            // 
            this.btnDemandeModifDev.Location = new System.Drawing.Point(6, 260);
            this.btnDemandeModifDev.Name = "btnDemandeModifDev";
            this.btnDemandeModifDev.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifDev.TabIndex = 1;
            this.btnDemandeModifDev.Text = "modifier";
            this.btnDemandeModifDev.UseVisualStyleBackColor = true;
            this.btnDemandeModifDev.Click += new System.EventHandler(this.btnDemandeModifDev_Click);
            // 
            // grbDeveloppeur
            // 
            this.grbDeveloppeur.Controls.Add(this.cboProfil);
            this.grbDeveloppeur.Controls.Add(this.txtTel);
            this.grbDeveloppeur.Controls.Add(this.txtMail);
            this.grbDeveloppeur.Controls.Add(this.txtPrenom);
            this.grbDeveloppeur.Controls.Add(this.txtNom);
            this.grbDeveloppeur.Controls.Add(this.lblProfil);
            this.grbDeveloppeur.Controls.Add(this.lblTel);
            this.grbDeveloppeur.Controls.Add(this.lblMail);
            this.grbDeveloppeur.Controls.Add(this.lblPrenom);
            this.grbDeveloppeur.Controls.Add(this.lblNom);
            this.grbDeveloppeur.Controls.Add(this.btnAnnulDev);
            this.grbDeveloppeur.Controls.Add(this.btnEnregDev);
            this.grbDeveloppeur.Location = new System.Drawing.Point(12, 309);
            this.grbDeveloppeur.Name = "grbDeveloppeur";
            this.grbDeveloppeur.Size = new System.Drawing.Size(641, 150);
            this.grbDeveloppeur.TabIndex = 2;
            this.grbDeveloppeur.TabStop = false;
            this.grbDeveloppeur.Text = "ajouter un développeur";
            // 
            // cboProfil
            // 
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(372, 92);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(121, 21);
            this.cboProfil.TabIndex = 13;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(372, 59);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(263, 20);
            this.txtTel.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(372, 26);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(263, 20);
            this.txtMail.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(62, 59);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(261, 20);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(62, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(261, 20);
            this.txtNom.TabIndex = 9;
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(329, 95);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(29, 13);
            this.lblProfil.TabIndex = 8;
            this.lblProfil.Text = "profil";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(329, 62);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(18, 13);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(329, 29);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(25, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "mail";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 62);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "nom";
            // 
            // btnAnnulDev
            // 
            this.btnAnnulDev.Location = new System.Drawing.Point(87, 121);
            this.btnAnnulDev.Name = "btnAnnulDev";
            this.btnAnnulDev.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulDev.TabIndex = 3;
            this.btnAnnulDev.Text = "annuler";
            this.btnAnnulDev.UseVisualStyleBackColor = true;
            this.btnAnnulDev.Click += new System.EventHandler(this.btnAnnulDev_Click);
            // 
            // btnEnregDev
            // 
            this.btnEnregDev.Location = new System.Drawing.Point(0, 121);
            this.btnEnregDev.Name = "btnEnregDev";
            this.btnEnregDev.Size = new System.Drawing.Size(75, 23);
            this.btnEnregDev.TabIndex = 2;
            this.btnEnregDev.Text = "enregistrer";
            this.btnEnregDev.UseVisualStyleBackColor = true;
            this.btnEnregDev.Click += new System.EventHandler(this.btnEnregDev_Click);
            // 
            // grbPwd
            // 
            this.grbPwd.Controls.Add(this.txtPwd2);
            this.grbPwd.Controls.Add(this.txtPwd1);
            this.grbPwd.Controls.Add(this.lblPwd);
            this.grbPwd.Controls.Add(this.lblEncore);
            this.grbPwd.Controls.Add(this.btnAnnulPwd);
            this.grbPwd.Controls.Add(this.btnEnregPwd);
            this.grbPwd.Location = new System.Drawing.Point(12, 465);
            this.grbPwd.Name = "grbPwd";
            this.grbPwd.Size = new System.Drawing.Size(641, 79);
            this.grbPwd.TabIndex = 3;
            this.grbPwd.TabStop = false;
            this.grbPwd.Text = "changer le mot de passe";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(372, 23);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(263, 20);
            this.txtPwd2.TabIndex = 11;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(62, 23);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(261, 20);
            this.txtPwd1.TabIndex = 10;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(3, 26);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(27, 13);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "pwd";
            // 
            // lblEncore
            // 
            this.lblEncore.AutoSize = true;
            this.lblEncore.Location = new System.Drawing.Point(329, 26);
            this.lblEncore.Name = "lblEncore";
            this.lblEncore.Size = new System.Drawing.Size(40, 13);
            this.lblEncore.TabIndex = 5;
            this.lblEncore.Text = "encore";
            // 
            // btnAnnulPwd
            // 
            this.btnAnnulPwd.Location = new System.Drawing.Point(87, 49);
            this.btnAnnulPwd.Name = "btnAnnulPwd";
            this.btnAnnulPwd.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPwd.TabIndex = 4;
            this.btnAnnulPwd.Text = "annuler";
            this.btnAnnulPwd.UseVisualStyleBackColor = true;
            this.btnAnnulPwd.Click += new System.EventHandler(this.btnAnnulPwd_Click);
            // 
            // btnEnregPwd
            // 
            this.btnEnregPwd.Location = new System.Drawing.Point(6, 50);
            this.btnEnregPwd.Name = "btnEnregPwd";
            this.btnEnregPwd.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPwd.TabIndex = 3;
            this.btnEnregPwd.Text = "enregistrer";
            this.btnEnregPwd.UseVisualStyleBackColor = true;
            this.btnEnregPwd.Click += new System.EventHandler(this.btnEnregPwd_Click);
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 548);
            this.Controls.Add(this.grbPwd);
            this.Controls.Add(this.grbDeveloppeur);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeur)).EndInit();
            this.grbLesDeveloppeurs.ResumeLayout(false);
            this.grbDeveloppeur.ResumeLayout(false);
            this.grbDeveloppeur.PerformLayout();
            this.grbPwd.ResumeLayout(false);
            this.grbPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeveloppeur;
        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
        private System.Windows.Forms.GroupBox grbDeveloppeur;
        private System.Windows.Forms.GroupBox grbPwd;
        private System.Windows.Forms.Button btnDemandeChangePwd;
        private System.Windows.Forms.Button btnDemandeSupprdev;
        private System.Windows.Forms.Button btnDemandeModifDev;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnulDev;
        private System.Windows.Forms.Button btnEnregDev;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblEncore;
        private System.Windows.Forms.Button btnAnnulPwd;
        private System.Windows.Forms.Button btnEnregPwd;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.ComboBox cboFiltres;
    }
}

