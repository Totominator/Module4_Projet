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

        /// <summary>
        /// Trie les joueurs par meilleur score
        /// </summary>
        /// <returns>Joueurs trié par meilleur score</returns>
        private List<Joueur> trierParMeilleurScore()
        {
            List<Joueur> joueursTrie = new List<Joueur>();
            joueursTrie = listeJoueurs;
            bool tableauTrie = false;

            // Tri à bulle optimisé
            for (int indexJoueur = listeJoueurs.Count ; indexJoueur > 0; indexJoueur--)
            {
                tableauTrie = true;
                for(int indexTri = 0; indexTri < indexJoueur -1; indexTri++)
                    if(joueursTrie[indexTri+1].MeilleurScore > joueursTrie[indexTri].MeilleurScore)
                    {
                        Joueur joueurTntermediaire = new Joueur();
                        joueurTntermediaire = joueursTrie[indexTri];
                        joueursTrie[indexTri] = joueursTrie[indexTri + 1];
                        joueursTrie[indexTri + 1] = joueurTntermediaire;
                        tableauTrie = false;
                    }
                if(tableauTrie)
                    indexJoueur = 0;
            }
            return joueursTrie;
        }

        /// <summary>
        /// Affiche les score des joueurs
        /// </summary>
        private void afficheHallOfFame()
        {
            List<Joueur> joueursTrie = new List<Joueur>();
            joueursTrie = trierParMeilleurScore();

            for (int index = 0; index < joueursTrie.Count ; index++)
            {
                Label lbCase = new Label();
                lbCase.Location = new System.Drawing.Point(0, 30 * index);
                lbCase.Name = "label" + panneau_HallOfFame.Controls.Count;
                lbCase.Text = joueursTrie[index].Nom + " " + joueursTrie[index].MeilleurScore+ " " + joueursTrie[index].MultiplicateurScore;

                panneau_HallOfFame.Controls.Add(lbCase);

                // Affiche que 10 joueurs 
                if (index == 10)
                    index = joueursTrie.Count;
            }
        }
        
        // Sauvegardes les joueurs dans XML
        private void bt_Quit_Click(object sender, EventArgs e)
        {
            Joueur.supprimeJoueursXML();
            foreach(Joueur element in ListeJoueurs)
            {
                Joueur.ajoutJoueurXML(element.Nom, element.MeilleurScore, element.MultiplicateurScore);
            }
            this.Close();
        }

        /// <summary>
        /// Propriété d'objet joueur
        /// </summary>
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

        /// <summary>
        /// Propriété d'objet difficulté
        /// </summary>
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

        /// <summary>
        /// Propriété de la liste des joueurs
        /// </summary>
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
