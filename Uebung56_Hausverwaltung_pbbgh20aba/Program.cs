using System;

namespace Uebung56_Hausverwaltung_pbbgh20aba
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Mieter m1 = new Mieter("Müller");

            Wohnung w1 = new Wohnung(1, 50, 300);
            w1.Mieter = m1;

            Console.WriteLine(w1);
            Console.WriteLine();
            Console.WriteLine();


            Wohnung[] wohnungenHaus1 =
            {
                w1,
                new Wohnung(2,100,3000, new Mieter("Maier")),
                new Wohnung(3,129,4000, new Mieter("Lale")),
            };

            Haus h1 = new Haus(1, wohnungenHaus1);
            Console.WriteLine(h1);
            Console.WriteLine();
            Console.WriteLine();


            int[] zahlen = { 2, 34, 56 };
            Console.WriteLine(string.Join(", ", zahlen));




        }
    }
}
