using System.Diagnostics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] lol)
    {//Main = startpunkt darinn auf klassen zugreifen / alles unter ordnen
        
        Console.WriteLine("Hallooo");
        
        RandomClass.Ausführer(lol);
    }
    
}

public class RandomClass
{
    private static void class2(string[] lol)//private functions kann man nicht ausserhalb dieser class nutzen
    {
        Console.WriteLine("Hallo aus der class 2");
    }


    public static void Ausführer(string[] lol)
    {
        class2(lol);
    }


}


