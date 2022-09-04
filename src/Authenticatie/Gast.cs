
namespace Authenticatie
{
    class Gast : Gebruiker
    {
        public int Rating { get; set; }
        public int Boete { get; set; }
        public DateTime Geboortedatum { get; set; }

        public void Bezoek()
        {
            Console.WriteLine("Bezoek een activiteit");
        }
        public void VIPBezoek()
        {
            Console.WriteLine("Bezoek een VIP activiteit");
        }
        public void GeefStraf(string daden)
        {
            Console.WriteLine("Geef een straf voor " + daden);
        }
    }
}