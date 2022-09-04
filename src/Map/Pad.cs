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
            
            int x = van.x;
            int y = van.y;
            int dx = naar.x - van.x;
            int dy = naar.y - van.y;

            int x_inc = 0;
            int y_inc = 0;

            if (dx > 0) x_inc = 1;
            else if (dx < 0) x_inc = -1;

            if (dy > 0) y_inc = 1;
            else if (dy < 0) y_inc = -1;

            int dx2 = Math.Abs(dx);
            int dy2 = Math.Abs(dy);

            // for (int i = 0; i < dx2; i++)
            // {
            //     t.SchrijfOp(new Coordinaat(x, y), "X");
            //     x += x_inc;
            //     y += y_inc;
            // }

            if (dx2 >= dy2)
            {
                int rem = dx2 / 2;
                for (int i = 0; i < dx2; i++)
                {
                    t.SchrijfOp(new Coordinaat(x, y), "X");
                    rem += dy2;
                    if (rem >= dx2)
                    {
                        rem -= dx2;
                        y += y_inc;
                    }
                    x += x_inc;
                }
            }
            else
            {
                int rem = dy2 / 2;
                for (int i = 0; i < dy2; i++)
                {
                    t.SchrijfOp(new Coordinaat(x, y), "X");
                    rem += dx2;
                    if (rem >= dy2)
                    {
                        rem -= dy2;
                        x += x_inc;
                    }
                    y += y_inc;
                }
            }
        }

        public float Lengte() { return lengteBerekend; }
        public float Afstand(Coordinaat c) { return 1.0f; }
    }
}