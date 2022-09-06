
namespace Authenticatie {
    class GebruikerService
    {
        public Gebruiker Registreer(string email, string wachtwoord, string naam)
        {
            VerificatieToken token = new VerificatieToken(Guid.NewGuid().ToString(), DateTime.Now.AddDays(3));
            Gebruiker gebruiker = new Gast(email, wachtwoord, naam, token);
            // mail sturen met verificatie token
            GebruikerContext.AddGebruiker(gebruiker);
            return gebruiker;
        }
        public bool Login(string email, string wachtwoord)
        {
            foreach (Gebruiker gebruiker in GebruikerContext.Gebruikers)
            {
                if (gebruiker.Email == email && gebruiker.Wachtwoord == wachtwoord && gebruiker.Geverifieerd())
                {
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
                return true;
            }
            return false;
        }
    }
}