using System.ComponentModel.Design;
using System.Data;

//---KLEIN---
// kleiner < als
// kleiner <= oder gleich als / wie

//---GROSS---
// grösser > als / MUSS mindest unterschied 1+ haben also 101 sonst false
// grösser >= oder gleich als / wie / kann exakt gleich 100 sein sonst false

int second_value = 900; //prüf value

for (int start_value = 10;   start_value <= second_value;    start_value++)
{
    if (second_value >= 100)
    {
        Console.WriteLine("if ausgeführt: " + start_value);
    }

    else if (second_value == 101)
    {
        Console.WriteLine("elif ausgeführt: " + start_value);
    }//wie printe ich das? logik problem
    
}



/*notizen------- vieles wird als lern projekt gecodet / mitgenommen-------
*globale variable? -> hat keine wie es in python hat
*nested for loop?
*operator problem?
*OOP? static class / public ?
*while true nutzen dann mit if und == ? siehe altes c++ programm -> ähnlich
*extra varriable bei if / für if? in for loop?
*mit == aka. zahlen prüfung extra?
*EXTRA PRÜFEN von start value?? zb. start value < 400? 300?
*mindestens 100->kommt vor in überprüfung per for loop -> print
*
*/