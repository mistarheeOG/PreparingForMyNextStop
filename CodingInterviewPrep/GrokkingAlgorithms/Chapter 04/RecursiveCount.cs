namespace GrokkingAlgorithms
{
    // Exercise 4.2
    public class RecursiveCount
    {
        public int Count(int[] items)
        {
            if(items.Length == 0)
            {
                return 0;
            }

            if(items.Length == 1)
            {
                return 1;
            } 
            
            var tempList = new int[items.Length - 1];
            for(int i = 1; i < items.Length; i++)
            {
                tempList[i-1] = items[i];
            }

            return 1 + Count(tempList);
        }
    }
}