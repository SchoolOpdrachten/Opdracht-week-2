using Map;
using Attracties;
using Authenticatie;

class PretparkDH
{
    public static void Main(string[] args)
    {
        EmailService es = new EmailService();
        es.Verstuur("peter@mail.com", "hallo");
    }

    public static void KaartOpdr()
    {
        Kaart k = new Kaart(20, 20);

        Pad p1 = new Pad(new Coordinaat(1, 1), new Coordinaat(6 ,6));
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
        GebruikerService gebruikerService = new GebruikerService();
        Gebruiker gebruiker = gebruikerService.Registreer("peter#@mail.com", "peter", "123");
        GebruikerContext.AddGebruiker(gebruiker);
        string token = "123";
        gebruikerService.Verifieer(gebruiker.Email, token);
    }
}