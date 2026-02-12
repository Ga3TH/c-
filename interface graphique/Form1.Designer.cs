namespace interface_graphique
{
    partial class Form1
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
            this.btnAfficherEditeur = new System.Windows.Forms.Button();
            this.btnAddEditeur = new System.Windows.Forms.Button();
            this.btnSupression = new System.Windows.Forms.Button();
            this.btnAjoutTitre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfficherEditeur
            // 
            this.btnAfficherEditeur.Location = new System.Drawing.Point(21, 63);
            this.btnAfficherEditeur.Name = "btnAfficherEditeur";
            this.btnAfficherEditeur.Size = new System.Drawing.Size(332, 64);
            this.btnAfficherEditeur.TabIndex = 0;
            this.btnAfficherEditeur.Text = "Affichher les éditeurs";
            this.btnAfficherEditeur.UseVisualStyleBackColor = true;
            this.btnAfficherEditeur.Click += new System.EventHandler(this.btnAfficherEditeur_Click);
            // 
            // btnAddEditeur
            // 
            this.btnAddEditeur.Location = new System.Drawing.Point(33, 133);
            this.btnAddEditeur.Name = "btnAddEditeur";
            this.btnAddEditeur.Size = new System.Drawing.Size(320, 62);
            this.btnAddEditeur.TabIndex = 1;
            this.btnAddEditeur.Text = "Ajouter un éditeur";
            this.btnAddEditeur.UseVisualStyleBackColor = true;
            this.btnAddEditeur.Click += new System.EventHandler(this.btnAddEditeur_Click);
            // 
            // btnSupression
            // 
            this.btnSupression.Location = new System.Drawing.Point(21, 201);
            this.btnSupression.Name = "btnSupression";
            this.btnSupression.Size = new System.Drawing.Size(332, 58);
            this.btnSupression.TabIndex = 2;
            this.btnSupression.Text = "Supprimer un titre";
            this.btnSupression.UseVisualStyleBackColor = true;
            this.btnSupression.Click += new System.EventHandler(this.btnSupression_Click);
            // 
            // btnAjoutTitre
            // 
            this.btnAjoutTitre.Location = new System.Drawing.Point(33, 278);
            this.btnAjoutTitre.Name = "btnAjoutTitre";
            this.btnAjoutTitre.Size = new System.Drawing.Size(320, 56);
            this.btnAjoutTitre.TabIndex = 3;
            this.btnAjoutTitre.Text = "Ajouter un titre";
            this.btnAjoutTitre.UseVisualStyleBackColor = true;
            this.btnAjoutTitre.Click += new System.EventHandler(this.btnAjoutTitre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjoutTitre);
            this.Controls.Add(this.btnSupression);
            this.Controls.Add(this.btnAddEditeur);
            this.Controls.Add(this.btnAfficherEditeur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherEditeur;
        private System.Windows.Forms.Button btnAddEditeur;
        private System.Windows.Forms.Button btnSupression;
        private System.Windows.Forms.Button btnAjoutTitre;
    }
}

