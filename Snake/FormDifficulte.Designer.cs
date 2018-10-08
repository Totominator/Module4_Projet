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
            this.lb_Titre = new System.Windows.Forms.Label();
            this.lb_Vitesse = new System.Windows.Forms.Label();
            this.lb_DisparitionFruit = new System.Windows.Forms.Label();
            this.lb_Acceleration = new System.Windows.Forms.Label();
            this.bt_Bordure = new System.Windows.Forms.Label();
            this.radbt_Oui = new System.Windows.Forms.RadioButton();
            this.radbt_No = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_SaveReturn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.lb_Acceleration.Click += new System.EventHandler(this.lb_Acceleration_Click);
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
            // radbt_Oui
            // 
            this.radbt_Oui.AutoSize = true;
            this.radbt_Oui.Location = new System.Drawing.Point(210, 195);
            this.radbt_Oui.Name = "radbt_Oui";
            this.radbt_Oui.Size = new System.Drawing.Size(43, 17);
            this.radbt_Oui.TabIndex = 5;
            this.radbt_Oui.TabStop = true;
            this.radbt_Oui.Text = "Yes";
            this.radbt_Oui.UseVisualStyleBackColor = true;
            // 
            // radbt_No
            // 
            this.radbt_No.AutoSize = true;
            this.radbt_No.Location = new System.Drawing.Point(292, 195);
            this.radbt_No.Name = "radbt_No";
            this.radbt_No.Size = new System.Drawing.Size(39, 17);
            this.radbt_No.TabIndex = 6;
            this.radbt_No.TabStop = true;
            this.radbt_No.Text = "No";
            this.radbt_No.UseVisualStyleBackColor = true;
            // 
            // bt_SaveReturn
            // 
            this.bt_SaveReturn.Location = new System.Drawing.Point(237, 248);
            this.bt_SaveReturn.Name = "bt_SaveReturn";
            this.bt_SaveReturn.Size = new System.Drawing.Size(99, 23);
            this.bt_SaveReturn.TabIndex = 7;
            this.bt_SaveReturn.Text = "Save and return";
            this.bt_SaveReturn.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(210, 81);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 32);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(210, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // FormDifficulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 300);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.bt_SaveReturn);
            this.Controls.Add(this.radbt_No);
            this.Controls.Add(this.radbt_Oui);
            this.Controls.Add(this.bt_Bordure);
            this.Controls.Add(this.lb_Acceleration);
            this.Controls.Add(this.lb_DisparitionFruit);
            this.Controls.Add(this.lb_Vitesse);
            this.Controls.Add(this.lb_Titre);
            this.Name = "FormDifficulte";
            this.Text = "FormDifficulte";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Label lb_Vitesse;
        private System.Windows.Forms.Label lb_DisparitionFruit;
        private System.Windows.Forms.Label lb_Acceleration;
        private System.Windows.Forms.Label bt_Bordure;
        private System.Windows.Forms.RadioButton radbt_Oui;
        private System.Windows.Forms.RadioButton radbt_No;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_SaveReturn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}