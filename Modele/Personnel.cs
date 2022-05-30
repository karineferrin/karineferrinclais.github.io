using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierPro1.Modele
{
    public class Personnel
        {
            private int idpersonnel;
            private string nom;
            private string prenom;
            private string tel;
            private string mail;
            private int idservice;

            public int Idpersonnel { get => idpersonnel; }
            public string Nom { get => nom; }
            public string Prenom { get => prenom; }
            public string Tel { get => tel; }
            public string Mail { get => mail; }
            public int Idservice { get => idservice; }

            /// <summary>
            /// Constructeur : valorise les propriétés
            /// </summary>
            /// <param name="idpersonnel"></param>
            /// <param name="nom"></param>
            /// <param name="prenom"></param>
            /// <param name="tel"></param>
            /// <param name="mail"></param>
            /// <param name="idservice"></param>
            public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
            {
                this.idpersonnel = idpersonnel;
                this.nom = nom;
                this.prenom = prenom;
                this.tel = tel;
                this.mail = mail;
                this.idservice = idservice;
            }
            /// <summary>
            /// Définit l'information à afficher (le nom et le prenom)
            /// </summary>
            /// <returns>nom et prenom du personnel</returns>
            public override string ToString()
            {
                  return this.nom + this.prenom;
            }

    }
}

