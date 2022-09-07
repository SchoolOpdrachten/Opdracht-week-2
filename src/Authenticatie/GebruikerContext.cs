
namespace Authenticatie
{
    public class GebruikerContext
    {
        public List<Gebruiker> Gebruikers { get; set; } = new List<Gebruiker>();

        public Gebruiker GetGebruiker(string email)
        {
            return Gebruikers.Find(g => g.Email == email);
        }
        public Gebruiker GetGebruiker(int index)
        {
            return Gebruikers[index];
        }
        // public void NewGebruiker(string email, string wachtwoord, string naam)
        // {
        //     Gebruiker g = new Gebruiker(email, wachtwoord, naam);
        // }
        public void AddGebruiker(Gebruiker gebruiker)
        {
            Gebruikers.Add(gebruiker);
            Console.WriteLine("Gebruiker is toegevoegd");               // TODO: remove
        }
        // public void RemoveGebruiker(Gebruiker gebruiker)
        // {
        //     Gebruikers.Remove(gebruiker);
        // }
        public int AantalGebruikers()
        {
            return Gebruikers.Count;
        }
    }
}