/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			TimeAdder
*-------------------------------------------------------------------------------------------
*/
using System;
string input;
int minutes1;
int minutes2;
int hour1;
int hour2;
int sum1;
int sum2;

//Eingabe
Console.WriteLine("Einfacher Addierer für zwei Uhrzeiten");
Console.WriteLine("===================================");

Console.Write("Stunden 1: ");
input = Console.ReadLine();
hour1 = int.Parse(input);

Console.Write("Minuten 1: ");
input = Console.ReadLine();
minutes1 = int.Parse(input);

Console.Write("Stunden 2: ");
input = Console.ReadLine();
hour2 = int.Parse(input);

Console.Write("Minuten 2: ");
input = Console.ReadLine();
minutes2 = int.Parse(input);

//Verarbeitung
sum1 = minutes1 + minutes2;
sum2 = hour1 + hour2;	


//Ausgabe
Console.WriteLine("");
Console.WriteLine($"   {hour1:00}:{minutes1:00}");
Console.WriteLine($"+  {hour2:00}:{minutes2:00}");
Console.WriteLine($"=  {sum2:00}:{sum1:00}");

Console.ReadLine();