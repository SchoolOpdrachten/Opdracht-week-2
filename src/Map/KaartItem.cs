using System;

namespace Map
{
    class KaartItem : Tekenbaar
    {
        // private Coordinaat locatie;
        public Coordinaat Locatie { get; set; }
        public string Karakter { get; }

        public KaartItem(Kaart k, Coordinaat l, string karakter) {
            Locatie = l;
            Karakter = karakter;
        }
        public void TekenConsole(ConsoleTekener t)
        {
            t.Teken(this);
        }
    }
}