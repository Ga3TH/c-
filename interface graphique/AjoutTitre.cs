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
    public partial class AjoutTitre : Form
    {
        public AjoutTitre()
        {
            InitializeComponent();
        }

        private void tbxChoix_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCo;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=5432;User ID=postgres;Password=postgres;Database=Biblio;";
            maCo = new NpgsqlConnection(CHAINECONNEXION);
            string requete;
            NpgsqlCommand maCde;
            NpgsqlDataReader jeuEnregistrements;
            maCo.Open();
            requete = "Select pubid, name from Publishers where name like @lettre";
            maCde = new NpgsqlCommand(requete, maCo);
            string lettre = tbxChoix.Text + "%";
            maCde.Parameters.AddWithValue("@lettre", lettre + "%");
            jeuEnregistrements = maCde.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                MessageBox.Show(e.ToString());
            }
            maCo.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AjoutTitre_Load(object sender, EventArgs e)
        {

        }
    }
}
