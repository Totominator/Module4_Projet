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
    public partial class FormMenu : Form
    {
        Joueur joueur;
        Difficulte difficulte;
        List<Joueur> listeJoueurs;
        Couleurs couleur;

        public FormMenu()
        {
            InitializeComponent();
            Joueur = new Joueur();
            Difficulte = new Difficulte();
            ListeJoueurs = Joueur.recuperationJoueurs();
            couleur = new Couleurs();
            afficheHallOfFame();
            this.lb_Joueur.Text = Joueur.Nom;

            this.BackColor = couleur.CouleurFond;
        }

        private void bt_Play_Click(object sender, EventArgs e)
        {
            lancerPartie();
            this.Hide();
        }

        public void lancerPartie()
        {
            FormJeu formJeu = new FormJeu(this);
            formJeu.Show();
        }

        private void bt_Difficulty_Click(object sender, EventArgs e)
        {
            FormDifficulte formDifficulte = new FormDifficulte(this);
            formDifficulte.Show();
            this.Hide();
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
            Joueur.supprimeJoueursXML();
            foreach(Joueur element in ListeJoueurs)
            {
                Joueur.ajoutJoueurXML(element.Nom, element.MeilleurScore, element.MultiplicateurScore);
            }
            this.Close();
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

        internal Difficulte Difficulte
        {
            get
            {
                return difficulte;
            }

            set
            {
                difficulte = value;
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
    }
}
