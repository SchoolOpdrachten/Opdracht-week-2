using Map;
using System;

namespace Attracties
{
    class Attractie : KaartItem
    {
        // dit is voor de volgende opdracht maar volgens het UML wel iets wat hierin hoort.
        // public string naam {get; set;}
        // public int? minimaleLengte {get; set;}
        // public int angstLevel {get; set;}
        // public char Karakter { get; }


        public Attractie(Kaart k, Coordinaat c) : base(k, c, "A")
        {
            
        }
    }
}