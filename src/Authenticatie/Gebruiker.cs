
namespace Authenticatie
{
    class Gebruiker
    {
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Naam { get; set; }

        private VerificatieToken VerificatieToken;
        public Gebruiker(string email, string wachtwoord, string naam)
        {
            Email = email;
            Wachtwoord = wachtwoord;
            Naam = naam;
            VerificatieToken = new VerificatieToken(Guid.NewGuid().ToString(), DateTime.Now.AddDays(3));
        }

        public bool Geverifieerd()
        {
            return isGeverifieerd;
        }
    }
}