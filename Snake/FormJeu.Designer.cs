namespace Snake
{
    partial class FormJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panneauJeu = new System.Windows.Forms.Panel();
            this.lb_Titre = new System.Windows.Forms.Label();
            this.lb_texte_Joueur = new System.Windows.Forms.Label();
            this.bt_CommentJouer = new System.Windows.Forms.Label();
            this.bt_Debut = new System.Windows.Forms.Button();
            this.lb_texte_qteManger = new System.Windows.Forms.Label();
            this.panneauStats = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MeilleurScore = new System.Windows.Forms.Label();
            this.lb_Texte_MeilleurScore = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.lb_Multiplicateur = new System.Windows.Forms.Label();
            this.lb_qteManger = new System.Windows.Forms.Label();
            this.lb_Joueur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Retour = new System.Windows.Forms.Button();
            this.panneauStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panneauJeu
            // 
            this.panneauJeu.Location = new System.Drawing.Point(12, 52);
            this.panneauJeu.Name = "panneauJeu";
            this.panneauJeu.Size = new System.Drawing.Size(600, 600);
            this.panneauJeu.TabIndex = 0;
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.Location = new System.Drawing.Point(12, 18);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(247, 31);
            this.lb_Titre.TabIndex = 1;
            this.lb_Titre.Text = "Snake\'s game V0.1";
            // 
            // lb_texte_Joueur
            // 
            this.lb_texte_Joueur.AutoSize = true;
            this.lb_texte_Joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texte_Joueur.Location = new System.Drawing.Point(629, 52);
            this.lb_texte_Joueur.Name = "lb_texte_Joueur";
            this.lb_texte_Joueur.Size = new System.Drawing.Size(41, 20);
            this.lb_texte_Joueur.TabIndex = 2;
            this.lb_texte_Joueur.Text = "Hi,  ";
            // 
            // bt_CommentJouer
            // 
            this.bt_CommentJouer.AutoSize = true;
            this.bt_CommentJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CommentJouer.Location = new System.Drawing.Point(618, 523);
            this.bt_CommentJouer.Name = "bt_CommentJouer";
            this.bt_CommentJouer.Size = new System.Drawing.Size(179, 20);
            this.bt_CommentJouer.TabIndex = 3;
            this.bt_CommentJouer.Text = "Use \" A S W D \" keys";
            // 
            // bt_Debut
            // 
            this.bt_Debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Debut.Location = new System.Drawing.Point(622, 593);
            this.bt_Debut.Name = "bt_Start";
            this.bt_Debut.Size = new System.Drawing.Size(136, 59);
            this.bt_Debut.TabIndex = 4;
            this.bt_Debut.Text = "START ";
            this.bt_Debut.UseVisualStyleBackColor = true;
            this.bt_Debut.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // lb_texte_qteManger
            // 
            this.lb_texte_qteManger.AutoSize = true;
            this.lb_texte_qteManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texte_qteManger.Location = new System.Drawing.Point(66, 39);
            this.lb_texte_qteManger.Name = "lb_texte_qteManger";
            this.lb_texte_qteManger.Size = new System.Drawing.Size(82, 20);
            this.lb_texte_qteManger.TabIndex = 5;
            this.lb_texte_qteManger.Text = "You ate :";
            // 
            // panneauStats
            // 
            this.panneauStats.Controls.Add(this.label4);
            this.panneauStats.Controls.Add(this.label3);
            this.panneauStats.Controls.Add(this.lb_MeilleurScore);
            this.panneauStats.Controls.Add(this.lb_Texte_MeilleurScore);
            this.panneauStats.Controls.Add(this.lb_Score);
            this.panneauStats.Controls.Add(this.lb_Multiplicateur);
            this.panneauStats.Controls.Add(this.lb_qteManger);
            this.panneauStats.Controls.Add(this.lb_texte_qteManger);
            this.panneauStats.Location = new System.Drawing.Point(630, 126);
            this.panneauStats.Name = "panneauStats";
            this.panneauStats.Size = new System.Drawing.Size(280, 265);
            this.panneauStats.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Actual score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Actual difficulty :";
            // 
            // lb_MeilleurScore
            // 
            this.lb_MeilleurScore.AutoSize = true;
            this.lb_MeilleurScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MeilleurScore.Location = new System.Drawing.Point(153, 221);
            this.lb_MeilleurScore.Name = "lb_MeilleurScore";
            this.lb_MeilleurScore.Size = new System.Drawing.Size(118, 20);
            this.lb_MeilleurScore.TabIndex = 12;
            this.lb_MeilleurScore.Text = "MeilleurScore";
            // 
            // lb_Texte_MeilleurScore
            // 
            this.lb_Texte_MeilleurScore.AutoSize = true;
            this.lb_Texte_MeilleurScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Texte_MeilleurScore.Location = new System.Drawing.Point(10, 221);
            this.lb_Texte_MeilleurScore.Name = "lb_Texte_MeilleurScore";
            this.lb_Texte_MeilleurScore.Size = new System.Drawing.Size(146, 20);
            this.lb_Texte_MeilleurScore.TabIndex = 11;
            this.lb_Texte_MeilleurScore.Text = "Your best score :";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.Location = new System.Drawing.Point(145, 68);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(56, 20);
            this.lb_Score.TabIndex = 10;
            this.lb_Score.Text = "Score";
            // 
            // lb_Multiplicateur
            // 
            this.lb_Multiplicateur.AutoSize = true;
            this.lb_Multiplicateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Multiplicateur.Location = new System.Drawing.Point(151, 9);
            this.lb_Multiplicateur.Name = "lb_Multiplicateur";
            this.lb_Multiplicateur.Size = new System.Drawing.Size(116, 20);
            this.lb_Multiplicateur.TabIndex = 9;
            this.lb_Multiplicateur.Text = "Multiplicateur";
            // 
            // lb_qteManger
            // 
            this.lb_qteManger.AutoSize = true;
            this.lb_qteManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qteManger.Location = new System.Drawing.Point(153, 39);
            this.lb_qteManger.Name = "lb_qteManger";
            this.lb_qteManger.Size = new System.Drawing.Size(95, 20);
            this.lb_qteManger.TabIndex = 6;
            this.lb_qteManger.Text = "qteManger";
            // 
            // lb_Joueur
            // 
            this.lb_Joueur.AutoSize = true;
            this.lb_Joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Joueur.Location = new System.Drawing.Point(654, 52);
            this.lb_Joueur.Name = "lb_Joueur";
            this.lb_Joueur.Size = new System.Drawing.Size(59, 20);
            this.lb_Joueur.TabIndex = 7;
            this.lb_Joueur.Text = "joueur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "for manage the snake";
            // 
            // bt_Retour
            // 
            this.bt_Retour.Location = new System.Drawing.Point(826, 629);
            this.bt_Retour.Name = "bt_Retour";
            this.bt_Retour.Size = new System.Drawing.Size(75, 23);
            this.bt_Retour.TabIndex = 9;
            this.bt_Retour.Text = "Back";
            this.bt_Retour.UseVisualStyleBackColor = true;
            this.bt_Retour.Click += new System.EventHandler(this.bt_Retour_Click);
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 665);
            this.Controls.Add(this.bt_Retour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Joueur);
            this.Controls.Add(this.panneauStats);
            this.Controls.Add(this.bt_Debut);
            this.Controls.Add(this.bt_CommentJouer);
            this.Controls.Add(this.lb_texte_Joueur);
            this.Controls.Add(this.lb_Titre);
            this.Controls.Add(this.panneauJeu);
            this.Name = "FormJeu";
            this.Text = "FormJeu";
            this.panneauStats.ResumeLayout(false);
            this.panneauStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panneauJeu;
        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Label lb_texte_Joueur;
        private System.Windows.Forms.Label bt_CommentJouer;
        private System.Windows.Forms.Button bt_Debut;
        private System.Windows.Forms.Label lb_texte_qteManger;
        private System.Windows.Forms.Panel panneauStats;
        private System.Windows.Forms.Label lb_qteManger;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label lb_Multiplicateur;
        private System.Windows.Forms.Label lb_Joueur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MeilleurScore;
        private System.Windows.Forms.Label lb_Texte_MeilleurScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Retour;
    }
}