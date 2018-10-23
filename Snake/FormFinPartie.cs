using System;
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
    public partial class FormFinPartie : Form
    {
        FormMenu formMenu;
        FormJeu formJeu;

        public FormFinPartie(FormMenu formMenu, FormJeu formJeu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            this.formJeu = formJeu;
            Couleurs couleur = new Couleurs();

            lb_Joueur.Text = formMenu.Joueur.Nom;
            lb_Multiplicateur.Text = Convert.ToString(formMenu.Difficulte.calculScoreMultiplicateur());
            lb_qteFruit.Text = formJeu.Jeu.QteFruitManger.ToString();
            lb_Score.Text = Convert.ToString(formJeu.Jeu.QteFruitManger * formMenu.Difficulte.calculScoreMultiplicateur() / 100);

            this.BackColor = couleur.CouleurFond;

            gestionScore();
        }

        private void gestionScore()
        {
            if (formMenu.Joueur.Nom != "Player")
                if (formJeu.Jeu.QteFruitManger * formMenu.Difficulte.calculScoreMultiplicateur() / 100 > formMenu.Joueur.MeilleurScore)
                {
                    formMenu.Joueur.MeilleurScore = formJeu.Jeu.QteFruitManger * formMenu.Difficulte.calculScoreMultiplicateur() / 100;
                    formMenu.Joueur.MultiplicateurScore = formMenu.Difficulte.calculScoreMultiplicateur();
                }
        }

        private void bt_Rejouer_Click(object sender, EventArgs e)
        {
            formMenu.lancerPartie();
            this.Close();
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            formJeu.Close();
            this.Close();
        }
    }
}
