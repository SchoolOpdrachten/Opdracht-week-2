
namespace Authenticatie
{
    class GebruikerContext
    {
        public static List<Gebruiker> Gebruikers { get; set; }

        public Gebruiker GetGebruiker(string email)
        {
            return Gebruikers.Find(g => g.Email == email);
        }
        public Gebruiker GetGebruiker(int index)
        {
            return Gebruikers[index];
        }
        public void AddGebruiker(Gebruiker gebruiker)
        {
            Gebruikers.Add(gebruiker);
        }
    }
}