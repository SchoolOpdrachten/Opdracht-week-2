using System;

namespace Map
{
    class Pad 
    {
        private float lengteBerekend;

        public Coordinaat van { get; set; }
        public Coordinaat naar { get; set; }

        public Pad(Coordinaat van, Coordinaat naar)
        {
            lengteBerekend = (float)Math.Sqrt(Math.Pow(naar.x - van.x, 2) + Math.Pow(naar.y - van.y, 2));
            this.van = van;
            this.naar = naar;
        }
        public void TekenConsole(ConsoleTekener t)
        {
            t.SchrijfOp(van, "#");
        }

        public float Lengte() { return lengteBerekend; }
        public float Afstand(Coordinaat c) { return 1.0f; }
    }
}