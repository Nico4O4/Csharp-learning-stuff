using System.Diagnostics;


while (true)
{
    Console.Write("Enter first number >> ");

    int FirstNumber = Convert.ToInt32(Console.ReadLine());//eingabe vom user geespeichert

    Console.Write("Enter second number >> ");

    int SecondNumber = Convert.ToInt32(Console.ReadLine());//eingabe vom user geespeichert


    int final; // für speicherung gesamt ergebnis
    final = SecondNumber + FirstNumber; //nnummern übergabe an final


    Console.WriteLine("Your Nurmbers + are: " + final);

}






//Calculator coded in C# by: Nico4O4
/*--ideen-- 
 * mehrere zahlen
 * meherer operatoren
 * vergleichs test < oder >
 * in while true setzen damit es nicht schliesst nach ergebnis // done 01.01.2026 || 18:42 Uhr
 * fehler abfangen
 * okay tbh das ist noch zu schwer
 */
