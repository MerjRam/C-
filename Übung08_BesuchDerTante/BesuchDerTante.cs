/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Besuch der Tante/ Abfahrt ist um 10:00
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
string input2;
int    speed;
double kilometers;
double time;
double departs = 10.00;
double arrival;
int    hours;
int    minutes;
int    seconds;
double remainingTime;

//Eingabe

Console.WriteLine("Berechnung der Ankungt bei der Tante");
Console.WriteLine("====================================");
Console.WriteLine("");

Console.Write("Entfernung in km: ");
input 	   = Console.ReadLine();
kilometers = double.Parse(input);

Console.Write("Geschwingkeit in km/h: ");
input2 = Console.ReadLine();
speed  = int.Parse(input2);

//Verarbeitubg

time = kilometers/speed; //die Stunden der Fahrt

arrival = departs + time; //die Ankuftszeit ab 10:00

hours         = (int)arrival;
remainingTime = (arrival - hours) * 60;
minutes       = (int)remainingTime;
seconds       = (int)((remainingTime - minutes) * 60);

//Ausgabe

Console.WriteLine($"Fuer die Strecke von {kilometers:F2} km benoetigen Sie {time:F4} Stunden.");
Console.WriteLine($"Sie kommen um {hours}:{minutes:D2}:{seconds:D2} an. ");

if (arrival < 12)
{
    Console.WriteLine("Sie bekommen ein Mittagessen! ");
}
else 
{
    Console.WriteLine("Sie bekommen nur einen Kaffe und Kuchen! ");
}


Console.ReadLine();