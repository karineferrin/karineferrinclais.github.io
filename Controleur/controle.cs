using System;
using System.Collections.Generic;
using AtelierPro1.dal;
using AtelierPro1.Modele;
using AtelierPro1.Vue;

namespace AtelierPro1.Controleur
{
    /// <summary>
    /// Gère les interractions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// fenêtre d'authentification
        /// </summary>
        private FrmAuthentification frmAuthentification;
        private frmPersonnel frmPersonnel;
        

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si correct, alors ouvre la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmAuthentification.Hide();
                new frmPersonnel(this).ShowDialog();
                return true;
            }
            else
            {
                return false;

            }
        }
        public void GererAbsence(int idpersonnelSelect, string nom, string prenom)
        {
            new FrmAbsence(this, idpersonnelSelect, nom, prenom).Show();
          
        }

            /// <summary>
            /// Récupère et retourne les infos des membres du personnel provenant de la BDD
            /// </summary>
            /// <returns>liste des développeurs</returns>
            public List<Personnel> GetLesPersonnels()
            {
                return AccesDonnees.GetLesPersonnels();
            }

        /// <summary>
        /// Récupère et retourne les infos des services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Demande de suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            AccesDonnees.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            AccesDonnees.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos sur les absences provenant de la BDD
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Absence> GetLesAbsences(int idpersonnelSelect)
        {
            
            return AccesDonnees.GetLesAbsences(idpersonnelSelect);
        }

        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Motifs> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absencel">objet developpeur à supprimer</param>
        public void DelAbsence(Absence absence, int idpersonnelSelect)
        {
            AccesDonnees.DelAbsence(absence, idpersonnelSelect);
        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence, int idpersonnelSelect)
        {
            AccesDonnees.AddAbsence(absence, idpersonnelSelect);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdateAbsence(Absence absence, int idpersonnelSelect, DateTime dateSelect)
        {
            AccesDonnees.UpdateAbsence(absence, idpersonnelSelect, dateSelect);
        }

    }
}

