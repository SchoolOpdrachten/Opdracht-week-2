
namespace Authenticatie
{
    interface IEmailService
    {
        void Verstuur(string email, string text);
    }
}
