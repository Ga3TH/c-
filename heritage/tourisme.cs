using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
        public class Tourisme : Vehicule
        {

            // Voiture hérite de la classe Vehicule

            private int nombreDePortes;
            private int NombreDePassager;
            private bool climatisation;



            public Tourisme(string code, string libelle, double prixJour, int nombreDePortes, int NombreDePassager, bool climatisation)

                : base(code, libelle, prixJour)
            {

                this.nombreDePortes = nombreDePortes;
                this.NombreDePassager = NombreDePassager;
                this.climatisation = climatisation;
            }

            public int GetNombreDePortes() {  return nombreDePortes ; }

            public int GetNombreDeporte() { return NombreDePassager; }

            public bool GetClimatisation() { return climatisation; }

    } // fin classe
}
