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
        Color couleurSerpent = Color.FromArgb(71, 117, 235);    // bleu clair
        Color couleurFruit = Color.FromArgb(232, 72, 29);       // rouge pomme
        Color couleurCaseFonce =  Color.FromArgb(150, 209, 60); // vert case fonce
        Color couleurCaseClair = Color.FromArgb(170, 215, 81);  // vert case clair
        Color couleurBordure = Color.FromArgb(87, 138, 52);     // vert bordure fonce

        FormMenu formMenu;
        Jeu jeu;

        internal Jeu Jeu { get => jeu; set => jeu = value; }

        public FormJeu(FormMenu formMenu)
        {
            InitializeComponent();

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Start_Click(object sender, EventArgs e)
        {
            bt_Start.Enabled = false;
            panneauJeu.Focus();
            Jeu.lanceTimerJeu();
            Jeu.lancerTimerAcceleration();

            if (formMenu.Difficulte.DisparitionFruit > 0)
                Jeu.lanceTimerFruit();
        }

        public void finDePartie()
        {
            FormFinPartie formFinDePartie = new FormFinPartie(formMenu, this);
            formFinDePartie.Show();
            this.Hide();
        }

        private void changerCouleur(Case.TypeCase typeCase, int indexPanneau)
        {
            switch (typeCase) { 
                case Case.TypeCase.vide:
                    if (indexPanneau % 2 == 0)
                        panneauJeu.Controls[indexPanneau].BackColor = couleurCaseClair;
                    else
                        panneauJeu.Controls[indexPanneau].BackColor = couleurCaseFonce;
                break;
                case Case.TypeCase.fruit:
                    panneauJeu.Controls[indexPanneau].BackColor = couleurFruit;
                    break;
                case Case.TypeCase.serpent:
                    panneauJeu.Controls[indexPanneau].BackColor = couleurSerpent;
                    break;
                case Case.TypeCase.bordure:
                    (panneauJeu.Controls[indexPanneau] as Label).BorderStyle = BorderStyle.None;
                    panneauJeu.Controls[indexPanneau].BackColor = couleurBordure;
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
                lb_Points.Text = Convert.ToString(Jeu.QteFruitManger * (formMenu.Difficulte.calculScoreMultiplicateur()) / 100);
            }));
        }

        public void actualiseVitesseAffichage()
        {
            lb_Vitesse.Invoke(new MethodInvoker(delegate
            {
                lb_Vitesse.Text = Jeu.Acceleration.ToString();
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

    }
}