using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;


namespace Snake
{
    public partial class FormJeu : Form
    {
        const int COLONNE = 15;
        const int LIGNE = 15;

        Couleurs couleur = new Couleurs();

        FormMenu formMenu;
        Jeu jeu;

        public FormJeu(FormMenu formMenu)
        {
            InitializeComponent();
            this.BackColor = couleur.CouleurFond;
            panneauStats.BackColor = couleur.CouleurInterface;
          
           
            this.formMenu = formMenu;
            Jeu = new Jeu(this, formMenu);

            for (int iColonne = 0; iColonne <= COLONNE - 1; iColonne++)
            {
                for (int iLigne = 0; iLigne <= LIGNE - 1; iLigne++)
                {
                    Label lbCase = new Label();
                    lbCase.Location = new System.Drawing.Point(30 * iLigne, 30 * iColonne);
                    lbCase.Name = "label" + panneauJeu.Controls.Count;
                    lbCase.Size = new System.Drawing.Size(30, 30);

                    panneauJeu.Controls.Add(lbCase);

                    lbCase.BorderStyle = BorderStyle.Fixed3D;
                    lbCase.TabIndex = 0;

                    int indexPanneau = iLigne + iColonne * LIGNE;
                    changerCouleur(Jeu.Grille[iLigne, iColonne].Etat, indexPanneau);
                }
            }
            (panneauJeu as Control).KeyPress += new KeyPressEventHandler(FormJeu_KeyPress);

            lb_Joueur.Text = formMenu.Joueur.Nom;
            lb_Multiplicateur.Text = Convert.ToString(formMenu.Difficulte.calculScoreMultiplicateur());
            lb_Score.Text = Convert.ToString(formMenu.Joueur.MeilleurScore);

            
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Start_Click(object sender, EventArgs e)
        {
            bt_Debut.Enabled = false;
            bt_Retour.Enabled = false;
            panneauJeu.Focus();
            Jeu.lanceTimerJeu();
            Jeu.lancerTimerAcceleration();

            if (formMenu.Difficulte.TempsDisparitionFruit > 0)
                Jeu.lanceTimerFruit();
        }

        public void finDePartie()
        {
            FormFinPartie formFinDePartie = new FormFinPartie(formMenu, this);
            this.Invoke(new MethodInvoker(delegate
            {
                formFinDePartie.Show();
                this.Close();
            }));
            
        }

        private void changerCouleur(Case.TypeCase typeCase, int indexPanneau)
        {
            switch (typeCase) { 
                case Case.TypeCase.vide:
                    if (indexPanneau % 2 == 0)
                        panneauJeu.Controls[indexPanneau].BackColor = couleur.CouleurCaseClair;
                    else
                        panneauJeu.Controls[indexPanneau].BackColor = couleur.CouleurCaseFonce;
                break;
                case Case.TypeCase.fruit:
                    panneauJeu.Controls[indexPanneau].BackColor = couleur.CouleurFruit;
                    break;
                case Case.TypeCase.serpent:
                    panneauJeu.Controls[indexPanneau].BackColor = couleur.CouleurSerpent;
                    break;
                case Case.TypeCase.bordure:
                    (panneauJeu.Controls[indexPanneau] as Label).BorderStyle = BorderStyle.None;
                    panneauJeu.Controls[indexPanneau].BackColor = couleur.CouleurBordure;
                    break;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tete"></param>
        /// <param name="tail"></param>
        public void actualiseSerpentAffichage(int[] tete, int [] queue = null)
        {
           int indexPanneau = tete[0] + tete[1] * LIGNE;

            changerCouleur(Case.TypeCase.serpent, indexPanneau);

            if (queue != null)
            {
                indexPanneau = queue[0] + queue[1] * LIGNE;
                changerCouleur(Case.TypeCase.vide, indexPanneau);
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="majFruit"></param>
       /// <param name="choix">Affiche le fruit ou l'enlève l'affichage</param>
        public void actualiseFruitAffichage(int[] majFruit, bool choix)
        {
            int indexPanneau = majFruit[0] + majFruit[1] * LIGNE;

            if (choix)
                changerCouleur(Case.TypeCase.fruit, indexPanneau);
            else
                changerCouleur(Case.TypeCase.vide, indexPanneau);
        }

        public void actualiseScoreAffichage()
        {
            lb_qteManger.Invoke(new MethodInvoker(delegate
            {
                lb_qteManger.Text = Jeu.QteFruitManger.ToString();
            }));

            lb_qteManger.Invoke(new MethodInvoker(delegate
            {
                lb_Score.Text = Convert.ToString(Jeu.QteFruitManger * (formMenu.Difficulte.calculScoreMultiplicateur()) / 100);
            }));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormJeu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys keyPressed;
            if (Enum.TryParse<Keys>(e.KeyChar.ToString(), true, out keyPressed)){
                switch (keyPressed)
                {
                case Keys.W:
                    Jeu.changerDirection(Direction.haut);
                    break;
                case Keys.S:
                    Jeu.changerDirection(Direction.bas);
                    break;
                case Keys.A:
                    Jeu.changerDirection(Direction.gauche);
                    break;
                case Keys.D:
                    Jeu.changerDirection(Direction.droite);
                    break;
                }
            }
        }

        private void bt_Retour_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        internal Jeu Jeu { get => jeu; set => jeu = value; }
    }
}