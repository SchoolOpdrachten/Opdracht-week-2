
namespace Authenticatie {
    class GebruikerService
    {
        public Gebruiker Registreer(string email, string wachtwoord, string naam)
        {
            Gebruiker gebruiker = new Gebruiker(email, wachtwoord, naam);
            GebruikerContext.Gebruikers.Add(gebruiker);
            return gebruiker;
        }
        public bool Login(string email, string wachtwoord)
        {
            foreach (Gebruiker gebruiker in GebruikerContext.Gebruikers)
            {
                if (gebruiker.Email == email && gebruiker.Wachtwoord == wachtwoord)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Verifieer(string email, string token)
        {
            return true;
        }
    }
}