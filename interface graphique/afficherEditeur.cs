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
    public partial class afficherEditeur : Form
    {
        public afficherEditeur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCo;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=5432;User ID=postgres;Password=postgres;Database=Biblio;";
            maCo = new NpgsqlConnection(CHAINECONNEXION);
            int nb, choix;
            string requete;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnregistrements;
            maCo.Open();
            requete = "Select PubId, Name from Publishers where Name like @lettre";
            maCde = new NpgsqlCommand(requete, maCo);
            string lettre = tbxChoisie.Text + "%";
            maCde.Parameters.AddWithValue("@lettre", lettre + "%");
            jeuEnregistrements = maCde.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                lvAffichage.Items.Add(jeuEnregistrements["name"].ToString());
            }
            maCo.Close();
        }

        private void tbxChoisie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvAffichage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
