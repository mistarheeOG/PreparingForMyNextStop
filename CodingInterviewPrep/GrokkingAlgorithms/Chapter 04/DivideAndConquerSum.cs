namespace GrokkingAlgorithms
{
    // Exercise 4.1
    public class DivideAndConquerSum
    {
        public int Sum(int[] items)
        {
            return Add(items, 0);
        }

        private int Add(int[] items, int number)
        {
            if(items.Length == 0)
            {
                return number;
            }

            if(items.Length == 1)
            {
                return items[0] + number;
            } 
            
            var firstNumber = items[0];
            var tempList = new int[items.Length - 1];
            for(int i = 1; i < items.Length; i++)
            {
                tempList[i-1] = items[i];
            }

            return number + Add(tempList, firstNumber);
        }
    }
}