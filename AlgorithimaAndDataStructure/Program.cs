// Algorithim And Data Structure 
// Lab 2

using System;
using System.Text;

// Program 1
Console.WriteLine("\n Program 1");
Console.WriteLine('\n Enter a sentence to check chracters that appear morwe than once.');
string repeatChar = Console.ReadLine();
String repeatCharlower = repeatChar.ToLower();
StringBuilder charRepeat = new StringBuilder();

foreach (char c in repeatCharlower)
{
    int count = 0;
    for (i = 0; i < repeatCharlower.Length; i++)
    {
        if (c == repeatCharlower[i])
        {
            count++;
        }
        if (count > 1 && charRepeat.ToString().IndexOf(c) == -1)
        {
            charRepeat.Append(c);
        }
    }
}

Console.WriteLine(charRepeat);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

//Program 2
Console.WriteLine("\n Program 2")
Console.WriteLine("n Enter a sentence to check unique words.");
string uniqueInput= Console.ReadLine();
string[] uniqueChars = uniqueInput.Split(' ');
StringBuilder uniqueWords = new StringBuilder();

for (int i = 0; i < uniqueChars.Lenght; i++)
{
    if (!uniqueWords.ToString().Contains(uniqueChars[i].Tolower()))
    {
        uniqueWords.Append(uniqueChars[i].ToLower()).Apeend(" ");
    }
}

Console.WriteLine(uniqueWords);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

//Program 3 
Console.WriteLine("\n Program 3");
Console.WriteLine("\n Enter a sentence to reverse");
string reverseSen = Console.ReadLine();
StringBuilder reverseWords = new StringBuilder();

for (int i = reverseSen.Lenght -1; i>=0; i--)
{
    reverseWords.Append(reverseSen[i]);
}

Console.WriteLine(reverseWords);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

//Program 4
Console.WriteLine("\n Program 4");
Console.WriteLine("\n Enter a sentence to check longest word.");
string sentenceInput = Console.ReadLine();
string lowerInput = sentenceInput.ToLower();
string[] wordArr = lowerInput.Split(" ");
StringBuilder longWord = new StringBuilder();

for (int i = 0; i< wordArr.Length -1; i++)
{
    if (wordArr[i].Length > wordArr[i + 1].Length)
    {
        string longWord = wordArr[i];
        longWord.Append(wordArr[i]);
    }
}

Console.Write(longWord);
// Algorithim And Data Structure 
// Lab 2

using System;
using System.Text;

// Program 1
Console.WriteLine("\n Program 1");
Console.WriteLine('\n Enter a sentence to check chracters that appear morwe than once.');
string repeatChar = Console.ReadLine();
String repeatCharlower = repeatChar.ToLower();
StringBuilder charRepeat = new StringBuilder();

foreach (char c in repeatCharlower)
{
    int count = 0;
    for (i = 0; i < repeatCharlower.Length; i++)
    {
        if (c == repeatCharlower[i])
        {
            count++;
        }
        if (count > 1 && charRepeat.ToString().IndexOf(c) == -1)
        {
            charRepeat.Append(c);
        }
    }
}

Console.WriteLine(charRepeat);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

//Program 2
Console.WriteLine("\n Program 2")
Console.WriteLine("n Enter a sentence to check unique words.");
string uniqueInput = Console.ReadLine();
string[] uniqueChars = uniqueInput.Split(' ');
StringBuilder uniqueWords = new StringBuilder();

for (int i = 0; i < uniqueChars.Lenght; i++)
{
    if (!uniqueWords.ToString().Contains(uniqueChars[i].Tolower()))
    {
        uniqueWords.Append(uniqueChars[i].ToLower()).Apeend(" ");
    }
}

Console.WriteLine(uniqueWords);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

//Program 3 
Console.WriteLine("\n Program 3");
Console.WriteLine("\n Enter a sentence to reverse");
string reverseSen = Console.ReadLine();
StringBuilder reverseWords = new StringBuilder();

for (int i = reverseSen.Lenght - 1; i >= 0; i--)
{
    reverseWords.Append(reverseSen[i]);
}

Console.WriteLine(reverseWords);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

//Program 4
Console.WriteLine("\n Program 4");
Console.WriteLine("\n Enter a sentence to check longest word.");
string sentenceInput = Console.ReadLine();
string lowerInput = sentenceInput.ToLower();
string[] wordArr = lowerInput.Split(" ");
StringBuilder longWord = new StringBuilder();

for (int i = 0; i < wordArr.Length - 1; i++)
{
    if (wordArr[i].Length > wordArr[i + 1].Length)
    {
        string longWord = wordArr[i];
        longWord.Append(wordArr[i]);
    }
}

Console.Write(longWord);
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

/*
 Addvantage of StringBuilder over string:

~ Strings are immutable which means a string cannot be change once created whereas,
  Stringbuilder are mutable which means that it can be modify without creating a
  each time,

~ Stringbuilder performs faster than a string if ypu modify a string value multiple times.
 */


/*
 Addvantage of StringBuilder over string:

~ Strings are immutable which means a string cannot be change once created whereas,
  Stringbuilder are mutable which means that it can be modify without creating a
  each time,

~ Stringbuilder performs faster than a string if ypu modify a string value multiple times.
 */
