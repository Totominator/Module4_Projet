﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake
{
    public partial class FormMenu : Form
    {
        Joueur joueur;
        Difficulte difficulte;
        List<Joueur> listeJoueurs;


        public FormMenu()
        {
            InitializeComponent();
            Joueur = new Joueur();
            difficulte = new Difficulte();
            ListeJoueurs = joueur.recuperationJoueurs();
            afficheHallOfFame();
            
        }

        private void bt_Play_Click(object sender, EventArgs e)
        {
            FormJeu formJeu = new FormJeu(this);
            formJeu.Show();
            this.Hide();
        }

        private void bt_Difficulty_Click(object sender, EventArgs e)
        {

        }

        private void bt_Players_Click(object sender, EventArgs e)
        {
            FormJoueur formJoueur = new FormJoueur(this);
            formJoueur.Show();
            this.Hide();
        }

        private void afficheHallOfFame()
        {
            for (int index = 0; index < 3; index++)
            {
                Label lbCase = new Label();
                lbCase.Location = new System.Drawing.Point(0, 30 * index);
                lbCase.Name = "label" + panneau_HallOfFame.Controls.Count;
                lbCase.Text = ListeJoueurs[index].Nom + " " +ListeJoueurs[index].MeilleurScore+ " " +ListeJoueurs[index].MultiplicateurScore;

                panneau_HallOfFame.Controls.Add(lbCase);
            }
        }
        

        private void bt_Quit_Click(object sender, EventArgs e)
        {

        }
        internal Joueur Joueur
        {
            get
            {
                return joueur;
            }

            set
            {
                joueur = value;
            }
        }

        internal List<Joueur> ListeJoueurs
        {
            get
            {
                return listeJoueurs;
            }

            set
            {
                listeJoueurs = value;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
