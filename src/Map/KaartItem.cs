using System;

namespace Map
{
    class KaartItem : Tekenbaar
    {
        // private Coordinaat locatie;
        public Coordinaat Locatie { get; set; }
        public string Karakter { get; }

        public KaartItem(Kaart k, Coordinaat l, string karakter) {
            if (l.x >= 0 && l.y >= 0) Locatie = l;
            else Locatie = new Coordinaat(0, 0);
            Karakter = karakter;
        }
        public void TekenConsole(ConsoleTekener t)
        {
            t.Teken(this);
        }
    }
}