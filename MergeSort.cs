using System;

namespace SortingAlgorithms
{
    class MergeSort 
    {
        static void Merge(int[] array, int leftIndex, int rightIndex, int endIndex) 
        {
            int leftLen = rightIndex - leftIndex;
            int rightLen = endIndex - rightIndex;
        
            int[] left = new int[leftLen];
            int[] right = new int[rightLen];

            // Copying data from the array to left and right arrays
            for (int i = 0; i < leftLen; i++)
            {
                left[i] = array[leftIndex + i];
            }
            for (int j = 0; j < rightLen; j++)
            {
                right[j] = array[rightIndex + j];
            }

            int mergeIndex = leftIndex;
            int leftIndexMerge = 0;
            int rightIndexMerge = 0;

            // Merges the left and right arrays in the original array
            while (leftIndexMerge < leftLen && rightIndexMerge < rightLen) 
            {
                if (left[leftIndexMerge] <= right[rightIndexMerge])
                {
                    array[mergeIndex++] = left[leftIndexMerge++];
                }
                else
                {
                    array[mergeIndex++] = right[rightIndexMerge++];
                }
            }
        
            while (leftIndexMerge < leftLen)
            {
                array[mergeIndex++] = left[leftIndexMerge++];
            }
        }
        
        public static void Sort(int[] array, int leftIndex, int endIndex) 
        {
            if (endIndex - leftIndex >= 2) 
            {
                int midpoint = leftIndex + (endIndex - leftIndex) / 2;

                Sort(array, leftIndex, midpoint);
                Sort(array, midpoint, endIndex);

                Merge(array, leftIndex, midpoint, endIndex);
            }
        }
    }
}