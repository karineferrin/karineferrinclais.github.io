using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AtelierPro1.Controleur;
using AtelierPro1.Modele;

namespace AtelierPro1.Vue
{

    /// <summary>
    /// Fenêtre d'affichage des membres du personnels et de leur service
    /// </summary>
    public partial class frmPersonnel : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModif = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        BindingSource bdgListeDuPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        BindingSource bdgService = new BindingSource();
        ///<summary>
        ///Objet pour gerer les informations obtenues
        /// </summary>
        
        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>

        public frmPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
        RemplirListePersonnel();
        RemplirListeService();
        }

        /// <summary>
        /// Affiche les membres du personnel
        /// </summary>
        public void RemplirListePersonnel()
        {
        List<Personnel> lesPersonnels = controle.GetLesPersonnels();
        bdgListeDuPersonnel.DataSource = lesPersonnels;
        dgvListeDuPersonnel.DataSource = bdgListeDuPersonnel;
        dgvListeDuPersonnel.Columns["idpersonnel"].Visible = false;
        dgvListeDuPersonnel.Columns["idservice"].Visible = false;
        dgvListeDuPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirListeService()
        {
        List<Service> lesServices = controle.GetLesServices();
        bdgService.DataSource = lesServices;
        cboService.DataSource = bdgService;
        if (cboService.Items.Count > 0)
        {
            cboService.SelectedIndex = 0;
        }
        }
        
        /// <summary>
        /// Demande de suppression d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_Click(object sender, System.EventArgs e)
        {
        if (dgvListeDuPersonnel.SelectedRows.Count > 0)
        {
            Personnel personnel = (Personnel)bdgListeDuPersonnel.List[bdgListeDuPersonnel.Position];
            if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controle.DelPersonnel(personnel);
                RemplirListePersonnel();
            }
        }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Vide les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderPersonnel();
                gpbListeDuPersonnel.Enabled = true;
                enCoursDeModif = false;
                gpbAjouterUnSalarié.Text = "ajouter un développeur";
            }
        }

        /// <summary>
        /// Vider les zones de saisie d'un personnel
        /// </summary>
        private void ViderPersonnel()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTelephone.Text = "";
            txtMail.Text = "";
            cboService.SelectedIndex = 0;
        }

        /// <summary>
        /// Demande d'ajout ou de modification d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregistrerAj_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTelephone.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                int idpersonnel = 0;
                
                if (enCoursDeModif)
                {
                    idpersonnel = (int)dgvListeDuPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtMail.Text, service.Idservice, service.Nom) ;
                if (enCoursDeModif)
                {
                    controle.UpdatePersonnel(personnel);
                    enCoursDeModif = false;
                    gpbListeDuPersonnel.Enabled = true;
                    gpbAjouterUnSalarié.Text = "ajouter un personnel";

                }
                else
                {
                    controle.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                ViderPersonnel();
            }
            else
            {
                 MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
             if (dgvListeDuPersonnel.SelectedRows.Count > 0)
             {
                 enCoursDeModif = true;
                 gpbListeDuPersonnel.Enabled = false;
                 gpbAjouterUnSalarié.Text = "modifier un personnel";
                 Personnel personnel = (Personnel)bdgListeDuPersonnel.List[bdgListeDuPersonnel.Position];
                 txtNom.Text = personnel.Nom;
                 txtPrenom.Text = personnel.Prenom;
                 txtTelephone.Text = personnel.Tel;
                 txtMail.Text = personnel.Mail;
                 cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
             }
             else
             {
                 MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
             }
        }
        
        /// <summary>
        /// Demande de declaration d'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnAbsence_Click(object sender, EventArgs e)
        {
            if (dgvListeDuPersonnel.SelectedRows.Count > 0)
            {
                int idpersonnelSelect = (int)dgvListeDuPersonnel.CurrentRow.Cells["idpersonnel"].Value;
                string nom = (string)dgvListeDuPersonnel.CurrentRow.Cells["nom"].Value;
                string prenom = (string)dgvListeDuPersonnel.CurrentRow.Cells["prenom"].Value;
                gpbListeDuPersonnel.Enabled = true;
                gpbAjouterUnSalarié.Enabled = true;
                controle.GererAbsence(idpersonnelSelect, nom, prenom);
                
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        

    }
}
    


