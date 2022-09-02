using System;

namespace Map
{
    class ConsoleTekener : Tekener
    {

        public void Teken(Tekenbaar t)
        {
            SchrijfOp(t.Locatie, t.Karakter);
        }
        

        public void SchrijfOp(Coordinaat c, string text)
        {
            if (c.x < 0 || c.y < 0) throw new Exception("Kan niet tekenen in het negatieve!");
            Console.SetCursorPosition(c.x, c.y);
            Console.WriteLine(text);
        }
    }
}