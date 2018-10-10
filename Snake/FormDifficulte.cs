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
        public FormDifficulte(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            this.difficulte = formMenu.Difficulte;
            if (difficulte.Bordure)
                rad_Oui.Checked = difficulte.Bordure;
            else
                rad_Non.Checked = !difficulte.Bordure;
        }

        public void actualiseMultiplicateurAffichage()
        {
            lb_Multiplicateur.Text = Convert.ToString(difficulte.calculScoreMultiplicateur()) + "%";
        }


        private void trackBar_Vitesse_Scroll(object sender, EventArgs e)
        {
            difficulte.VitesseSerpent = trackBar_Vitesse.Value;
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

        private void num_Acceleration_ValueChanged(object sender, EventArgs e)
        {
            difficulte.TempsAccelerationSerpent = (int)num_Acceleration.Value;
            actualiseMultiplicateurAffichage();
        }

        private void num_TempsFruit_ValueChanged(object sender, EventArgs e)
        {
            difficulte.DisparitionFruit = (int)num_TempsFruit.Value;
            actualiseMultiplicateurAffichage();
        }

        private void bt_Retour_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }
    }
}
