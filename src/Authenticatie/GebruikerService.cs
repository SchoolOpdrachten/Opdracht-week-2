
namespace Authenticatie {
    class GebruikerService
    {
        public Gebruiker Registreer(string email, string wachtwoord, string naam)
        {
            Gebruiker gebruiker = new Gebruiker(email, wachtwoord, naam);
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
            if (gebruiker != null)
            {
                if (gebruiker.Verifieer(token))
                {
                    return true;
                }
            }
        }
    }
}