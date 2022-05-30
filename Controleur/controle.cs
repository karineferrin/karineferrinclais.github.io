using System;
using System.Collections.Generic;
using AtelierPro1.dal;
using AtelierPro1.Modele;
using AtelierPro1.Vue;

namespace AtelierPro1.Controleur
{
    public class controle
    {
        /// <summary>
        /// fenêtre d'authentification
        /// </summary>
        private FrmAuthentification frmAuthentification;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public controle()
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
                new FrmPersonnel(this).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Récupère et retourne les infos des membres du personnel provenant de la BDD
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetPersonnel()
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
        public List<Absence> GetAbsence()
        {
            return AccesDonnees.GetLesAbsences();
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
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            AccesDonnees.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdateAbsence(Absence absence)
        {
            AccesDonnees.UpdateAbsence(absence);
        }


    }
}

