
namespace Authenticatie
{
    public abstract class Gebruiker
    {
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Naam { get; set; }
        public VerificatieToken VerificatieToken { get; set; }

        public Gebruiker(string email, string wachtwoord, string naam, VerificatieToken token)
        {
            Email = email;
            Wachtwoord = wachtwoord;
            Naam = naam;
            VerificatieToken = token;
        }

        public bool Geverifieerd()
        {
            return VerificatieToken == null;
        }
    }
}