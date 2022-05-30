using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierPro1.Modele
{
    public class Absence
    {
        private int idpersonnel;
        private int idmotif;
        private DateTime datedebut;
        private DateTime datefin;

        public DateTime Datedebut { get => datedebut; }
        public DateTime Datefin { get => datefin; }
        public int Idpersonnel { get => idpersonnel; }
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>

        public Absence(int idpersonnel, int idmotif, DateTime datedebut, DateTime datefin)
        {
            this.idpersonnel = idpersonnel;
            this.idmotif = idmotif;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
    }
}
