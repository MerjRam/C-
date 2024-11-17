/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Celinische Sümpfen
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
bool question= false;
string x = " ";

Console.WriteLine("Willkommwn in den celinischen Suempfen");
Console.WriteLine("");

do
{
    Console.Write("Hat Ihr celinischer Freund einen Knelt? [J/N] --> ", "{20:f2}");
    input = Console.ReadLine().ToUpper();
    bool knelt = (input == "J");

    Console.Write("Loepst er womoeglich? [J/N]                   --> ", "{20:f2}");
    input = Console.ReadLine().ToUpper();
    bool lopst = (input == "J");

    Console.Write("Zur Manuseligkeit: manuselt er? [J/N]         --> ", "{20:f2}");
    input = Console.ReadLine().ToUpper();
    bool manuselt = (input == "J");

    Console.Write("und ein letztes: nopelt er etwas? [J/N]       --> ", "{20:f2}");
    input = Console.ReadLine().ToUpper();
    bool nopelt = (input == "J");

    if (knelt && manuselt)
    {
        Console.WriteLine($"Ein Asi. Gratulieren       ");
    }
    else if (!knelt && nopelt)
    {
        Console.WriteLine($"Ein Bella. Gratulieren     ");
    }
    else if (knelt && !manuselt && nopelt)
    {
        Console.WriteLine($"Ein Cedi. Gratulieren      ");
    }
    else if (!knelt && lopst && !nopelt && manuselt)
    {
        Console.WriteLine($"Ein Cedi. Gratulieren      ");
    }
    else if (!knelt && lopst && !nopelt && !manuselt)
    {
        Console.WriteLine($"Ein Durdi. Gratulieren     ");
    }

    Console.Write($"Drücke Sie Taste für eine neue Testung (x für Exit): ");
    x = Console.ReadLine().ToUpper();

} while (x != "X");
