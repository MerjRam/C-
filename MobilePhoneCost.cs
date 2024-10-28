/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Mobile Phone Cost
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
double monthly          = 0.0;
double service          = 0.0;
double activation       = 0.0;
double annualCost       = 0.0;
double monthlyCost      = 0.0;
double firstyearMonthly = 0.0;
double firstyearAnnual  = 0.0;

Console.Write("Enter the monthly cost: ");
input   = Console.ReadLine();
monthly = double.Parse(input);

Console.Write("Enter the annual service fee: ");
input   = Console.ReadLine();
service = double.Parse(input);


Console.Write("Enter the one-time activation fee cost: ");
input      = Console.ReadLine();
activation = double.Parse(input);

if(monthly < 0 || monthly > 1000)
{
	Console.Write("Error! Enter the monthly cost: ");
}

if(service < 0 || service > 1000)
{
	Console.Write("Error! Enter the annual service fee: ");
}
if(activation < 0 || activation > 1000)
{
	Console.Write("Error! Enter the one-time activation fee cost: ");
	
}
monthlyCost = monthly + (service /12 );
annualCost  = monthlyCost * 12;

firstyearMonthly = monthly + (service /12 ) + (activation/12);
firstyearAnnual = firstyearMonthly * 12;
if (activation != 0)
{
	Console.WriteLine($"First yeah cost: {firstyearAnnual:F2} Euro, monthly {firstyearMonthly:F2} Euro  ");
	Console.WriteLine($"Annual cost: {annualCost:F2} Euro, monthly {monthlyCost:F2} Euro ");
}
else
{
	Console.WriteLine($"Annual cost: {annualCost:F2} Euro, monthly {monthlyCost:F2} Euro ");
}



Console.WriteLine();

