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
            afficherEditeur afficherEditeur = new afficherEditeur();
            afficherEditeur.ShowDialog();
        }

        private void btnAddEditeur_Click(object sender, EventArgs e)
        {
            AjoutEdit AjoutEdit = new AjoutEdit();
            AjoutEdit.ShowDialog();
        }

        private void btnSupression_Click(object sender, EventArgs e)
        {
            AjoutTitre SupprimerTitre = new AjoutTitre();
            SupprimerTitre.ShowDialog();
        }

        private void btnAjoutTitre_Click(object sender, EventArgs e)
        {
            AjoutTitre AjoutTitre = new AjoutTitre();
            AjoutTitre.ShowDialog();
        }
    }
}
