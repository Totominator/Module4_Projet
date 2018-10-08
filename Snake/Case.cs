using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Case
    {
        /// <summary>
        /// Définsi les états possible d'une case
        /// </summary>
        public enum Etat
        {
            vide,
            bordure,
            serpent,
            fruit,
        }


        private Etat etat = Etat.vide;          // Détermine l'état actuel de la case

        internal Etat Etat1
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }



        /// <summary>
        /// Modifie l'état d'une case
        /// </summary>
        /// <param name="nouvelEtat">Indique le nouvel état de la case</param>
        public void changerEtatCase(Etat nouvelEtat)
        {
            Etat1 = nouvelEtat;
        }
    }
}
