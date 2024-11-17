/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Sum of digit
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
int number = 0;
string cont;
int sum = 0;
string sumPlus = "";


Console.WriteLine("Sum of digit calculation");
Console.WriteLine("========================");
do
{
    Console.Write("");
    Console.Write("Please enter a number [1..int.max]:");
    input = Console.ReadLine();
    number = int.Parse(input);

    sum =  0;
 
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;  
    }
  
    Console.Write($"Sum of digits = {sum}");

    Console.Write("\nContinue[Yes/No]:");
    cont = Console.ReadLine().ToUpper();
} while (cont != "NO");


