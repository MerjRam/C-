/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Sort 3 Values
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
int v1   = 0;
int v2   = 0;
int v3 	 = 0;
int temp = 0;

Console.Write("Enter the first Value: ");
input = Console.ReadLine();
v1    = int.Parse(input);

Console.Write("Enter the secound Value: ");
input = Console.ReadLine();
v2    = int.Parse(input);

Console.Write("Enter the last Value: ");
input = Console.ReadLine();
v3    = int.Parse(input);

if(v1 > v2)
{
	temp = v1;
	v1 = v2;
	v2 = temp;
}
if( v2 > v3)
{
	temp = v2;
	v2 = v3;
	v3 = temp;
}
if(v1 > v2)
{
	temp = v1;
	v1 = v2;
	v2 = temp;
}
Console.WriteLine($"Sorted values: {v1},{v2},{v3}");

Console.WriteLine();











Console.WriteLine();