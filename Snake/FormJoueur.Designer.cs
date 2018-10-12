namespace Snake
{
    partial class FormJoueur
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
            this.lb_SelectPlayer = new System.Windows.Forms.Label();
            this.lb_CreatePlayer = new System.Windows.Forms.Label();
            this.lb_DeletePlayer = new System.Windows.Forms.Label();
            this.lb_Titre = new System.Windows.Forms.Label();
            this.cbBox_Selectionne = new System.Windows.Forms.ComboBox();
            this.cbBox_Supprime = new System.Windows.Forms.ComboBox();
            this.txBox_Cree = new System.Windows.Forms.TextBox();
            this.bt_Creer = new System.Windows.Forms.Button();
            this.bt_Supprime = new System.Windows.Forms.Button();
            this.bt_Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_SelectPlayer
            // 
            this.lb_SelectPlayer.AutoSize = true;
            this.lb_SelectPlayer.ForeColor = System.Drawing.Color.White;
            this.lb_SelectPlayer.Location = new System.Drawing.Point(29, 71);
            this.lb_SelectPlayer.Name = "lb_SelectPlayer";
            this.lb_SelectPlayer.Size = new System.Drawing.Size(92, 13);
            this.lb_SelectPlayer.TabIndex = 0;
            this.lb_SelectPlayer.Text = "Select the player :";
            // 
            // lb_CreatePlayer
            // 
            this.lb_CreatePlayer.AutoSize = true;
            this.lb_CreatePlayer.ForeColor = System.Drawing.Color.White;
            this.lb_CreatePlayer.Location = new System.Drawing.Point(29, 95);
            this.lb_CreatePlayer.Name = "lb_CreatePlayer";
            this.lb_CreatePlayer.Size = new System.Drawing.Size(84, 13);
            this.lb_CreatePlayer.TabIndex = 1;
            this.lb_CreatePlayer.Text = "Create a player :";
            // 
            // lb_DeletePlayer
            // 
            this.lb_DeletePlayer.AutoSize = true;
            this.lb_DeletePlayer.ForeColor = System.Drawing.Color.White;
            this.lb_DeletePlayer.Location = new System.Drawing.Point(29, 120);
            this.lb_DeletePlayer.Name = "lb_DeletePlayer";
            this.lb_DeletePlayer.Size = new System.Drawing.Size(84, 13);
            this.lb_DeletePlayer.TabIndex = 2;
            this.lb_DeletePlayer.Text = "Delete a player :";
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.ForeColor = System.Drawing.Color.White;
            this.lb_Titre.Location = new System.Drawing.Point(26, 18);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(218, 31);
            this.lb_Titre.TabIndex = 3;
            this.lb_Titre.Text = "Players manager";
            // 
            // cbBox_Selectionne
            // 
            this.cbBox_Selectionne.FormattingEnabled = true;
            this.cbBox_Selectionne.Location = new System.Drawing.Point(142, 71);
            this.cbBox_Selectionne.Name = "cbBox_Selectionne";
            this.cbBox_Selectionne.Size = new System.Drawing.Size(121, 21);
            this.cbBox_Selectionne.TabIndex = 4;
            this.cbBox_Selectionne.SelectedIndexChanged += new System.EventHandler(this.cbBox_Selectionne_SelectedIndexChanged);
            // 
            // cbBox_Supprime
            // 
            this.cbBox_Supprime.FormattingEnabled = true;
            this.cbBox_Supprime.Location = new System.Drawing.Point(142, 120);
            this.cbBox_Supprime.Name = "cbBox_Supprime";
            this.cbBox_Supprime.Size = new System.Drawing.Size(121, 21);
            this.cbBox_Supprime.TabIndex = 5;
            // 
            // txBox_Cree
            // 
            this.txBox_Cree.Location = new System.Drawing.Point(142, 95);
            this.txBox_Cree.Name = "txBox_Cree";
            this.txBox_Cree.Size = new System.Drawing.Size(121, 20);
            this.txBox_Cree.TabIndex = 6;
            // 
            // bt_Creer
            // 
            this.bt_Creer.Location = new System.Drawing.Point(269, 95);
            this.bt_Creer.Name = "bt_Creer";
            this.bt_Creer.Size = new System.Drawing.Size(53, 20);
            this.bt_Creer.TabIndex = 7;
            this.bt_Creer.Text = "Create";
            this.bt_Creer.UseVisualStyleBackColor = true;
            this.bt_Creer.Click += new System.EventHandler(this.bt_Creer_Click);
            // 
            // bt_Supprime
            // 
            this.bt_Supprime.Location = new System.Drawing.Point(269, 120);
            this.bt_Supprime.Name = "bt_Supprime";
            this.bt_Supprime.Size = new System.Drawing.Size(53, 20);
            this.bt_Supprime.TabIndex = 9;
            this.bt_Supprime.Text = "Delete";
            this.bt_Supprime.UseVisualStyleBackColor = true;
            this.bt_Supprime.Click += new System.EventHandler(this.bt_Supprime_Click);
            // 
            // bt_Retour
            // 
            this.bt_Retour.Location = new System.Drawing.Point(247, 168);
            this.bt_Retour.Name = "bt_Retour";
            this.bt_Retour.Size = new System.Drawing.Size(75, 23);
            this.bt_Retour.TabIndex = 10;
            this.bt_Retour.Text = "Return";
            this.bt_Retour.UseVisualStyleBackColor = true;
            this.bt_Retour.Click += new System.EventHandler(this.bt_Retour_Click);
            // 
            // FormJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 220);
            this.Controls.Add(this.bt_Retour);
            this.Controls.Add(this.bt_Supprime);
            this.Controls.Add(this.bt_Creer);
            this.Controls.Add(this.txBox_Cree);
            this.Controls.Add(this.cbBox_Supprime);
            this.Controls.Add(this.cbBox_Selectionne);
            this.Controls.Add(this.lb_Titre);
            this.Controls.Add(this.lb_DeletePlayer);
            this.Controls.Add(this.lb_CreatePlayer);
            this.Controls.Add(this.lb_SelectPlayer);
            this.Name = "FormJoueur";
            this.Text = "FormJoueur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SelectPlayer;
        private System.Windows.Forms.Label lb_CreatePlayer;
        private System.Windows.Forms.Label lb_DeletePlayer;
        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.ComboBox cbBox_Selectionne;
        private System.Windows.Forms.ComboBox cbBox_Supprime;
        private System.Windows.Forms.TextBox txBox_Cree;
        private System.Windows.Forms.Button bt_Creer;
        private System.Windows.Forms.Button bt_Supprime;
        private System.Windows.Forms.Button bt_Retour;
    }
}