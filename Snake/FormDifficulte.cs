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
    public partial class FormDifficulte : Form
    {
        FormMenu formMenu;      // Menu principal
        Difficulte difficulte;  // Difficulté 
        Couleurs couleur;       // Themes de couleur de l'application

        public FormDifficulte(FormMenu formMenu)
        {
            InitializeComponent();
            // Initialise l'affichage
            this.formMenu = formMenu;
            this.difficulte = formMenu.Difficulte;
            couleur = new Couleurs();
            this.BackColor = couleur.CouleurFond;

            // Affiches les données de difficulté
            trackBar_Vitesse.Value = (int)difficulte.VitesseSerpent;
            num_Acceleration.Value = difficulte.TempsAccelerationSerpent;
            num_TempsFruit.Value = difficulte.TempsDisparitionFruit;
            if (difficulte.Bordure)
                rad_Oui.Checked = difficulte.Bordure;
            else
                rad_Non.Checked = !difficulte.Bordure;
        }

        /// <summary>
        /// Affiche le multiplicateur avec une couleur en fonction de sa valeur
        /// </summary>
        public void actualiseMultiplicateurAffichage()
        {
            // Modifie la couleur d'affichage de multiplicateur
            if (difficulte.calculScoreMultiplicateur() >= 200)
                lb_Multiplicateur.ForeColor = Color.Red;
            else if (difficulte.calculScoreMultiplicateur() >= 180)
                lb_Multiplicateur.ForeColor = Color.Yellow;
            else 
                lb_Multiplicateur.ForeColor = Color.DarkGreen;

            lb_Multiplicateur.Text = Convert.ToString(difficulte.calculScoreMultiplicateur()) + "%";
        }


        private void trackBar_Vitesse_Scroll(object sender, EventArgs e)
        {
            // Fais correspondre la réponse de l'utilisateur à la vitesse du serpent
            difficulte.gestionVitesseSerpent(trackBar_Vitesse.Value);
            

            actualiseMultiplicateurAffichage();
        }

        private void rad_Oui_CheckedChanged(object sender, EventArgs e)
        {
            // Fais correspondre le choix de l'utilisateur aux données
            difficulte.Bordure = true;

            rad_Non.Checked = !rad_Oui.Checked;
            actualiseMultiplicateurAffichage();
        }

        private void rad_Non_CheckedChanged(object sender, EventArgs e)
        {
            // Fais correspondre le choix de l'utilisateur aux données
            difficulte.Bordure = false;

            rad_Oui.Checked = !rad_Non.Checked;
            actualiseMultiplicateurAffichage();
        }

        private void num_TempsFruit_ValueChanged(object sender, EventArgs e)
        {
            // Fais correspondre le choix de l'utilisateur aux données
            difficulte.TempsDisparitionFruit = (int)num_TempsFruit.Value;

            actualiseMultiplicateurAffichage();
        }

        private void bt_Retour_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }


        private void num_Acceleration_ValueChanged_1(object sender, EventArgs e)
        {
            // Fais correspondre le choix de l'utilisateur aux données
            difficulte.TempsAccelerationSerpent = (int)num_Acceleration.Value;

            actualiseMultiplicateurAffichage();
        }
    }
}
