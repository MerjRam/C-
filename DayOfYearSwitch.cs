/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			Day Of Year Switch
*-------------------------------------------------------------------------------------------
*/
using System;

string input;
int month = 0;
int day = 0;
string leapyear = "";
int maxday = 31;
int sumday = 0;


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
	Console.WriteLine($"Ungültiger Tag! Im Monat {month} gilt: 1 <= {day} <= {maxday}");
}
else
{
	switch(month)
	{
		case 1:
			sumday = day;
			break;
		case 2:
			sumday = 31 + day;
			break;
		case 3:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + day;
			break;
		case 4:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + day;
			break;
		case 5:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + day;
			break;
		case 6:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + day;
			break;
		case 7:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + 30 + day;
			break;
		case 8:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + day;
			break;
		case 9:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + day;
			break;
		case 10:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + 30 + day;
			break;
		case 11:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + day;
			break;
		case 12:
			sumday = 31 + (leapyear == "Y" ? 29 : 28) + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + day;
			break;
	}
	
}

  
Console.WriteLine($"Date of the year {month} : {day} = {sumday}"); 
Console.WriteLine();