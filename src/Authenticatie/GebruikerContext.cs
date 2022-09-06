
namespace Authenticatie
{
    static class GebruikerContext
    {
        public static List<Gebruiker> Gebruikers
        {
            get
            {
                if (Gebruikers == null)
                {
                    List<Gebruiker> Gebruikers = new List<Gebruiker>();
                    Gebruikers.Add(new Medewerker("medwerker@mail.com", "medewerker", "123", null));
                    Gebruikers.Add(new Gast("gast@mail.com", "gasta", "123", null));
                }
                return Gebruikers;
            }
            set { Gebruikers = value; }
        }

        public static Gebruiker GetGebruiker(string email)
        {
            return Gebruikers.Find(g => g.Email == email);
        }
        public static Gebruiker GetGebruiker(int index)
        {
            return Gebruikers[index];
        }
        // public static void NewGebruiker(string email, string wachtwoord, string naam)
        // {
        //     Gebruiker g = new Gebruiker(email, wachtwoord, naam);
        // }
        public static void AddGebruiker(Gebruiker gebruiker)
        {
            Gebruikers.Add(gebruiker);
        }
        // public static void RemoveGebruiker(Gebruiker gebruiker)
        // {
        //     Gebruikers.Remove(gebruiker);
        // }
        public static int AantalGebruikers()
        {
            return Gebruikers.Count;
        }
    }
}