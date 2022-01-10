/* 
Sorts an array of 10 randomised values between 0 and 9 using implementations of various common sort algorithms and tests the result in console.
*/
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main (string[] args)
        { 
            int[] array = new int[10];

            FillRandArray(array);
            Console.WriteLine("----BUBBLE SORT----");
            Console.Write("Number sequence before sort: ");
            PrintSequence(array);

            Console.Write("\nBubble Sort Test: ");
            BubbleSort.Sort(array);
            PrintSequence(array);

        
            FillRandArray(array);
            Console.WriteLine("\n----MERGE SORT----");
            Console.Write("Number sequence before sort: ");
            PrintSequence(array);

            Console.Write("\nMerge Sort Test: ");
            MergeSort.Sort(array, 0, array.Length);
            PrintSequence(array);
        
        }

        static void FillRandArray (int[] array)
        {
            Random rand = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
            }
        }

        static void PrintSequence(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number.ToString() + " ");
            }
        }

    }
}