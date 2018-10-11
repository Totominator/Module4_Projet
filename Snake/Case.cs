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
        public enum TypeCase
        {
            vide,
            bordure,
            serpent,
            fruit,
        }

        private TypeCase etat = TypeCase.vide;          // Détermine l'état actuel de la case

        internal TypeCase Etat { get => etat; set => etat = value; }

        /// <summary>
        /// Modifie l'état d'une case
        /// </summary>
        /// <param name="nouvelEtat">Indique le nouvel état de la case</param>
        public void changerEtatCase(TypeCase nouvelEtat)
        {
             Etat = nouvelEtat;
        }
    }
}
