using System.ComponentModel.Design;
using System.Data;

//---KLEIN---
// kleiner < als
// kleiner <= oder gleich als / wie

//---GROSS---
// grösser > als / MUSS mindest unterschied 1+ haben also 101 sonst false
// grösser >= oder gleich als / wie / kann exakt gleich 100 sein sonst false

int bigger_value = 100; 

for (int smaller_value = 90;   smaller_value < bigger_value;    smaller_value++)
{//KLAMMER FOR LOOP
    
    /*LOOP startet NUR bei TRUE - Problem: 
     * smaller_value < bigger_value ist der check
     * der positiv sein MUSS für if / else checks
     */

    if (smaller_value < bigger_value)
    {//INTERNER CHECK NACHDEM PARAMETER 2 TRUE IST BEI DER FOR LOOP
        Console.WriteLine("if -- " + smaller_value);
    }

    
    
    else
    {//INTERNER CHECK NACHDEM PARAMETER 2 TRUE IST BEI DER FOR LOOP
        Console.WriteLine("else -- " + smaller_value);
    }
    


}// KLAMMER FOR LOOP



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
*fazit: es war ein parameter logik problem da parameter 2 bei der for loopp immer true sein
*muss damit der inhalt ausgeführt wird und if else usw den wert überhaupt nochmals checken kann!
*gebraucht: 3 tage ohne KI hilfe 
*/