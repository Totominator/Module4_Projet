using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Snake
{
    class Couleurs
    {
        Color couleurSerpent = Color.FromArgb(71, 117, 235);    // bleu clair
        Color couleurFruit = Color.FromArgb(232, 72, 29);       // rouge pomme
        Color couleurCaseFonce = Color.FromArgb(150, 209, 60);  // vert case fonce
        Color couleurCaseClair = Color.FromArgb(170, 215, 81);  // vert case clair
        Color couleurBordure = Color.FromArgb(87, 138, 52);     // vert bordure fonce
        Color couleurInterface = Color.FromArgb(74, 117, 44);   // vert fonce
        Color couleurFond = Color.FromArgb(118, 187, 72);       // vert clair

        public Color CouleurFruit
        {
            get
            {
                return couleurFruit;
            }

            set
            {
                couleurFruit = value;
            }
        }

        public Color CouleurCaseFonce
        {
            get
            {
                return couleurCaseFonce;
            }

            set
            {
                couleurCaseFonce = value;
            }
        }

        public Color CouleurCaseClair
        {
            get
            {
                return couleurCaseClair;
            }

            set
            {
                couleurCaseClair = value;
            }
        }

        public Color CouleurBordure
        {
            get
            {
                return couleurBordure;
            }

            set
            {
                couleurBordure = value;
            }
        }

        public Color CouleurInterface
        {
            get
            {
                return couleurInterface;
            }

            set
            {
                couleurInterface = value;
            }
        }

        public Color CouleurFond
        {
            get
            {
                return couleurFond;
            }

            set
            {
                couleurFond = value;
            }
        }

        public Color CouleurSerpent
        {
            get
            {
                return couleurSerpent;
            }

            set
            {
                couleurSerpent = value;
            }
        }
    }
}
