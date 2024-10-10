/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Uhrzeit mit der Form hh:mm:ss
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
int totalSeconds;

int minutes;
int hours;
int seconds;
int days;
int totalMinutes;
int totalHours;

//Eingabe

Console.Write("Please enter seconds: ");
input 			= Console.ReadLine();
totalSeconds 	= int.Parse(input);  //Konvertierung 

//Verarbeitung

seconds 		= totalSeconds % 60;
totalMinutes 	= totalSeconds / 60;

minutes 		= totalMinutes % 60;
totalHours 		= totalMinutes / 60;

hours			= totalHours % 24;
days			= totalHours / 24;

//Ausgabe

if (days == 0)
{
	Console.Write($"Converted to format hh:mm:ss  {hours}:{minutes:00}:{seconds:00}");
}
else if (days == 1)

{
	Console.Write($"Converted to format hh:mm:ss {days} Tag {hours:00}:{minutes:00}:{seconds:00}");
}
else

{
	Console.Write($"Converted to format hh:mm:ss {days} Tage {hours:00}:{minutes:00}:{seconds:00}");
}

Console.ReadLine();