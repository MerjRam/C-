/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*	Greeting
*-------------------------------------------------------------------------------------------
*/
using System;

string firstname;
string lastname;
string residence;

Console.Write("Bitte geben Sie Ihren Vornamen ein: ");
firstname = Console.ReadLine();
Console.Write("Bitte geben Sie Ihren Nachnamen ein: ");
lastname = Console.ReadLine();
Console.Write("Bitte geben Sie Ihren Wohnort ein: ");
residence = Console.ReadLine();
Console.Write("Herzlich Willkommen ");
Console.Write(firstname);
Console.Write(" ");
Console.Write(lastname);
Console.Write(" aus ");
Console.Write(residence);
Console.Write(" zu C#!");


Console.ReadLine();