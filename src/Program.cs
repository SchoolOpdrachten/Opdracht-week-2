using Map;
using Attracties;

class PretparkDH
{
    public static void Main(string[] args)
    {
        
        Kaart k = new Kaart(10, 10);

        Pad p1 = new Pad(new Coordinaat(2, 5), new Coordinaat(2 ,6));
        k.VoegPadToe(p1);
        Pad p2 = new Pad(new Coordinaat(26, 4), new Coordinaat(10, 5));
        k.VoegPadToe(p2);

        k.VoegItemToe(new Attractie(k, new Coordinaat(5, 5)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(1, 3)));
        k.VoegItemToe(new Attractie(k, new Coordinaat(8, 3)));

        k.TekenConsole(new ConsoleTekener());
        // new ConsoleTekener().SchrijfOp(new Coordinaat(0, k.Hoogte + 1), "Deze kaart is schaal 1:1000");
        System.Console.Read();

    }
}