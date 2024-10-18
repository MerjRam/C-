/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*			GrownUpCalculator
*-------------------------------------------------------------------------------------------
*/
using System;

//Eingabe

string input;
int age = 0;
int till = 0;

Console.WriteLine("Geben Sie Ihren Alter ein:");
input = Console.ReadLine();
age   = int.Parse(input);

if((age >= 18) && (age <= 20))
{   
	Console.WriteLine("Grown Up!");
}
else
{
    if(age <= 18)
    {
        
		if(age <= 15)//Eingefügt 
		{
			Console.WriteLine("Es wird noch sehr lange dauern, bis Sie 18 werden!");
		}
		else 
		{
			till= 18 - age;
			Console.WriteLine("Sie haben noch " + till +" Jahre bis 18.");
		}
		
    }
    else
    {
		if((age == 25 )||(age == 50))
		{
			Console.WriteLine("Alles Gute zum runden Geburtstag!");
		}
		else
		{
			if((age >= 65) && (age <= 120))
				if(age == 75 )//Eingefügt
				{
					Console.WriteLine("Alles Gute zum runden Geburtstag!");
				}
				else 
				{
					Console.WriteLine("Hallo Senior");
				}
			else
			{
				if(age > 120)
				{
					Console.WriteLine("Zombi");
				}
				else
				{
					Console.WriteLine("Guten Tag");
				}
			}
		}
    }
}

Console.ReadLine();