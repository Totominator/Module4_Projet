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
            this.lb_Joueur = new System.Windows.Forms.Label();
            this.bt_CommentJouer = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.lb_texte_qteManger = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_qteManger = new System.Windows.Forms.Label();
            this.lb_texte_Vitesse = new System.Windows.Forms.Label();
            this.lb_Vitesse = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // lb_Joueur
            // 
            this.lb_Joueur.AutoSize = true;
            this.lb_Joueur.Location = new System.Drawing.Point(695, 18);
            this.lb_Joueur.Name = "lb_Joueur";
            this.lb_Joueur.Size = new System.Drawing.Size(61, 13);
            this.lb_Joueur.TabIndex = 2;
            this.lb_Joueur.Text = "Hi, player X";
            // 
            // bt_CommentJouer
            // 
            this.bt_CommentJouer.AutoSize = true;
            this.bt_CommentJouer.Location = new System.Drawing.Point(688, 208);
            this.bt_CommentJouer.Name = "bt_CommentJouer";
            this.bt_CommentJouer.Size = new System.Drawing.Size(69, 13);
            this.bt_CommentJouer.TabIndex = 3;
            this.bt_CommentJouer.Text = "How to play :";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(630, 80);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 4;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // lb_texte_qteManger
            // 
            this.lb_texte_qteManger.AutoSize = true;
            this.lb_texte_qteManger.Location = new System.Drawing.Point(3, 21);
            this.lb_texte_qteManger.Name = "lb_texte_qteManger";
            this.lb_texte_qteManger.Size = new System.Drawing.Size(42, 13);
            this.lb_texte_qteManger.TabIndex = 5;
            this.lb_texte_qteManger.Text = "Points :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Vitesse);
            this.panel1.Controls.Add(this.lb_texte_Vitesse);
            this.panel1.Controls.Add(this.lb_qteManger);
            this.panel1.Controls.Add(this.lb_texte_qteManger);
            this.panel1.Location = new System.Drawing.Point(630, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 152);
            this.panel1.TabIndex = 6;
            // 
            // lb_qteManger
            // 
            this.lb_qteManger.AutoSize = true;
            this.lb_qteManger.Location = new System.Drawing.Point(52, 21);
            this.lb_qteManger.Name = "lb_qteManger";
            this.lb_qteManger.Size = new System.Drawing.Size(0, 13);
            this.lb_qteManger.TabIndex = 6;
            // 
            // lb_texte_Vitesse
            // 
            this.lb_texte_Vitesse.AutoSize = true;
            this.lb_texte_Vitesse.Location = new System.Drawing.Point(1, 34);
            this.lb_texte_Vitesse.Name = "lb_texte_Vitesse";
            this.lb_texte_Vitesse.Size = new System.Drawing.Size(44, 13);
            this.lb_texte_Vitesse.TabIndex = 7;
            this.lb_texte_Vitesse.Text = "Speed :";
            // 
            // lb_Vitesse
            // 
            this.lb_Vitesse.AutoSize = true;
            this.lb_Vitesse.Location = new System.Drawing.Point(52, 34);
            this.lb_Vitesse.Name = "lb_Vitesse";
            this.lb_Vitesse.Size = new System.Drawing.Size(0, 13);
            this.lb_Vitesse.TabIndex = 8;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.bt_CommentJouer);
            this.Controls.Add(this.lb_Joueur);
            this.Controls.Add(this.lb_Titre);
            this.Controls.Add(this.panneauJeu);
            this.Name = "FormJeu";
            this.Text = "FormJeu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panneauJeu;
        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Label lb_Joueur;
        private System.Windows.Forms.Label bt_CommentJouer;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Label lb_texte_qteManger;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_qteManger;
        private System.Windows.Forms.Label lb_texte_Vitesse;
        private System.Windows.Forms.Label lb_Vitesse;
    }
}