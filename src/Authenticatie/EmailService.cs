
namespace Authenticatie
{
    public interface IEmailService
    {
        void Verstuur(string email, string bericht);
    }
    public class EmailService : IEmailService
    {
        public void Verstuur(string email, string text)
        {
            Console.WriteLine("Verstuur email naar " + email + " met tekst:\n" + text);
        }
    }
}