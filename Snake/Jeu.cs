﻿using System;
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
        private int acceleration = 0;
        const int COLONNE = 15;
        const int LIGNE = 15;

        System.Timers.Timer timerJeu;
        System.Timers.Timer timerFruit;
        System.Timers.Timer timerAcceleration;


        FormJeu formJeu;
        FormMenu formMenu;
        public enum TypeCollision
        {
            RAS,
            Fruit,
            Fin
        }
        private TypeCollision collision_ = TypeCollision.RAS;        // Détermine l'état actuel de la case

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


        /// <summary>
        /// 
        /// </summary>
        public Jeu(FormJeu formJeu, FormMenu formMenu)
        {
            this.formJeu = formJeu;
            this.formMenu = formMenu;

            creationGrille();
            creationSerpent();
            gestionFruit(null, null);
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
                            Grille[iLigne, iColonne].changerEtatCase(Case.Etat.bordure);
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
                Grille[liste[0], liste[1]].changerEtatCase(Case.Etat.serpent);
            }
        }

        /// <summary>
        /// Détermine l'emplacement du futur fruit 
        /// </summary>
        /// <returns>coordonnée du fruit</returns>
        private void gestionFruit(object sender, EventArgs e)
        {
            if (Grille[coordFruit[0], coordFruit[1]].Etat1 == Case.Etat.fruit)
            {
                Grille[coordFruit[0], coordFruit[1]].Etat1 = Case.Etat.vide;
                formJeu.actualiseFruitAffichage(coordFruit, false);
            }

            Random tirageFruit = new Random();
            do
            {
                coordFruit[0] = tirageFruit.Next(LIGNE);
                coordFruit[1] = tirageFruit.Next(COLONNE);
            } while (Grille[coordFruit[0], coordFruit[1]].Etat1 != Case.Etat.vide);

            Grille[coordFruit[0], coordFruit[1]].Etat1 = Case.Etat.fruit;

            if (formJeu.TabInit)
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
                    Grille[serpent.First()[0], serpent.First()[1]].changerEtatCase(Case.Etat.vide); // transforme la queue du serpent en vide
                    Grille[serpent.Last()[0], serpent.Last()[1]].changerEtatCase(Case.Etat.serpent);  // crée la nouvelle tête du serpent 

                formJeu.actualiseSerpentAffichage(new int[] { serpent.Last()[0], serpent.Last()[1] },
                                                  new int[] { serpent.First()[0], serpent.First()[1] });
                    serpent.RemoveAt(0);
                    break;
                case TypeCollision.Fruit:
                    Grille[serpent.Last()[0], serpent.Last()[1]].changerEtatCase(Case.Etat.serpent);  // crée la nouvelle tête du serpent 
                                       
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
            timerJeu.Stop();
            if (formMenu.Difficulte.DisparitionFruit > 0)
                timerFruit.Stop();
            timerAcceleration.Stop();
        }

        /// <summary>
        /// 
        /// </summary>
        private TypeCollision gestionCollision()
        {
            TypeCollision Etatcollision = TypeCollision.RAS;
            switch (Grille[serpent.Last()[0], serpent.Last()[1]].Etat1)
            {
                case Case.Etat.vide:
                    break;
                case Case.Etat.fruit:
                    QteFruitManger++;
                    formJeu.actualiseScoreAffichage();
                    gestionFruit(null, null);
                    Etatcollision = TypeCollision.Fruit;
                    break;
                case Case.Etat.bordure:
                case Case.Etat.serpent:
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
            if ((formMenu.Difficulte.VitesseSerpent * 100 - acceleration) > 10)
            {
                timerJeu.Stop();
                timerJeu.Interval = formMenu.Difficulte.VitesseSerpent * 100 - acceleration;
                Acceleration += 10;
                timerJeu.Start();
                formJeu.actualiseVitesseAffichage();
            }
            else
            {
                timerAcceleration.Stop();
            }
        }

        public void lancerTimerAcceleration()
        {
            timerAcceleration = new System.Timers.Timer();
            timerAcceleration.Interval = formMenu.Difficulte.TempsAccelerationSerpent * 100;
            timerAcceleration.Elapsed += new ElapsedEventHandler(changementVitesse);
            timerAcceleration.Start();
        }

        public void lanceTimerJeu()
        {
            timerJeu = new System.Timers.Timer();
            timerJeu.Interval = formMenu.Difficulte.VitesseSerpent * 100;
            timerJeu.Elapsed += new ElapsedEventHandler(avancerSerpent);
            timerJeu.Start();
        }

        public void lanceTimerFruit()
        {
            timerFruit = new System.Timers.Timer();
            timerFruit.Interval = formMenu.Difficulte.DisparitionFruit * 1000;
            timerFruit.Elapsed += new ElapsedEventHandler(gestionFruit);
            timerFruit.Start();
        }


        public int Acceleration { get => acceleration; set => acceleration = value; }
        internal Case[,] Grille { get => grille; set => grille = value; }
        public int QteFruitManger { get => qteFruitManger; set => qteFruitManger = value; }
    }
}
