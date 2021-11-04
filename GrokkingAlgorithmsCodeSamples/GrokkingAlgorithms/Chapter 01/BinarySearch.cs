using System;

namespace GrokkingAlgorithms
{
    // These assume the items are already sorted
    public class BinarySearch
    {
        public bool FindItem(int[] items, int item)
        {
            var low = 0;
            var high = items.Length - 1;

            while(low <= high) 
            {
                var mid = (low + high) / 2;
                if(item == items[mid]) {
                    return true;
                }
                else if (item < items[mid]) {
                    high = mid - 1;
                } else if(item > items[mid]) {
                    low = mid + 1;
                }
            }

            return false;
        }
    }
}