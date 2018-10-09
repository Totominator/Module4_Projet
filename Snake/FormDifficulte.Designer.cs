namespace Snake
{
    partial class FormDifficulte
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
            this.components = new System.ComponentModel.Container();
            this.lb_Titre = new System.Windows.Forms.Label();
            this.lb_Vitesse = new System.Windows.Forms.Label();
            this.lb_DisparitionFruit = new System.Windows.Forms.Label();
            this.lb_Acceleration = new System.Windows.Forms.Label();
            this.bt_Bordure = new System.Windows.Forms.Label();
            this.rad_Oui = new System.Windows.Forms.RadioButton();
            this.rad_Non = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_Retour = new System.Windows.Forms.Button();
            this.trackBar_Vitesse = new System.Windows.Forms.TrackBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.num_TempsFruit = new System.Windows.Forms.NumericUpDown();
            this.num_Acceleration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Vitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TempsFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Acceleration)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.Location = new System.Drawing.Point(12, 19);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(335, 31);
            this.lb_Titre.TabIndex = 0;
            this.lb_Titre.Text = "Create your own difficulty !";
            // 
            // lb_Vitesse
            // 
            this.lb_Vitesse.AutoSize = true;
            this.lb_Vitesse.Location = new System.Drawing.Point(95, 81);
            this.lb_Vitesse.Name = "lb_Vitesse";
            this.lb_Vitesse.Size = new System.Drawing.Size(44, 13);
            this.lb_Vitesse.TabIndex = 1;
            this.lb_Vitesse.Text = "Speed :";
            // 
            // lb_DisparitionFruit
            // 
            this.lb_DisparitionFruit.AutoSize = true;
            this.lb_DisparitionFruit.Location = new System.Drawing.Point(63, 128);
            this.lb_DisparitionFruit.Name = "lb_DisparitionFruit";
            this.lb_DisparitionFruit.Size = new System.Drawing.Size(81, 13);
            this.lb_DisparitionFruit.TabIndex = 2;
            this.lb_DisparitionFruit.Text = "Timelife of fruit :";
            // 
            // lb_Acceleration
            // 
            this.lb_Acceleration.AutoSize = true;
            this.lb_Acceleration.Location = new System.Drawing.Point(3, 161);
            this.lb_Acceleration.Name = "lb_Acceleration";
            this.lb_Acceleration.Size = new System.Drawing.Size(141, 13);
            this.lb_Acceleration.TabIndex = 3;
            this.lb_Acceleration.Text = "Time between acceleration :";
            // 
            // bt_Bordure
            // 
            this.bt_Bordure.AutoSize = true;
            this.bt_Bordure.Location = new System.Drawing.Point(95, 197);
            this.bt_Bordure.Name = "bt_Bordure";
            this.bt_Bordure.Size = new System.Drawing.Size(49, 13);
            this.bt_Bordure.TabIndex = 4;
            this.bt_Bordure.Text = "Borders :";
            // 
            // rad_Oui
            // 
            this.rad_Oui.AutoSize = true;
            this.rad_Oui.Location = new System.Drawing.Point(210, 195);
            this.rad_Oui.Name = "rad_Oui";
            this.rad_Oui.Size = new System.Drawing.Size(43, 17);
            this.rad_Oui.TabIndex = 5;
            this.rad_Oui.TabStop = true;
            this.rad_Oui.Text = "Yes";
            this.rad_Oui.UseVisualStyleBackColor = true;
            this.rad_Oui.CheckedChanged += new System.EventHandler(this.rad_Oui_CheckedChanged);
            // 
            // rad_Non
            // 
            this.rad_Non.AutoSize = true;
            this.rad_Non.Location = new System.Drawing.Point(292, 195);
            this.rad_Non.Name = "rad_Non";
            this.rad_Non.Size = new System.Drawing.Size(39, 17);
            this.rad_Non.TabIndex = 6;
            this.rad_Non.TabStop = true;
            this.rad_Non.Text = "No";
            this.rad_Non.UseVisualStyleBackColor = true;
            this.rad_Non.CheckedChanged += new System.EventHandler(this.rad_Non_CheckedChanged);
            // 
            // bt_Retour
            // 
            this.bt_Retour.Location = new System.Drawing.Point(237, 248);
            this.bt_Retour.Name = "bt_Retour";
            this.bt_Retour.Size = new System.Drawing.Size(99, 23);
            this.bt_Retour.TabIndex = 7;
            this.bt_Retour.Text = "Save and return";
            this.bt_Retour.UseVisualStyleBackColor = true;
            this.bt_Retour.Click += new System.EventHandler(this.bt_Retour_Click);
            // 
            // trackBar_Vitesse
            // 
            this.trackBar_Vitesse.AutoSize = false;
            this.trackBar_Vitesse.Location = new System.Drawing.Point(204, 71);
            this.trackBar_Vitesse.Maximum = 5;
            this.trackBar_Vitesse.Minimum = 1;
            this.trackBar_Vitesse.Name = "trackBar_Vitesse";
            this.trackBar_Vitesse.Size = new System.Drawing.Size(126, 32);
            this.trackBar_Vitesse.TabIndex = 8;
            this.trackBar_Vitesse.Value = 5;
            this.trackBar_Vitesse.Scroll += new System.EventHandler(this.trackBar_Vitesse_Scroll);
            // 
            // num_TempsFruit
            // 
            this.num_TempsFruit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_TempsFruit.Location = new System.Drawing.Point(210, 128);
            this.num_TempsFruit.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.num_TempsFruit.Name = "num_TempsFruit";
            this.num_TempsFruit.Size = new System.Drawing.Size(120, 20);
            this.num_TempsFruit.TabIndex = 11;
            this.num_TempsFruit.ValueChanged += new System.EventHandler(this.num_TempsFruit_ValueChanged);
            // 
            // num_Acceleration
            // 
            this.num_Acceleration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Acceleration.Location = new System.Drawing.Point(210, 161);
            this.num_Acceleration.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_Acceleration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Acceleration.Name = "num_Acceleration";
            this.num_Acceleration.Size = new System.Drawing.Size(120, 20);
            this.num_Acceleration.TabIndex = 12;
            this.num_Acceleration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormDifficulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 300);
            this.Controls.Add(this.num_Acceleration);
            this.Controls.Add(this.num_TempsFruit);
            this.Controls.Add(this.trackBar_Vitesse);
            this.Controls.Add(this.bt_Retour);
            this.Controls.Add(this.rad_Non);
            this.Controls.Add(this.rad_Oui);
            this.Controls.Add(this.bt_Bordure);
            this.Controls.Add(this.lb_Acceleration);
            this.Controls.Add(this.lb_DisparitionFruit);
            this.Controls.Add(this.lb_Vitesse);
            this.Controls.Add(this.lb_Titre);
            this.Name = "FormDifficulte";
            this.Text = "FormDifficulte";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Vitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TempsFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Acceleration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Label lb_Vitesse;
        private System.Windows.Forms.Label lb_DisparitionFruit;
        private System.Windows.Forms.Label lb_Acceleration;
        private System.Windows.Forms.Label bt_Bordure;
        private System.Windows.Forms.RadioButton rad_Oui;
        private System.Windows.Forms.RadioButton rad_Non;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_Retour;
        private System.Windows.Forms.TrackBar trackBar_Vitesse;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown num_TempsFruit;
        private System.Windows.Forms.NumericUpDown num_Acceleration;
    }
}