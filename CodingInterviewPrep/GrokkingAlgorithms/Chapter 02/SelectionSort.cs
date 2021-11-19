using System;
using System.Collections.Generic;

namespace GrokkingAlgorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] unsorted)
        {
            var unsortedList = new List<int>(unsorted);
            var sortedArray = new int[unsorted.Length];
            var count = unsortedList.Count;

            for(int i = 0; i < count; i++)
            {
                var smallestIndex = FindIndexOfSmallestValue(unsortedList);
                sortedArray[i] = unsortedList[smallestIndex];
                unsortedList.RemoveAt(smallestIndex);
            }
            
            return sortedArray;
        }

        // Assume not empty
        private int FindIndexOfSmallestValue(List<int> items)
        {
            var smallestIndex = 0;
            var smallestValue = items[0];

            for(int i = 0; i < items.Count; i++)
            {
                if(items[i] < smallestValue)
                {
                    smallestIndex = i;
                    smallestValue = items[i];
                }
            }

            return smallestIndex;
        }
    }
}