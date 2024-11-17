/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Decimal to binary
*-------------------------------------------------------------------------------------------
*/
using System;
using System.ComponentModel.Design;

string input;
string exit    = "";
int number     = 0;
string binary  = "";
int temp       = 0;



Console.WriteLine("Convert decimal to binary");
Console.WriteLine("");
do
{
    Console.Write("Please enter decimal value [int]: ");
    input = Console.ReadLine();
    number = int.Parse(input);

    temp = Math.Abs(number);  //macht eine Kopie der Positivenzahl 
    binary = ""; //un sie zrückzusetzten
    if(temp == 0)
    {
        binary = "0";
    }
    else
    {
        while (temp > 0)
        {
            binary = (temp % 2) + binary;
            temp = temp / 2;
        }
    }
    if(number < 0)
    {
        binary = "-" + binary; // damit die neg Zahl ein minus bekommt
    }
    Console.Write($"Decimal number: {number} as binary: {binary}");

    Console.WriteLine("");
    Console.Write("\nEnter the letter x if you want to exit: ");
    exit = Console.ReadLine();

}while (exit != "x");