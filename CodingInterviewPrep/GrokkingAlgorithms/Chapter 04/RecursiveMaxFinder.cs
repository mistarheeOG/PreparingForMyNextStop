namespace GrokkingAlgorithms
{
    // Exercise 4.3
    public class RecursiveMaxFinder
    {
        public int FindMax(int[] items)
        {
            if(items.Length == 0)
            {
                return 0;
            }

            if(items.Length == 1)
            {
                return items[0];
            } 
            
            var tempList = new int[items.Length - 1];
            for(int i = 1; i < items.Length; i++)
            {
                tempList[i-1] = items[i];
            }

            var compareMe = FindMax(tempList);
            var currentNumber = items[0];
            if(compareMe > currentNumber) {
                return compareMe;
            }

            return currentNumber;
        }
    }
}