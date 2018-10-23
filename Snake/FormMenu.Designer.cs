namespace Snake
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Play = new System.Windows.Forms.Button();
            this.bt_Players = new System.Windows.Forms.Button();
            this.bt_Difficulty = new System.Windows.Forms.Button();
            this.bt_Quit = new System.Windows.Forms.Button();
            this.lb_HallofFame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panneau_HallOfFame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bt_Play
            // 
            this.bt_Play.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Play.Location = new System.Drawing.Point(22, 106);
            this.bt_Play.Name = "bt_Play";
            this.bt_Play.Size = new System.Drawing.Size(94, 23);
            this.bt_Play.TabIndex = 0;
            this.bt_Play.Text = "Play at the game";
            this.bt_Play.UseVisualStyleBackColor = false;
            this.bt_Play.Click += new System.EventHandler(this.bt_Play_Click);
            // 
            // bt_Players
            // 
            this.bt_Players.Location = new System.Drawing.Point(22, 135);
            this.bt_Players.Name = "bt_Players";
            this.bt_Players.Size = new System.Drawing.Size(94, 23);
            this.bt_Players.TabIndex = 1;
            this.bt_Players.Text = "Manage players";
            this.bt_Players.UseVisualStyleBackColor = true;
            this.bt_Players.Click += new System.EventHandler(this.bt_Players_Click);
            // 
            // bt_Difficulty
            // 
            this.bt_Difficulty.Location = new System.Drawing.Point(22, 164);
            this.bt_Difficulty.Name = "bt_Difficulty";
            this.bt_Difficulty.Size = new System.Drawing.Size(94, 23);
            this.bt_Difficulty.TabIndex = 2;
            this.bt_Difficulty.Text = "Chose difficulty";
            this.bt_Difficulty.UseVisualStyleBackColor = true;
            this.bt_Difficulty.Click += new System.EventHandler(this.bt_Difficulty_Click);
            // 
            // bt_Quit
            // 
            this.bt_Quit.Location = new System.Drawing.Point(22, 239);
            this.bt_Quit.Name = "bt_Quit";
            this.bt_Quit.Size = new System.Drawing.Size(94, 23);
            this.bt_Quit.TabIndex = 3;
            this.bt_Quit.Text = "Quit the game";
            this.bt_Quit.UseVisualStyleBackColor = true;
            this.bt_Quit.Click += new System.EventHandler(this.bt_Quit_Click);
            // 
            // lb_HallofFame
            // 
            this.lb_HallofFame.AutoSize = true;
            this.lb_HallofFame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HallofFame.ForeColor = System.Drawing.Color.White;
            this.lb_HallofFame.Location = new System.Drawing.Point(147, 72);
            this.lb_HallofFame.Name = "lb_HallofFame";
            this.lb_HallofFame.Size = new System.Drawing.Size(174, 31);
            this.lb_HallofFame.TabIndex = 4;
            this.lb_HallofFame.Text = "Hall of Fame ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Snake\'s game";
            // 
            // panneau_HallOfFame
            // 
            this.panneau_HallOfFame.ForeColor = System.Drawing.Color.White;
            this.panneau_HallOfFame.Location = new System.Drawing.Point(153, 106);
            this.panneau_HallOfFame.Name = "panneau_HallOfFame";
            this.panneau_HallOfFame.Size = new System.Drawing.Size(168, 154);
            this.panneau_HallOfFame.TabIndex = 6;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 395);
            this.ControlBox = false;
            this.Controls.Add(this.panneau_HallOfFame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_HallofFame);
            this.Controls.Add(this.bt_Quit);
            this.Controls.Add(this.bt_Difficulty);
            this.Controls.Add(this.bt_Players);
            this.Controls.Add(this.bt_Play);
            this.Name = "FormMenu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Play;
        private System.Windows.Forms.Button bt_Players;
        private System.Windows.Forms.Button bt_Difficulty;
        private System.Windows.Forms.Button bt_Quit;
        private System.Windows.Forms.Label lb_HallofFame;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panneau_HallOfFame;
    }
}

