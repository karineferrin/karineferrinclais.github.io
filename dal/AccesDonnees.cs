using AtelierPro1.Connexion;
using AtelierPro1.Modele;
using System;
using System.Collections.Generic;

namespace AtelierPro1.dal
{
    /// <summary>
    /// Classe AccesDonnees permettant de gérer les demandes concernant les données distantes 
    /// </summary>
    public class AccesDonnees
    {
        private static string connectionString = "server=localhost;user id=root;database=atelier2pro;SslMode=none";
        /// <summary>
        /// Controle si l'utilisateur a le droit de se connecter (login, pwd dans  "responsable")
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable r ";
            req += " where r.login=@login and r.pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBdd curs = ConnexionBdd.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }
        /// <summary>
        /// Récupère et retourne les membres du personnel provenant de la BDD
        /// </summary>
        /// <returns>liste des membres du personnel</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service";
            req += " from personnel p join service s on (p.idservice = s.idservice) ";
            req += " order by p.nom, p.prenom;";
            ConnexionBdd curs = ConnexionBdd.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service order by nom;";
            ConnexionBdd curs = ConnexionBdd.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }

        /// <summary>
        /// Suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public static void DelPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBdd conn = ConnexionBdd.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajoute un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice, service) ";
            req += " values (@nom, @prenom, @tel, @mail, @idservice, @service);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            parameters.Add("@service", personnel.Service);
            ConnexionBdd conn = ConnexionBdd.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice, service = @service";
            req += " where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            parameters.Add("@service", personnel.Service);
            ConnexionBdd conn = ConnexionBdd.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// Récupère et retourne les absences provenant de la BDD
        /// </summary>
        /// <returns>liste des absences</returns>
        public static List<Absence> GetLesAbsences(int idpersonnelSelect)
        {

            List<Absence> lesAbsences = new List<Absence>();
            string req = "select p.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, m.motif as motif ";
            req += " from personnel p join absence a on (p.idpersonnel = a.idpersonnel) join motif m on (a.idmotif = m.idmotif)";
            req += " where p.idpersonnel = @idpersonnelSelect ";
            req += " order by datedebut DESC";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnelSelect", idpersonnelSelect);
            ConnexionBdd curs = ConnexionBdd.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            while (curs.Read())
            {
                Absence absence = new Absence((int)curs.Field("idpersonnel"), (object)curs.Field("datedebut"), (object)curs.Field("datefin"), (int)curs.Field("idmotif"), (string)curs.Field("motif"));
                lesAbsences.Add(absence);
            }
            curs.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public static List<Motifs> GetLesMotifs()
        {
            List<Motifs> lesMotifs = new List<Motifs>();
            string req = "select * from motif order by motif;";
            ConnexionBdd curs = ConnexionBdd.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Motifs motif = new Motifs((int)curs.Field("idmotif"), (string)curs.Field("motif"));
                lesMotifs.Add(motif);
            }
            curs.Close();
            return lesMotifs;
        }
        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence">objet personnel à supprimer</param>
        public static void DelAbsence(Absence absence, int idpersonnelSelect)
        {
            string req = "delete from absence where datedebut = @datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            ConnexionBdd conn = ConnexionBdd.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence (Absence absence, int idpersonnelSelect)
        {
            string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
            req += " values (@idpersonnelSelect, @datedebut, @datefin, @idmotif)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnelSelect", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBdd conn = ConnexionBdd.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdateAbsence(Absence absence, int idpersonnelSelect, DateTime dateSelect)
        {
            string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif";
            req += " where idpersonnel = @idpersonnelSelect && datedebut = @dateSelect";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@dateSelect", dateSelect);
            parameters.Add("@idpersonnelSelect", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idmotif", absence.Idmotif);
  
            ConnexionBdd conn = ConnexionBdd.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
    }
}
