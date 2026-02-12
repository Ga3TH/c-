using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_graphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAfficherEditeur_Click(object sender, EventArgs e)
        {
            afficherEditeur afficher = new afficherEditeur();
            afficher.ShowDialog();
        }

        private void btnAddEditeur_Click(object sender, EventArgs e)
        {
            afficherEditeur AjoutEdit = new afficherEditeur();
            AjoutEdit.ShowDialog();
        }

        private void btnSupression_Click(object sender, EventArgs e)
        {
            afficherEditeur SupprimerTitre = new afficherEditeur();
            SupprimerTitre.ShowDialog();
        }

        private void btnAjoutTitre_Click(object sender, EventArgs e)
        {
            afficherEditeur AjoutTitre = new afficherEditeur();
            AjoutTitre.ShowDialog();
        }
    }
}
