
namespace Authenticatie
{
    class EmailService
    {
        public void Verstuur(string email, string text)
        {
            Console.WriteLine("Verstuur email naar " + email + " met tekst: " + text);
        }
    }
}