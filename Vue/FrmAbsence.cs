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
    public partial class FrmAbsence : Form
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
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bdgAbsence = new BindingSource();
        ////<summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        BindingSource bdgListeDuPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        BindingSource bdgMotifs = new BindingSource();
        public  int idpersonnelSelect;
       
        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>

        public FrmAbsence(Controle controle, int idpersonnelSelect, string nom, string prenom)
        {
            InitializeComponent();
            this.controle = controle;
            Init(idpersonnelSelect, nom, prenom);
        }


        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init(int idpersonnelSelect, string nom, string prenom)
        {
            RemplirListeAbsence(idpersonnelSelect);
            RemplirListeMotifs();
            RemplirIdentité(idpersonnelSelect, nom, prenom);
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirListeAbsence(int idpersonnelSelect)
        {
            
            List<Absence> lesAbsences = controle.GetLesAbsences(idpersonnelSelect);
            bdgAbsence.DataSource = lesAbsences;
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            dgvAbsence.Columns["idmotif"].Visible = false;
            dgvAbsence.Columns["datedebut"].DefaultCellStyle.Format = "dddd d MMMM yyyy";
            dgvAbsence.Columns["datefin"].DefaultCellStyle.Format = "dddd d MMMM yyyy";
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // <summary>
        /// Affiche les motifss
        /// </summary>
        public void RemplirListeMotifs()
        {
            List<Motifs> lesMotifs = controle.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
            if (cboMotif.Items.Count > 0)
            {
                cboMotif.SelectedIndex = 0;
            }
        }
        public void RemplirIdentité(int idpersonnelSelect, string nom, string prenom)
        {
            txtIdpersonnel.Text = idpersonnelSelect.ToString();
            txtNom.Text = nom;
            txtPrenom.Text = prenom;

        }
        

        /// <summary>
        /// Demande de suppression d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_Click(object sender, System.EventArgs e)
        {

            int idpersonnelSelect = int.Parse(txtIdpersonnel.Text);
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsence(absence, idpersonnelSelect);
                    RemplirListeAbsence(idpersonnelSelect);
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
                ViderAbsence();
                gpbAbsence.Enabled = true;
                enCoursDeModif = false;
                gpbAjouterAbsence.Text = "ajouter une absence";
            }
        }

        /// <summary>
        /// Vider les zones de saisie d'un personnel
        /// </summary>
        private void ViderAbsence()
        {
            dtpDateDebut.Value = DateTime.Today;
            dtpDateFin.Value = DateTime.Today;
            cboMotif.SelectedIndex = 0;
        }

        /// <summary>
        /// Demande d'ajout ou de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        
        {
            int idpersonnelSelect = int.Parse(txtIdpersonnel.Text);
            if (dtpDateFin.Value > dtpDateDebut.Value)
            {
                Motifs motif = (Motifs)bdgMotifs.List[bdgMotifs.Position];
                DateTime dateSelect = DateTime.Today;
                
                Absence absence = new Absence(idpersonnelSelect, dtpDateDebut.Value, dtpDateFin.Value, motif.Idmotif, motif.Motif);

                if (enCoursDeModif)
                {
                    dateSelect = (DateTime)dgvAbsence.CurrentRow.Cells["datedebut"].Value;
                    controle.UpdateAbsence(absence, idpersonnelSelect, dateSelect);
                    enCoursDeModif = false;
                    gpbAbsence.Enabled = true;
                    gpbAjouterAbsence.Text = "ajouter une absence";

                }
                else
                {
                    controle.AddAbsence(absence, idpersonnelSelect);
                }
            }
            else
            {
                MessageBox.Show("La date de fin doit être postérieure à celle du début.", "Information");
            }
            RemplirListeAbsence(idpersonnelSelect);
            ViderAbsence();
        }

        /// <summary>
        ///  Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
           
            if (dgvAbsence.SelectedRows.Count > 0)            
            {
                enCoursDeModif = true;
                gpbAbsence.Enabled = false;
                gpbAjouterAbsence.Text = "modifier une absence";
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDateDebut.Value = (DateTime)dgvAbsence.CurrentRow.Cells["datedebut"].Value;
                dtpDateFin.Value = (DateTime)dgvAbsence.CurrentRow.Cells["datefin"].Value;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void BtnTerminer_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmPersonnel(controle).ShowDialog();
        }

    }
}

    

