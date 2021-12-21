using System;
namespace Uebung56_Hausverwaltung_pbbgh20aba
{
    class Haus
    {
        private int hausnr;
        private Wohnung[] wohnungen;

        public int Hausnr { get => hausnr; set => hausnr = value; }
        public Wohnung[] Wohnungen { get => wohnungen; set => wohnungen = value; }

        public Haus(int hausnr, Wohnung[] wohnungen)
        {
            Hausnr = hausnr;
            Wohnungen = wohnungen;
        }

        public double BerechneMonatlicheMieteinnahmen()
        {
            double summeMonatsmiete = 0;

            for (int i = 0; i < wohnungen.Length; i++)
            {
                summeMonatsmiete += wohnungen[i].Monatsmiete;
            }

            return summeMonatsmiete;
        }


        public double BerechneGesamtMietflaeche()
        {
            double gesamtflaeche = 0;

            for (int i = 0; i < wohnungen.Length; i++)
            {
                gesamtflaeche += wohnungen[i].Flaeche;
            }

            return gesamtflaeche;
        }



        public override string ToString()
        {
            return $"Haus hat Hausnummer={Hausnr}, Wohnungen={string.Join<Wohnung>(", ", Wohnungen)}";
        }
    }
}
