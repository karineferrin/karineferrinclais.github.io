using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierPro1.Modele
{
    class Responsable
    {
        private string login;
        private string pwd;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public string Login { get => login; }
        public string Pwd { get => pwd; }

        /// <summary>
        /// Définit l'information à afficher (login et pwd)
        /// </summary>
        /// <returns>login + pwd</returns>
        public override string ToString()
        {
            return this.login + this.pwd;
        }
    }
}
