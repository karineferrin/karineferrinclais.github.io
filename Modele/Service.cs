using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierPro1.Modele
{
    public class Service
    {
        private int idservice;
        private string nom;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public int Idservice { get => idservice; }
        public string Nom { get => nom; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.nom + this.idservice;
        }

    }
}
