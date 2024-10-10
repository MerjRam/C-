/*------------------------------------------------------------------------------------------
*HTBLA-Leonding/Class: 3ACIF											
*-------------------------------------------------------------------------------------------
*Merjem Ramic
*-------------------------------------------------------------------------------------------
*Description:
*	WordShuffle
*-------------------------------------------------------------------------------------------
*/
using System;

string word1;
string word2;
string word3;


Console.WriteLine("Word Shuffle");
Console.WriteLine("============");
Console.WriteLine("");
Console.Write("Pleace enter 1st word: ");
word1 = Console.ReadLine();
Console.Write("Pleace enter 2st word: ");
word2 = Console.ReadLine();
Console.Write("Pleace enter 3st word: ");
word3 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Shuffling words ... six possible combinations: ");
Console.WriteLine(" ");
Console.WriteLine(word1+"  "+word2+"  "+word3);
Console.WriteLine(word1+"  "+word3+"  "+word2);
Console.WriteLine(word2+"  "+word3+"  "+word1);
Console.WriteLine(word2+"  "+word1+"  "+word3);
Console.WriteLine(word3+"  "+word1+"  "+word2);
Console.WriteLine(word3+"  "+word2+"  "+word1);

Console.ReadLine();