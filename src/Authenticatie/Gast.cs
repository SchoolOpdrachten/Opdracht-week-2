
namespace Authenticatie
{
    public class Gast : Gebruiker
    {
        public Gast(string mail, string ww, string naam, VerificatieToken t) : base(mail, ww, naam, t)
        {
        }

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
            Boete += 100;
        }
    }
}