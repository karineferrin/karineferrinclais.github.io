using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierPro1.Modele
{
    public class Motifs
    {
        private int idmotif;
        private string motif;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="motif"></param>
        public Motifs(int idmotif, string motif)
        {
            this.idmotif = idmotif;
            this.motif = motif;
        }

        public int Idmotif { get => idmotif; }
        public string Motif { get => motif; }

        /// <summary>
        /// Définit l'information à afficher (juste le motif)
        /// </summary>
        /// <returns>motif</returns>
        public override string ToString()
        {
            return this.motif;
        }
    }
}
