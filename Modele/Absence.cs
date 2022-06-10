using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierPro1.Modele
{
    public class Absence
    {
        private int idpersonnel;
        private int idmotif;
        private string motif;
        private object datedebut;
        private object datefin;

        public object Datedebut { get => datedebut; }
        public object Datefin { get => datefin; }
        public int Idpersonnel { get => idpersonnel; }
        public string Motif { get => motif; }
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="motif"></param>

        public Absence(int idpersonnel, object datedebut, object datefin, int idmotif, string motif)
        {
            this.idpersonnel = idpersonnel;
            this.idmotif = idmotif;
            this.motif = motif;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
    }
}
