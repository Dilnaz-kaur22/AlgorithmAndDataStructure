// Algorithmsd and Data Structure
//Lab 1 

using System;
using System.Text.RegularExpressions;

int n = 0;

while (n <= 0)
{
    Console.WriteLine("\n Please! Enter an integer value greater than 0.");
    n = Int32.Parse(Console.ReadLine());
}

// Prevent user to countinuing if enters space between words.

string[] wordsArr = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\n Enter word {i + 1}:");
    string newWordsArr = Console.ReadLine();

    if (newWordsArr.Length > 0 && !newWordsArr.Contains(" ") && Regex.IsMatch(newWordsArr, @"^[a-zA-Z]+$"))
    //Regex.IsMatch(input, @"^[a-zA-Z]+$") helps to validate that input contains only letters.
    {
        wordsArr[i] = newWordsArr.ToLower();
    }
    else
    {
        Console.WriteLine("\n Please! Enter atleast one character");
        i--;
    }
}

//Prompt the user to enter a character to count and confirm the character entered is a letter.

char charToCount = ' ';

while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("\n Please! Enter a character to count ");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
}

Console.WriteLine($"\n You entered character: '{charToCount}'");

//get a number of occurrences of the character.

int charCount = 0;
int totalCharCount = 0;

foreach (string word in wordsArr)
{
    char[] chars = word.ToCharArray();
    foreach (char c in chars)
    {
        if (Char.ToLower(c) == Char.ToLower(charToCount))
        {
            charCount++;
        }
        totalCharCount++;
    }
}

Console.WriteLine("\n The character '" + charToCount + "' occurs '" + charCount + "' times in the array :) ");

//Percentage of character

double percent = 100 * charCount / totalCharCount;
Console.WriteLine("\n Percentage of '" + charToCount + "' is: " + percent);

if (percent > 25)
{
    Console.WriteLine("\n The letter '" + charToCount + "' makes more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine("\n The letter '" + charToCount + "' can't make more than 25% of the total number of characters.");
}





