using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    /// <summary>
    /// Définis des valeurs pour les directions du serpent
    /// </summary>
    public enum Direction
    {
        haut,
        bas,
        droite,
        gauche
    }

    /// <summary>
    /// 
    /// </summary>
    class Jeu
    {
        private Case[,] grille;               // Créer la grille de jeu

        private Direction directionSerpent = Direction.droite;  // direction du serpent   
        private Direction ancienneDirection = Direction.droite; // direction du dernier déplacement

        //    private int[] posTeteSerpent = new int[]{7,6} ;      // L'emplacement de la tête du serpent
        private List<List<int>> serpent = new List<List<int>> { };

        private int[] coordFruit = new int[2];

        private int qteFruitManger = 0;                             // Indique la quantité de fruit mangé par le serpent
        private int accelerationIncrement = 10; // accélération du serpent a chaque tic en ms
        private int accelerationDepuisDebut = 0;
        const int COLONNE = 15;
        const int LIGNE = 15;

        System.Timers.Timer timerJeu;
        System.Timers.Timer timerFruit;
        System.Timers.Timer timerAcceleration;

        FormJeu formJeu;
        FormMenu formMenu;
        public enum TypeCollision
        {
            RAS, // rien à signaler
            Fruit,
            Fin
        }
        private TypeCollision collision_ = TypeCollision.RAS;        // Détermine l'état actuel de la case

        /// <summary>
        /// 
        /// </summary>
        public Jeu(FormJeu formJeu, FormMenu formMenu)
        {
            this.formJeu = formJeu;
            this.formMenu = formMenu;

            creationGrille();
            creationSerpent();
            creationFruit();
        }

        /// <summary>
        /// Change la direction du serpent
        /// </summary>
        /// <param name="directionSerpent">Nouvelle direction du serpent</param>
        public void changerDirection(Direction directionSerpent)
        {
            switch (directionSerpent)
            {
                case Direction.haut:
                    if (ancienneDirection != Direction.bas)
                        this.directionSerpent = directionSerpent;
                    break;
                case Direction.bas:
                    if (ancienneDirection != Direction.haut)
                        this.directionSerpent = directionSerpent;
                    break;
                case Direction.droite:
                    if (ancienneDirection != Direction.gauche)
                        this.directionSerpent = directionSerpent;
                    break;
                case Direction.gauche:
                    if (ancienneDirection != Direction.droite)
                        this.directionSerpent = directionSerpent;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void creationGrille()
        {
            Grille = new Case[LIGNE, COLONNE];

            for (int iColonne = 0; iColonne <= COLONNE - 1; iColonne++)
            {
                for (int iLigne = 0; iLigne <= LIGNE - 1; iLigne++)
                {
                    Grille[iLigne, iColonne] = new Case();
                    if (formMenu.Difficulte.Bordure)
                    {
                        if (iLigne == 0 || iLigne == LIGNE - 1 || iColonne == 0 || iColonne == COLONNE - 1)
                            Grille[iLigne, iColonne].changerEtatCase(Case.TypeCase.bordure);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void creationSerpent()
        {
            serpent.Add(new List<int> { 6, 7 });
            serpent.Add(new List<int> { 7, 7 });
            serpent.Add(new List<int> { 8, 7 });

            foreach (List<int> liste in serpent)
            {
                Grille[liste[0], liste[1]].changerEtatCase(Case.TypeCase.serpent);
            }
        }

        private void creationFruit()
        {
            tirageFruit();
            Grille[coordFruit[0], coordFruit[1]].Etat = Case.TypeCase.fruit;
        }

        private void tirageFruit()
        {
            Random tirageFruit = new Random();
            do
            {
                coordFruit[0] = tirageFruit.Next(LIGNE);
                coordFruit[1] = tirageFruit.Next(COLONNE);
            } while (Grille[coordFruit[0], coordFruit[1]].Etat != Case.TypeCase.vide);
        }

        /// <summary>
        /// Détermine l'emplacement du futur fruit 
        /// </summary>
        /// <returns>coordonnée du fruit</returns>
        private void gestionFruit(object sender, EventArgs e)
        {
            int[] ancienneCoord = new int[] { coordFruit[0], coordFruit[1] }; 

            Console.WriteLine(coordFruit[0].ToString() + " " + coordFruit[1].ToString());

            tirageFruit();

            Grille[coordFruit[0], coordFruit[1]].Etat = Case.TypeCase.fruit;

            Grille[ancienneCoord[0], ancienneCoord[1]].Etat = Case.TypeCase.vide;

            formJeu.actualiseFruitAffichage(ancienneCoord, false);
            formJeu.actualiseFruitAffichage(coordFruit, true);
        }

        /// <summary>
        /// 
        /// </summary>
        public void avancerSerpent(object sender, EventArgs e)
        {
                switch (directionSerpent)
            {
                case Direction.haut:
                    serpent.Add(new List<int> { serpent.Last()[0], moduloPositif((serpent.Last()[1] - 1),COLONNE) });
                    break;
                case Direction.bas:
                    serpent.Add(new List<int> { serpent.Last()[0], (serpent.Last()[1] + 1) % COLONNE});
                    break;
                case Direction.gauche:
                    serpent.Add(new List<int> { moduloPositif((serpent.Last()[0] - 1), LIGNE), serpent.Last()[1] });
                    break;
                case Direction.droite:
                    serpent.Add(new List<int> { (serpent.Last()[0] + 1) % LIGNE, serpent.Last()[1] });
                    break;
            }
            ancienneDirection = directionSerpent;

            //   Actualise l'emplacement de la tête et de la queue du serpent
            TypeCollision collision;
            switch(collision = gestionCollision())
            {
                case TypeCollision.RAS:
                    Grille[serpent.First()[0], serpent.First()[1]].changerEtatCase(Case.TypeCase.vide); // transforme la queue du serpent en vide
                    Grille[serpent.Last()[0], serpent.Last()[1]].changerEtatCase(Case.TypeCase.serpent);  // crée la nouvelle tête du serpent 

                formJeu.actualiseSerpentAffichage(new int[] { serpent.Last()[0], serpent.Last()[1] },
                                                  new int[] { serpent.First()[0], serpent.First()[1] });
                    serpent.RemoveAt(0);
                    break;
                case TypeCollision.Fruit:
                    Grille[serpent.Last()[0], serpent.Last()[1]].changerEtatCase(Case.TypeCase.serpent);  // crée la nouvelle tête du serpent 
                                       
                    formJeu.actualiseSerpentAffichage(new int[] { serpent.Last()[0], serpent.Last()[1] });
                    break;
                case TypeCollision.Fin:
                    arretPartie();                    
                    break;
            }
        }

        static public int moduloPositif(int i, int n)
        {
            return (i % n + n) % n;
        }

        private void arretPartie()
        {
            TimerJeu.Stop();
            if (formMenu.Difficulte.TempsDisparitionFruit > 0)
                TimerFruit.Stop();
            TimerAcceleration.Stop();

            formJeu.finDePartie();
        }

        /// <summary>
        /// 
        /// </summary>
        private TypeCollision gestionCollision()
        {
            TypeCollision Etatcollision = TypeCollision.RAS;
            switch (Grille[serpent.Last()[0], serpent.Last()[1]].Etat)
            {
                case Case.TypeCase.vide:
                    break;
                case Case.TypeCase.fruit:
                    QteFruitManger++;
                    formJeu.actualiseScoreAffichage();
                    gestionFruit(null, null);
                    if (formMenu.Difficulte.TempsDisparitionFruit > 0)
                    {
                        TimerFruit.Stop();
                        TimerFruit.Start();
                    }
                    Etatcollision = TypeCollision.Fruit;
                    break;
                case Case.TypeCase.bordure:
                case Case.TypeCase.serpent:
                    Etatcollision = TypeCollision.Fin;
                    break;
            }
            return Etatcollision;
        }


        /// <summary>
        /// 
        /// </summary>
        private void calculScore()
        {
        }

        private void changementVitesse(object sender, EventArgs e)
        {
            if (((int)formMenu.Difficulte.VitesseSerpent * 100 - accelerationDepuisDebut) > 100)
            {
                TimerJeu.Interval = (int)formMenu.Difficulte.VitesseSerpent * 100 - accelerationIncrement;
                accelerationDepuisDebut += accelerationIncrement;
            }
            else
            {
                TimerAcceleration.Stop();
            }
        }

        public void lancerTimerAcceleration()
        {
            TimerAcceleration = new System.Timers.Timer();
            TimerAcceleration.Interval = formMenu.Difficulte.TempsAccelerationSerpent * 1000;
            TimerAcceleration.Elapsed += new ElapsedEventHandler(changementVitesse);
            TimerAcceleration.Start();
        }

        public void lanceTimerJeu()
        {
            TimerJeu = new System.Timers.Timer();
            TimerJeu.Interval = (int)formMenu.Difficulte.VitesseSerpent * 100;
            TimerJeu.Elapsed += new ElapsedEventHandler(avancerSerpent);
            TimerJeu.Start();
        }

        public void lanceTimerFruit()
        {
            TimerFruit = new System.Timers.Timer();
            TimerFruit.Interval = formMenu.Difficulte.TempsDisparitionFruit * 1000;
            TimerFruit.Elapsed += new ElapsedEventHandler(gestionFruit);
            TimerFruit.Start();
        }

        internal TypeCollision Collision
        {
            get
            {
                return collision_;
            }

            set
            {
                collision_ = value;
            }
        }

        public int QteFruitManger
        {
            get
            {
                return qteFruitManger;
            }

            set
            {
                qteFruitManger = value;
            }
        }

        internal Case[,] Grille
        {
            get
            {
                return grille;
            }

            set
            {
                grille = value;
            }
        }

        public Timer TimerJeu
        {
            get
            {
                return timerJeu;
            }

            set
            {
                timerJeu = value;
            }
        }

        public Timer TimerFruit
        {
            get
            {
                return timerFruit;
            }

            set
            {
                timerFruit = value;
            }
        }

        public Timer TimerAcceleration
        {
            get
            {
                return timerAcceleration;
            }

            set
            {
                timerAcceleration = value;
            }
        }

    }
}
