
namespace Authenticatie
{
    public interface IGebruikerService
    {
        Gebruiker Registreer(string email, string wachtwoord, string naam);
        bool Login(string email, string wachtwoord);
        bool Verifieer(string email, string token);
    }

    public class GebruikerService : IGebruikerService
    {
        public IEmailService EmailService { get; set; }
        public GebruikerContext GebruikerContext { get; set; }

        public GebruikerService(IEmailService e, GebruikerContext c)
        {
            EmailService = e;
            GebruikerContext = c;
        }
        
        public Gebruiker Registreer(string email, string wachtwoord, string naam)
        {
            Console.WriteLine("Registreer een gebruiker");                          // TODO: remove
            VerificatieToken token = new VerificatieToken(Guid.NewGuid().ToString(), DateTime.Now.AddDays(3));
            // VerificatieToken token = new VerificatieToken("321", DateTime.Now.AddDays(3));           can be removed
            Console.WriteLine("Verificatie token is verstuur naar " + email);       // TODO:  remove
            EmailService.Verstuur(
                email,
                $"Beste {naam},\nHier vind u de verificatie token voor het verifieren van uw gast account: \"{token.Token}\""
                );

            Gebruiker gebruiker = new Gast(email, wachtwoord, naam, token);
            Console.WriteLine("Gast account is aangemaakt voor " + email);          // TODO:  remove
            GebruikerContext.AddGebruiker(gebruiker);
            return gebruiker;
        }
        public bool Login(string email, string wachtwoord)
        {
            foreach (Gebruiker gebruiker in GebruikerContext.Gebruikers)
            {
                if (gebruiker.Email == email && gebruiker.Wachtwoord == wachtwoord && gebruiker.Geverifieerd())
                {
                    Console.WriteLine("Login succesvol voor " + email);             // TODO:  remove
                    return true;
                }
            }
            return false;
        }
        public bool Verifieer(string email, string token)
        {
            Gebruiker gebruiker = GebruikerContext.GetGebruiker(email);
            if (gebruiker == null) return false;

            if (gebruiker.Geverifieerd()) return true;

            if (gebruiker.VerificatieToken.Token == token)
            {
                gebruiker.VerificatieToken = null;
                Console.WriteLine("account is geverifieerd");                   // TODO: remove
                return true;
            }
            return false;
        }
    }
}