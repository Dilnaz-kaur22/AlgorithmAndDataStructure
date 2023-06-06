//Algorithm and Data Structures
//Lab 3

using System;

// Program 1
// Solve this problem with the help of 2-3 youtube tutorials :)

public class Duplicate
{
    public static void Main(string[] args)
    {
        int[] numArr = { 1, 2, 3, 4, 7, 9, 2, 4 };
        for (int i = 0; i < numArr.Length; i++)
        {
            for (int j = i + 1; j < numArr.Length; j++)
            {
                if (numArr[i] == numArr[j])
                {
                    Console.WriteLine(numArr[i]);
                }
            }
        }

    }
}


//Program 2
// Take help from this website https://techstudy.org/csharp/write-csharp-program-to-merge-two-sorted-array

class Merging
{
    static void Main()
    {

        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] mergeArray = new int[20];

        int size1, size2, mergeSize;
        int index1, index2, mergeIndex;
        int i;

        //Reads size of the array
        Console.WriteLine("Enter the size of 1st array should be less than 10:");
        size1 = Convert.ToInt32(Console.ReadLine());

        //Reads elements in array
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < size1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }


        //Reads size of the array
        Console.WriteLine("Enter the size of 2nd array should be less than 10:");
        size2 = Convert.ToInt32(Console.ReadLine());

        //Reads elements in array
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < size2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        mergeSize = size1 + size2;


        //Merging two array in ascending order
        index1 = 0;
        index2 = 0;
        for (mergeIndex = 0; mergeIndex < mergeSize; mergeIndex++)
        {

            //If all elements of one array is merged to final array
            if (index1 >= size1 || index2 >= size2)
            {
                break;
            }
            if (arr1[index1] < arr2[index2])
            {
                mergeArray[mergeIndex] = arr1[index1];
                index1++;
            }
            else
            {
                mergeArray[mergeIndex] = arr2[index2];
                index2++;
            }
        }

        //Merging the remaining elements of array
        while (index1 < size1)
        {
            mergeArray[mergeIndex] = arr1[index1];
            mergeIndex++;
            index1++;
        }
        while (index2 < size2)
        {
            mergeArray[mergeIndex] = arr2[index2];
            mergeIndex++;
            index2++;
        }

        //Print merged array
        Console.WriteLine("\nArray merged in ascending order : ");
        for (i = 0; i < mergeSize; i++)
        {
            Console.Write("\t" + mergeArray[i]); ;
        }

        Console.ReadLine();
    }

}



// Program 3

/*To solve this problem, I search online but lost the link of the page from 
where I solved this problem */

class Reversed
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a No. to reverse");
        int numArr = int.Parse(Console.ReadLine());
        int reverseArr = 0;
        while (numArr > 0)
        {
            int remainder = numArr % 10;
            reverseArr = (reverseArr * 10) + remainder;
            numArr = numArr / 10;
        }
        Console.WriteLine("Reverse No. is {0}", reverseArr);
    }
}

// The time complexity of solution is O(n)
