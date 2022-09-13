
namespace Authenticatie
{
    public interface IGebruikerService
    {
        Gebruiker Registreer(string email, string ww, string naam);
        bool Login(string email, string ww);
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
        
        public Gebruiker Registreer(string email, string ww, string naam)
        {
            foreach (Gebruiker g in GebruikerContext.Gebruikers)
            {
                if (g.Email == email) return null;
            }

            Console.WriteLine("Registreer een gebruiker");                          // TODO: remove
            VerificatieToken token = new VerificatieToken(Guid.NewGuid().ToString(), DateTime.Now.AddDays(3));
            Console.WriteLine("Verificatie token is verstuur naar " + email);       // TODO:  remove
            EmailService.Verstuur(
                email,
                $"Beste {naam},\nHier vind u de verificatie token voor het verifieren van uw gast account: \"{token.Token}\""
                );

            Gebruiker gebruiker = new Gast(email, ww, naam, token);
            Console.WriteLine("Gast account is aangemaakt voor " + email);          // TODO:  remove
            GebruikerContext.AddGebruiker(gebruiker);
            return gebruiker;
        }
        public bool Login(string email, string ww)
        {
            foreach (Gebruiker gebruiker in GebruikerContext.Gebruikers)
            {
                if (gebruiker.Email == email && gebruiker.Wachtwoord == ww && gebruiker.Geverifieerd())
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
            
            if( gebruiker.VerificatieToken.Verifieer(token)) 
            {
                gebruiker.VerificatieToken = null;
                return true;
            }
            return false;
        }
    }
}