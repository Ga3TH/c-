using System;

using System.Windows.Forms;

using System.Drawing;



public class PremiereFenetre : Form

{

    private Label lblMessage;

    private Button btnFermer;



    public PremiereFenetre()

    {

        SuspendLayout();

        Text = "Une première fenêtre";    // Le titre de la fenêtre

        Size = new Size(200, 150);        // La taille initiale

        MinimumSize = new Size(200, 150); // La taille minimale



        // Le label "Hello world !"

        lblMessage = new Label();

        lblMessage.Text = "Hello World !";

        lblMessage.AutoSize = true;             // Taille selon le contenu

        lblMessage.Location = new Point(50, 30);// Position x=50 y=30



        // Le bouton "Fermer"

        btnFermer = new Button();

        btnFermer.Text = "Fermer";

        btnFermer.AutoSize = true;             // Taille selon le contenu

        btnFermer.Location = new Point(50, 60);// Position x=50 y=60



        btnFermer.Click += new System.EventHandler(btnFermer_Click); /* Si Click sur « btnFermer » on appelle la méthode « btnFermer_Click ») */



        // Ajouter les composants à la fenêtre

        Controls.Add(lblMessage);

        Controls.Add(btnFermer);



        ResumeLayout(false);

        PerformLayout();

    }



    // Gestionnaire d'événement

    private void btnFermer_Click(object sender, EventArgs evt)

    {

        // Fin de l'application :

        Application.Exit();

    }



    static void Main()

    {

        // Pour le style XP :

        Application.EnableVisualStyles();



        // Lancement de la boucle de messages

        // pour la fenêtre passée en argument :

        Application.Run(new PremiereFenetre());

    }

}

