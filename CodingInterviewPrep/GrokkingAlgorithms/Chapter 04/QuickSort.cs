using System;

namespace GrokkingAlgorithms
{
    public class QuickSort
    {
        public int[] Sort(int[] items, int leftIndex, int rightIndex)
        {
            if(items.Length < 2)
            {
                return items;
            } 

            if(leftIndex < rightIndex)
            {
                var pivot = Partition(items, leftIndex, rightIndex);
                Sort(items, 0, pivot);
                Sort(items, pivot+1, rightIndex);
            }

            return items;
        }

        private int Partition(int[] items, int leftIndex, int rightIndex)
        {
            int pivot = items[leftIndex];
            while(true)
            {
                if(leftIndex < rightIndex)
                {

                }

                while(items[leftIndex] < pivot)
                {
                    leftIndex++;
                }

                while(items[rightIndex] > pivot)
                {
                    rightIndex--;
                }

                if(leftIndex < rightIndex)
                {
                    Swap(items, leftIndex, rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
                else
                {
                    return rightIndex;
                }
            }
        }

        private void Swap(int[] items, int leftIndex, int rightIndex)
        {
            var temp = items[leftIndex];
            items[leftIndex] = items[rightIndex];
            items[rightIndex] = temp;
        }
    }
}