
namespace Authenticatie
{
    static class GebruikerContext
    {
        public static List<Gebruiker> Gebruikers { get; set; } = new List<Gebruiker>();

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
            Console.WriteLine("Gebruiker is toegevoegd");               // TODO: remove
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