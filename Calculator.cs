/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Calculator
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
string op;
double number1 = 0.0;
double number2 = 0.0;
double result  = 0.0;

Console.WriteLine("********************************************");

Console.WriteLine("*  Calculator - Ihr Zahlenbegleiter        *");

Console.WriteLine("*                                          *");

Console.WriteLine("********************************************");

//Eingabe

Console.Write("1. Zahl eingeben:");
input 	= Console.ReadLine();
number1 = double.Parse(input);

Console.Write("2. Zahl eingeben:");
input 	= Console.ReadLine();
number2 = double.Parse(input);

Console.Write("Operation eingeben [ + - * /]:");
op = Console.ReadLine();

//Verarbeitung 
if ( number2 == 0)
{
	Console.WriteLine("Division durch 0 ist nicht erlaubt!");
} 
else
{
	if( op == "+")
	{
		result = number1 + number2;
		Console.Write($"Ergebnis von {number1} {op} {number2} = {result}");
	}
	else if( op == "-")
	{
		result = number1 - number2;
		Console.Write($"Ergebnis von {number1} {op} {number2} = {result}");
	}
	else if( op == "*")
	{
		result = number1 * number2;
		Console.Write($"Ergebnis von {number1} {op} {number2} = {result}");
	}
	else if( op == "/")
	{
		result = number1 / number2;
		Console.Write($"Ergebnis von {number1} {op} {number2} = {result}");
	}
	else 
	{
		Console.WriteLine("Falsche Rechenart! ");
	}
}

Console.ReadLine();