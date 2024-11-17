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

Console.Write("Monatliche Kosten:                    ");
string input = Console.ReadLine();
double monthly = double.Parse(input);

if(monthly < 0 || monthly > 1000)
{
	Console.Write($"Monatliche Kosten ERROR!         ");
	return;
}

Console.Write($"Jährliche Servicepauschale:          ");
input = Console.ReadLine();
double service = double.Parse(input);


if(service <= 0 || service > 1000)
{
	Console.Write($"Jähliche Servocepauschale ERROR!" );
	return;
}

Console.Write("Einamlige Aktivierungsentgelt:",30);
input = Console.ReadLine();
double activating = double.Parse(input);

double monthlyCost = monthly + (service / 12);
double annualCost  = monthlyCost * 12;

double fistYM = monthly + ((service + activating) / 12);;
double fistYY = fistYM * 12 ;

if(activating <= 0 || activating > 1000)
{
	Console.Write($"Jähliche Kostent: {annualCost:F2} Euro, Monatliche Kosten: {monthlyCost,20:F2}");
	
}
else
{
	Console.WriteLine($"Erstes Jahr: {fistYY:F2} Euro, Monatliche Kosten: {fistYM,20:F2} Euro");
	Console.WriteLine($"Jähliche Kostent: {annualCost:F2} Euro, Monatliche Kosten: {monthlyCost,15:F2} Euro");
}



Console.WriteLine();