using System;

namespace Map
{
    class Kaart 
    {
        public int Breedte { get; }
        public int Hoogte { get; }

        private List<Pad> paden = new List<Pad>();
        private List<KaartItem> kaartItems = new List<KaartItem>();

        public Kaart(int breedte, int hoogte)
        {
            Breedte = breedte;
            Hoogte = hoogte;
        }

        public void TekenConsole(ConsoleTekener t)
        {
            for (int i = 0; i < Breedte; i++) t.SchrijfOp(new Coordinaat(i, 0), "-");
            for (int i = 0; i < Hoogte; i++) t.SchrijfOp(new Coordinaat(0, i + 1), "|");

            foreach (Pad p in paden) p.TekenConsole(t);
            foreach (KaartItem k in kaartItems) k.TekenConsole(t);
            
        }

        public void VoegItemToe(KaartItem item) { kaartItems.Add(item); }   
        public void VoegPadToe(Pad pad) { paden.Add(pad); }


    }
}