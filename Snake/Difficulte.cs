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
        private int tempsDisparitionFruit = 0;           // Indique le nombre de seconde avant la disparition d'un fruit non consommé sur la grille.

 

        public int VitesseSerpent { get => vitesseSerpent; set => vitesseSerpent = value; }

        public int TempsAccelerationSerpent { get => tempsAccelerationSerpent; set => tempsAccelerationSerpent = value; }

        public bool Bordure { get => bordure; set => bordure = value; }

        public int TempsDisparitionFruit { get => tempsDisparitionFruit; set => tempsDisparitionFruit = value; }

        public int calculScoreMultiplicateur()
        {
            int mutiplicateur = 0;

            switch (vitesseSerpent)
            {
                case 5:
                    mutiplicateur += 80;
                    break;
                case 4:
                    mutiplicateur += 60;
                    break;
                case 3:
                    mutiplicateur += 40;
                    break;
                case 2:
                    mutiplicateur += 25;
                    break;
                case 1:
                    mutiplicateur += 15;
                    break;
            }

            if (bordure)
                mutiplicateur += 50;
  

            if (tempsAccelerationSerpent <= 2)
                    mutiplicateur += 80;
            else if (tempsAccelerationSerpent <= 4)
                mutiplicateur += 60;
            else if(tempsAccelerationSerpent <= 6)
                mutiplicateur += 50;
            else if(tempsAccelerationSerpent <= 8)
                mutiplicateur += 40;
            else if(tempsAccelerationSerpent <= 10)
                mutiplicateur += 30;

            if(tempsDisparitionFruit == 0)
                mutiplicateur += 0;
            else if (tempsDisparitionFruit <= 4)
                mutiplicateur += 80;
            else if(tempsDisparitionFruit <= 5)
                mutiplicateur += 60;
            else if (tempsDisparitionFruit <= 6)
                mutiplicateur += 30;
            else if (tempsDisparitionFruit <= 7)
                mutiplicateur += 20;
            else if (tempsDisparitionFruit <= 8)
                mutiplicateur += 10;

            
            return mutiplicateur;
        }
    }
}
