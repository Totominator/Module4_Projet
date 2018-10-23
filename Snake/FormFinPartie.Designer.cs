namespace Snake
{
    partial class FormFinPartie
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
            this.lb_Joueur = new System.Windows.Forms.Label();
            this.lb_Multiplicateur = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.lb_qteFruit = new System.Windows.Forms.Label();
            this.lb_Texte_BJ = new System.Windows.Forms.Label();
            this.lb_Texte_1 = new System.Windows.Forms.Label();
            this.lb_Texte_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Rejouer = new System.Windows.Forms.Button();
            this.bt_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Joueur
            // 
            this.lb_Joueur.AutoSize = true;
            this.lb_Joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Joueur.Location = new System.Drawing.Point(129, 9);
            this.lb_Joueur.Name = "lb_Joueur";
            this.lb_Joueur.Size = new System.Drawing.Size(78, 25);
            this.lb_Joueur.TabIndex = 0;
            this.lb_Joueur.Text = "joueur";
            // 
            // lb_Multiplicateur
            // 
            this.lb_Multiplicateur.AutoSize = true;
            this.lb_Multiplicateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Multiplicateur.Location = new System.Drawing.Point(197, 79);
            this.lb_Multiplicateur.Name = "lb_Multiplicateur";
            this.lb_Multiplicateur.Size = new System.Drawing.Size(24, 20);
            this.lb_Multiplicateur.TabIndex = 1;
            this.lb_Multiplicateur.Text = "%";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.Location = new System.Drawing.Point(197, 50);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(53, 20);
            this.lb_Score.TabIndex = 2;
            this.lb_Score.Text = "score";
            // 
            // lb_qteFruit
            // 
            this.lb_qteFruit.AutoSize = true;
            this.lb_qteFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qteFruit.Location = new System.Drawing.Point(197, 109);
            this.lb_qteFruit.Name = "lb_qteFruit";
            this.lb_qteFruit.Size = new System.Drawing.Size(72, 20);
            this.lb_qteFruit.TabIndex = 3;
            this.lb_qteFruit.Text = "qteFruit";
            // 
            // lb_Texte_BJ
            // 
            this.lb_Texte_BJ.AutoSize = true;
            this.lb_Texte_BJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Texte_BJ.Location = new System.Drawing.Point(12, 9);
            this.lb_Texte_BJ.Name = "lb_Texte_BJ";
            this.lb_Texte_BJ.Size = new System.Drawing.Size(111, 25);
            this.lb_Texte_BJ.TabIndex = 4;
            this.lb_Texte_BJ.Text = "Bien joué";
            // 
            // lb_Texte_1
            // 
            this.lb_Texte_1.AutoSize = true;
            this.lb_Texte_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Texte_1.Location = new System.Drawing.Point(14, 50);
            this.lb_Texte_1.Name = "lb_Texte_1";
            this.lb_Texte_1.Size = new System.Drawing.Size(61, 20);
            this.lb_Texte_1.TabIndex = 5;
            this.lb_Texte_1.Text = "Score ";
            // 
            // lb_Texte_2
            // 
            this.lb_Texte_2.AutoSize = true;
            this.lb_Texte_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Texte_2.Location = new System.Drawing.Point(12, 79);
            this.lb_Texte_2.Name = "lb_Texte_2";
            this.lb_Texte_2.Size = new System.Drawing.Size(139, 20);
            this.lb_Texte_2.TabIndex = 6;
            this.lb_Texte_2.Text = "avec la difficulté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "en mangeant";
            // 
            // bt_Rejouer
            // 
            this.bt_Rejouer.Location = new System.Drawing.Point(201, 160);
            this.bt_Rejouer.Name = "bt_Rejouer";
            this.bt_Rejouer.Size = new System.Drawing.Size(75, 23);
            this.bt_Rejouer.TabIndex = 8;
            this.bt_Rejouer.Text = "Rejouer";
            this.bt_Rejouer.UseVisualStyleBackColor = true;
            this.bt_Rejouer.Click += new System.EventHandler(this.bt_Rejouer_Click);
            // 
            // bt_Menu
            // 
            this.bt_Menu.Location = new System.Drawing.Point(76, 160);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(75, 23);
            this.bt_Menu.TabIndex = 9;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // FormFinPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 219);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Menu);
            this.Controls.Add(this.bt_Rejouer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Texte_2);
            this.Controls.Add(this.lb_Texte_1);
            this.Controls.Add(this.lb_Texte_BJ);
            this.Controls.Add(this.lb_qteFruit);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.lb_Multiplicateur);
            this.Controls.Add(this.lb_Joueur);
            this.Name = "FormFinPartie";
            this.Text = "End of the game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Joueur;
        private System.Windows.Forms.Label lb_Multiplicateur;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label lb_qteFruit;
        private System.Windows.Forms.Label lb_Texte_BJ;
        private System.Windows.Forms.Label lb_Texte_1;
        private System.Windows.Forms.Label lb_Texte_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Rejouer;
        private System.Windows.Forms.Button bt_Menu;
    }
}