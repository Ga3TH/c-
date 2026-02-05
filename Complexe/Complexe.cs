using System;

namespace TP20
{
    internal class Program
    {
        public class Complexe
        {
            private double x;
            private double y;

            public Complexe(double nouvX, double nouvY)
            {
                x = nouvX;
                y = nouvY;
            }

            public Complexe()
            {
                x = 0;
                y = 0;
            }

            public double GetPartieReelle()
            {
                return x;
            }

            public double GetPartieImaginaire()
            {
                return y;
            }

            public Complexe Addition(Complexe nombre)
            {
                Complexe Comp = new Complexe(x + nombre.GetPartieReelle(), y + nombre.GetPartieImaginaire());
                return Comp;
            }

            public Complexe Soustraction(Complexe nombre)
            {
                Complexe Comp = new Complexe(x - nombre.GetPartieReelle(), y - nombre.GetPartieImaginaire());
                return Comp;
            }

            public Complexe Produit(Complexe nombre)
            {
                Complexe Comp = new Complexe(x * nombre.GetPartieReelle() - y * nombre.GetPartieImaginaire(), x * GetPartieImaginaire() + y * GetPartieReelle());
                return Comp;
            }

            public Complexe Inverse()
            {
                Complexe Comp = new Complexe(x / (x * x + y * y), -y / (x * x + y * y));
                return Comp;
            }

            public double GetModule()
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            }

            public Complexe ComparerModule(Complexe nombre)
            {
                if (this.GetModule() < nombre.GetModule())
                {
                    return nombre;
                }
                if (this.GetModule() > nombre.GetModule())
                {
                    return this;
                }
                return null;
                
            }

            public override string ToString()
            {
                string chaine = string.Empty;
                chaine = "Partie réelle: " + x.ToString() + ", \nPartie imaginaire: " + y.ToString();
                return chaine;
            }

        }

    }
}