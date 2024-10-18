/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Enter Week Day
*-------------------------------------------------------------------------------------------
*/
using System;

string weekday;
string secoundLetter;

Console.Write("Gebe den ersten Buchstaben eines Wochentages ein:");
weekday = Console.ReadLine();
weekday = weekday.ToUpper(); // Groß-Kleinschreibung


if((weekday == "M") || (weekday == "S") || (weekday == "D"))
{
	Console.Write("Gebe den zweiten Buchstaben des Wochentages ein:");
	secoundLetter = Console.ReadLine().ToUpper();
	weekday = weekday + secoundLetter;
	
}

switch (weekday)
{
	case"MO":
		Console.Write("Sie haben Montag ausgewählt.");
		break;
	
	case"DI":
		Console.Write("Sie haben Dienstag ausgewählt.");
		break;
	
	case"MI":
		Console.Write("Sie haben Mittwoch ausgewählt.");
		break;
	
	case"DO":
		Console.Write("Sie haben Donnerstag ausgewählt.");
		break;
	
	case"F":
		Console.Write("Sie haben Freitag ausgewählt.");
		break;
	
	case"SA":
		Console.Write("Sie haben Samstag ausgewählt.");
		break;
	
	case"SO":
		Console.Write("Sie haben Sonntag ausgewählt.");
		break;
		
	default:
		Console.Write("Ungültige Eingabe!");
		break;
	
}