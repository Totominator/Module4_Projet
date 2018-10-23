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
        FormMenu formMenu;
        Difficulte difficulte;
        Couleurs couleur;
        public FormDifficulte(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            this.difficulte = formMenu.Difficulte;
            couleur = new Couleurs();
            this.BackColor = couleur.CouleurFond;

            trackBar_Vitesse.Value = (int)difficulte.VitesseSerpent;
            num_Acceleration.Value = difficulte.TempsAccelerationSerpent;
            num_TempsFruit.Value = difficulte.TempsDisparitionFruit;
            if (difficulte.Bordure)
                rad_Oui.Checked = difficulte.Bordure;
            else
                rad_Non.Checked = !difficulte.Bordure;
        }

        public void actualiseMultiplicateurAffichage()
        {
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
            switch (trackBar_Vitesse.Value)
            {
                case 2:
                    difficulte.VitesseSerpent = Difficulte.VitesseDeBase.tresRapide;
                    break;
                case 3:
                    difficulte.VitesseSerpent = Difficulte.VitesseDeBase.rapide;
                    break;
                case 4:
                    difficulte.VitesseSerpent = Difficulte.VitesseDeBase.normal;
                    break;
                case 5:
                    difficulte.VitesseSerpent = Difficulte.VitesseDeBase.lent;
                    break;
                case 6:
                    difficulte.VitesseSerpent = Difficulte.VitesseDeBase.tresLent;
                    break;
            }
                actualiseMultiplicateurAffichage();
        }

        private void rad_Oui_CheckedChanged(object sender, EventArgs e)
        {
            difficulte.Bordure = true;
            rad_Non.Checked = !rad_Oui.Checked;
            actualiseMultiplicateurAffichage();
        }

        private void rad_Non_CheckedChanged(object sender, EventArgs e)
        {
            difficulte.Bordure = false;
            rad_Oui.Checked = !rad_Non.Checked;
            actualiseMultiplicateurAffichage();
        }

        private void num_TempsFruit_ValueChanged(object sender, EventArgs e)
        {
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
            difficulte.TempsAccelerationSerpent = (int)num_Acceleration.Value;
            actualiseMultiplicateurAffichage();
        }
    }
}
