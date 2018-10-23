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
    public partial class FormJoueur : Form
    {
        FormMenu formMenu;
        Joueur joueur;
        Couleurs couleur;

        public FormJoueur(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            this.joueur = formMenu.Joueur;
            couleur = new Couleurs();
            actualiseAffichageComboBox();

            this.BackColor = couleur.CouleurFond;
        }

        private void actualiseAffichageComboBox()
        {
            cbBox_Selectionne.Items.Clear();
            cbBox_Supprime.Items.Clear();
            foreach (Joueur joueur in formMenu.ListeJoueurs)
            {
                cbBox_Selectionne.Items.Add(joueur.Nom);
                cbBox_Supprime.Items.Add(joueur.Nom);
            }
            cbBox_Supprime.Refresh();
            cbBox_Selectionne.Refresh();
        }

        private void bt_Retour_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        private void bt_Creer_Click(object sender, EventArgs e)
        {
            joueur.ajouterJoueur(formMenu.ListeJoueurs, txBox_Cree.Text);
            actualiseAffichageComboBox();
        }

        private void bt_Supprime_Click(object sender, EventArgs e)
        {
            joueur.supprimerJoueur(formMenu.ListeJoueurs, cbBox_Supprime.SelectedIndex);
            cbBox_Supprime.ResetText();
            
            if (cbBox_Supprime.SelectedIndex == cbBox_Selectionne.SelectedIndex)
                cbBox_Selectionne.ResetText();

            actualiseAffichageComboBox();
        }

        private void cbBox_Selectionne_SelectedIndexChanged(object sender, EventArgs e)
        {
            formMenu.Joueur = formMenu.ListeJoueurs[cbBox_Selectionne.SelectedIndex];
        }
    }
}
