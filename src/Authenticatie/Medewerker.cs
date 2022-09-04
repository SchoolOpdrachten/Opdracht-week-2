
namespace Authenticatie
{
    class Medewerker : Gebruiker
    {
        public Medewerker(string email, string wachtwoord, string naam) : base(email, wachtwoord, naam)
        {
        }
    }
}