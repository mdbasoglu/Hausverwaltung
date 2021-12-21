using System;
namespace Uebung56_Hausverwaltung_pbbgh20aba
{
    class Wohnung
    {
        private int nummer;
        private double flaeche;
        private double monatsmiete;
        private Mieter mieter;

        public int Nummer { get => nummer; set => nummer = value; }
        public double Flaeche { get => flaeche; set => flaeche = value; }
        public double Monatsmiete { get => monatsmiete; set => monatsmiete = value; }
        public Mieter Mieter { get => mieter; set => mieter = value; }



        public Wohnung(int nummer, double flaeche, double monatsmiete)
        {
            Nummer = nummer;
            Flaeche = flaeche;
            Monatsmiete = monatsmiete;
        }


        public Wohnung(int nummer, double flaeche, double monatsmiete, Mieter mieter)
        {
            Nummer = nummer;
            Flaeche = flaeche;
            Monatsmiete = monatsmiete;
            Mieter = mieter;
        }


        public override string ToString()
        {
            return $"Wohnung hat Nummer={Nummer}, Fläche={Flaeche}qm, Monatsmiete={Monatsmiete}Euro, Mieter={Mieter}";
        }

    }
}
