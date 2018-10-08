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
        FormMenu formMenu;
        Jeu jeu;
        private bool tabInit = false;

        public FormJeu(FormMenu formMenu)
        {
            InitializeComponent();

            this.formMenu = formMenu;
            jeu = new Jeu(this);


            for (int iColonne = 0; iColonne <= COLONNE - 1; iColonne++)
            {
                for (int iLigne = 0; iLigne <= LIGNE - 1; iLigne++)
                {
                    Label lbCase = new Label();
                    lbCase.Location = new System.Drawing.Point(30 * iLigne, 30 * iColonne);
                    lbCase.Name = "label" + panneauJeu.Controls.Count;
                    lbCase.Size = new System.Drawing.Size(30, 30);

                    switch (jeu.Grille[iLigne, iColonne].Etat1)
                    {
                        case Case.Etat.vide:
                            lbCase.BackColor = Color.WhiteSmoke;
                            break;
                        case Case.Etat.bordure:
                            lbCase.BackColor = Color.Gray;
                            break;
                        case Case.Etat.serpent:
                            lbCase.BackColor = Color.LightGreen;
                            break;
                        case Case.Etat.fruit:
                            lbCase.BackColor = Color.Red;
                            break;
                    }
                    lbCase.BorderStyle = BorderStyle.Fixed3D;
                    lbCase.TabIndex = 0;
                    panneauJeu.Controls.Add(lbCase);

                }
            }
            TabInit = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Start_Click(object sender, EventArgs e)
        {
            bt_Start.Select();
           // bt_Start.Visible = false;
            jeu.lanceTimerJeu();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="majSerpent"></param>
        public void actualiseSerpentAffichage(int[,] majSerpent)
        {
            int index = majSerpent[0, 0] + majSerpent[0, 1] * LIGNE;

           panneauJeu.Controls[index].BackColor = Color.WhiteSmoke;

          index = majSerpent[1, 0] + majSerpent[1, 1] * LIGNE;

            panneauJeu.Controls[index].BackColor = Color.LightGreen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="majFruit"></param>
        public void actualiseFruitAffichage(int[] majFruit)
        {
            int index = majFruit[0] + majFruit[1] * LIGNE;

            panneauJeu.Controls[index].BackColor = Color.Red;
        }



        public void actualiseScoreAffichage()
        {
            lb_qteManger.Invoke(new MethodInvoker(delegate
            {
                lb_qteManger.Text = jeu.QteFruitManger.ToString();
            }));
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Start_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    jeu.changerDirection(Direction.haut);
                    break;
                case 's':
                    jeu.changerDirection(Direction.bas);
                    break;
                case 'a':
                    jeu.changerDirection(Direction.gauche);
                    break;
                case 'd':
                    jeu.changerDirection(Direction.droite);
                    break;
            }
        }

  

        public bool TabInit
        {
            get
            {
                return tabInit;
            }

            set
            {
                tabInit = value;
            }
        }
    }
}