using Map;
using Attracties;
using Authenticatie;

class PretparkDH
{
    public static void Main(string[] args)
    {
        AuthenticatieOpdr();
    }

    public static void KaartOpdr()
    {
        Kaart k = new Kaart(20, 20);

        Pad p1 = new Pad(new Coordinaat(1, 1), new Coordinaat(6, 6));
        k.VoegPadToe(p1);
        Pad p2 = new Pad(new Coordinaat(15, 4), new Coordinaat(2, 15));
        k.VoegPadToe(p2);

        k.VoegItemToe(new Attractie(k, new Coordinaat(5, 5)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(1, 3)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(8, 3)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(15, 15)));

        k.TekenConsole(new ConsoleTekener());
        // new ConsoleTekener().SchrijfOp(new Coordinaat(0, k.Hoogte + 1), "Deze kaart is schaal 1:1000");
        Console.ReadKey();
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
            Gebruiker gebruiker = GebruikerService.Registreer(email, wachtwoord, naam);
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
