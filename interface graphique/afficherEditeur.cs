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

        private void tbxChoisie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvAffichage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvAffichage.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            lvAffichage.Columns.Add("Nom", 200); // 100 = largeur colonne
            lvAffichage.Columns.Add("ID", 200);
            lvAffichage.View = View.Details;
            requete = "Select pubid, name from Publishers where name like @lettre";
            maCde = new NpgsqlCommand(requete, maCo);
            string lettre = tbxChoisie.Text + "%";
            maCde.Parameters.AddWithValue("@lettre", lettre + "%");
            jeuEnregistrements = maCde.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                var tabItem = new string[2];
                ListViewItem unitem;
                tabItem[0] = jeuEnregistrements["name"].ToString();
                tabItem[1] = jeuEnregistrements["pubid"].ToString();
                unitem = new ListViewItem(tabItem);
                lvAffichage.Items.Add(unitem);

            }
            maCo.Close();
        }
    }
}
