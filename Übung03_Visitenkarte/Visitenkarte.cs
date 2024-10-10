/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*	Visitenkarte
*-------------------------------------------------------------------------------------------
*/
using System;

string name;
string residence;


Console.Write("Please enter your name: ");
name = Console.ReadLine();
Console.Write("Please enter your residence: ");
residence = Console.ReadLine();


Console.WriteLine("*************************");
Console.WriteLine($"*   {name,-20}*");
//Console.Write("*");
Console.WriteLine("*************************");
Console.WriteLine($"*   {residence,-20}*");
//Console.Write("*");
Console.WriteLine("*************************");


Console.ReadLine();