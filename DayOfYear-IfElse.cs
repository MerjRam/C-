/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Day Of Year
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
string leapyear;
int month = 0;
int day = 0;
int maxday = 31;

Console.Write("Please enter month [1..12]");
input = Console.ReadLine();
month = int.Parse(input);

Console.Write("Pleasse enter day [1..31]");
input = Console.ReadLine();
day = int.Parse(input);

Console.Write("Leap Yeahr? [y/n]");
leapyear = Console.ReadLine();
leapyear = leapyear.ToUpper();

if(month == 2)
{	
	if (leapyear == "Y" )
	{
		maxday = 29;
	}
	else if (leapyear == "N" )
	{
		maxday = 28;
	}
}
else if((month == 4 ) || (month == 6 ) || (month == 9 ) || (month == 11 ))
{
	maxday = 30;
}

if (day < 1 || day > maxday)
{
	Console.Write($"Ungültiger Tag! Im Monat {month} gilt: 1 <= {day} <= {maxday}");
}
else
{	
	int dayOfYear = day;
	
	if(month > 1)
	{
		dayOfYear = dayOfYear + 31;
	}
	if(month > 2)
	{	
		if (leapyear == "Y")
		{
			dayOfYear = dayOfYear + 29;
		}
		else if (leapyear == "N" )
		{
			dayOfYear = dayOfYear + 28;
		}
	}
	if(month > 3)
	{
		dayOfYear = dayOfYear + 31;
	}
	if(month > 4)
	{
		dayOfYear = dayOfYear + 30;
	}
	if(month > 5)
	{
		dayOfYear = dayOfYear + 31;
	}
	if(month > 6)
	{
		dayOfYear = dayOfYear + 30;
	}
	if(month > 7)
	{
		dayOfYear = dayOfYear + 31;
	}
	if(month > 8)
	{
		dayOfYear = dayOfYear + 31;
	}
	if(month > 9)
	{
		dayOfYear = dayOfYear + 30;
	}
	if(month > 10)
	{
		dayOfYear = dayOfYear + 31;
	}
	if(month > 11)
	{
		dayOfYear = dayOfYear + 30;
	}
	Console.Write($"Day of the year {month}:{day} = {dayOfYear} ");
}

	
Console.ReadLine();