
namespace Authenticatie
{
    static class EmailService
    {
        public static void Verstuur(string email, string text)
        {
            Console.WriteLine("Verstuur email naar " + email + " met tekst:\n" + text);
        }
    }
}