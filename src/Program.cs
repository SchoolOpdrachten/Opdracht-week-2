using Map;
using Attracties;
using Authenticatie;

class PretparkDH
{
    public static void Main(string[] args)
    {
        AuthenticatieOpdr();
    }
    
    public static void AuthenticatieOpdr()
    {
        IEmailService EmailService = new EmailService();
        GebruikerContext GebruikerContext = new GebruikerContext();
        IGebruikerService GebruikerService = new GebruikerService(EmailService, GebruikerContext);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("maak een account aan");
            Console.WriteLine("Voer uw email in:");
            string email = Console.ReadLine();
            Console.WriteLine("Voer uw wachtwoord in:");
            string wachtwoord = Console.ReadLine();
            Console.WriteLine("Voer uw naam in:");
            string naam = Console.ReadLine();
            Console.WriteLine("\n");
            GebruikerService.Registreer(email, wachtwoord, naam);
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }

        var g = GebruikerContext.Gebruikers[0];
        Console.WriteLine("verifieer account van "+ g.Email);
        Console.WriteLine("token input = "+ g.VerificatieToken.Token);
        GebruikerService.Verifieer(g.Email, g.VerificatieToken.Token);
        Console.ReadKey();

        // login gebruiker
        foreach (Gebruiker gebruiker in GebruikerContext.Gebruikers)
        {
            Console.WriteLine("\n\nlogin " + gebruiker.Naam);
            Console.WriteLine("email: "+ gebruiker.Email);
            Console.WriteLine("wachtwoord: "+ gebruiker.Wachtwoord);
            Console.WriteLine(GebruikerService.Login(gebruiker.Email, gebruiker.Wachtwoord));
            Console.ReadKey();
        }

        // show all gebruikers
    }
}
