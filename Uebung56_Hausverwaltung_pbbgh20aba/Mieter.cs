using System;
namespace Uebung56_Hausverwaltung_pbbgh20aba
{
    class Mieter
    {
        private string name;

        public string Name { get => name; set => name = value; }


        public Mieter(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Mieter hat Name={name}";
        }
    }
}
