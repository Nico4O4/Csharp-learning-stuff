using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices;


class KatzenEigenschaften
{
    private string geraeusch_happy;
    private string geraeusch_neugierig;
    //felder (variablen für daten speicherung)
    
    public KatzenEigenschaften()
    {//Konstruktor
        geraeusch_happy = "FrrFrrr";
        geraeusch_neugierig = "Meow?";
    }//aktuell hardcoded später variablen nutzen um es dynamisch zu halten
    
    
    static void Main() //Methode
    {
        KatzenEigenschaften obj0 = new KatzenEigenschaften(); //erstellt ein objekt nutzt Konstruktor

        Console.WriteLine("Eigenschaften von meiner Katze");
        Console.WriteLine(obj0.geraeusch_happy + " (schnurrt gerne)");
        Console.WriteLine(obj0.geraeusch_neugierig + " (Miaut wenn neugierig)");
    }
}