namespace interface_graphique
{
    partial class afficherEditeur
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
            this.tbxChoisie = new System.Windows.Forms.TextBox();
            this.lvAffichage = new System.Windows.Forms.ListView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxChoisie
            // 
            this.tbxChoisie.Location = new System.Drawing.Point(111, 93);
            this.tbxChoisie.Name = "tbxChoisie";
            this.tbxChoisie.Size = new System.Drawing.Size(231, 20);
            this.tbxChoisie.TabIndex = 0;
            this.tbxChoisie.TextChanged += new System.EventHandler(this.tbxChoisie_TextChanged);
            // 
            // lvAffichage
            // 
            this.lvAffichage.GridLines = true;
            this.lvAffichage.HideSelection = false;
            this.lvAffichage.Location = new System.Drawing.Point(486, 12);
            this.lvAffichage.Name = "lvAffichage";
            this.lvAffichage.Size = new System.Drawing.Size(241, 464);
            this.lvAffichage.TabIndex = 2;
            this.lvAffichage.UseCompatibleStateImageBehavior = false;
            this.lvAffichage.SelectedIndexChanged += new System.EventHandler(this.lvAffichage_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(173, 119);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // afficherEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 488);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvAffichage);
            this.Controls.Add(this.tbxChoisie);
            this.Name = "afficherEditeur";
            this.Text = "afficherEditeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxChoisie;
        private System.Windows.Forms.ListView lvAffichage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnValider;
    }
}