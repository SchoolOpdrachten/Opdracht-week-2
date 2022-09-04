
namespace Authenticatie
{
    class Gebruiker
    {
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Naam { get; set; }

        private bool isGeverifieerd = false;

        public Gebruiker(string email, string wachtwoord, string naam)
        {
            Email = email;
            Wachtwoord = wachtwoord;
            Naam = naam;
        }

        public bool Geverifieerd()
        {
            return isGeverifieerd;
        }
    }
}