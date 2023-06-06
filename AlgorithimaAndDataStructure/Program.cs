//AlgorithmsAndDataStructures 
//Lab4


using System;
using System.Collections.Generic;

//Program 3
// Take help from https://www.educative.io/answers/how-to-sort-a-list-in-c-sharp this website
// Acc to me its eassy method and also explains well :)

class OrderBySorting
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 2, 1, -5, 3 };
        numbers.Sort();  // Sort the list in an ascending order

        Console.WriteLine("Sorted numbers:");
        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            Console.WriteLine(number);
        }
    }
}

// Time complexity should be O(n)

static int HigestValues(List<int> values)
{
    int highestInt = 0;
    foreach (int num in values)
    {
        if (num > highestInt)
        {
            highestInt = num;
        }
    }
    return highestInt;
}

//Program 1

List<List<int>> givenList = new List<List<int>>
                       {
                       new List<int> { 1, 5, 3 }, new List<int> { 9, 7, 3, -2 }, new List<int> { 2, 1, 2 }
                       };
List<int> maxNumbers = MaxNumbersInLists(givenList);
for (int i = 0; i < maxNumbers.Count; i++)
{
    Console.Write($"List {i + 1} has a maximum of {maxNumbers[i]}, ");
}

static List<int> MaxNumbersInLists(List<List<int>> givenList)
{
    if (givenList.Count == 0)
    {
        throw new Exception("Please enter a non-empty list");
    }
    List<int> maxNumbers = new List<int>();
    for (int i = 0; i < givenList.Count; i++)
    {
        int max = HigestValues(givenList[i]);
        maxNumbers.Add(max);
    }
    return maxNumbers;
}
Console.WriteLine();
// Time complexity should be O(n)^2 


//Program 2

List<List<int>> grades = new List<List<int>>
{ new List<int> { 85,92, 67, 94, 94 }, new List<int> { 50, 60, 57, 95 }, new List<int> { 95 } };
Console.WriteLine(HighestGradeinlist(grades));

string HighestGradeinlist(List<List<int>> list)
{
    int grade = 0;
    int index = 0;

    foreach (List<int> l in list)
    {
        if (HigestValues(l) > grade)
        {
            grade = HigestValues(l);
        }

        if (l.Contains(grade))
        {
            index = list.IndexOf(l);
        }
    }

    return $"The highest grade is {grade}. This grade was found in class(es) {index + 1}";
};

//Time complexity should be O(n)^2 




