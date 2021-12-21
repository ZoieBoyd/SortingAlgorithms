using System;

namespace SortingAlgorithms
{
    class BubbleSort 
    {
        public static void Sort(int[] array)
        {
            int temp;

            for (int i = 0; i <= array.Length - 2; i++)
            {               
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }  
}
