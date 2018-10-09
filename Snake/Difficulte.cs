using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Difficulte
    {
        private int tempsAccelerationSerpent = 5;   // Détermine tous les combien de temps le serpent vas accéléré.
        private int vitesseSerpent = 3;             // Détermine la vitesse du serpent au début de la partie.
        private bool bordure = true;                   // Détermine si les bordures sont présente dans les bords du jeu.
        private int disparitionFruit = 0;           // Indique le nombre de seconde avant la disparition d'un fruit non consommé sur la grille.

 

        public int VitesseSerpent { get => vitesseSerpent; set => vitesseSerpent = value; }

        public int TempsAccelerationSerpent { get => tempsAccelerationSerpent; set => tempsAccelerationSerpent = value; }

        public bool Bordure { get => bordure; set => bordure = value; }

        public int DisparitionFruit { get => disparitionFruit; set => disparitionFruit = value; }

        public int calculScoreMultiplicateur()
        {
            return 100;
        }
    }
}
