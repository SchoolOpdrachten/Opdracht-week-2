using System;

namespace Map
{
    interface Tekenbaar
    {
        void TekenConsole(ConsoleTekener t);

        Coordinaat Locatie { get; set; }
        string Karakter { get; }

    }
}