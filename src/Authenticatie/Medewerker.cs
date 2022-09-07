
namespace Authenticatie
{
    public class Medewerker : Gebruiker
    {
        public Medewerker(string mail, string ww, string naam, VerificatieToken t) : base(mail, ww, naam, t)
        {
        }
    }
}