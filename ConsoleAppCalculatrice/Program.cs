using Calculatrice;

public class LoadTest
{


    static async Task Main(string[] args)
    {
        Console.WriteLine("helloworld");
        var calcul = new CalculSimple();
        var resultat = calcul.add(4, 5);
        Console.WriteLine("4 + 5 = " + resultat);
   
    }
}