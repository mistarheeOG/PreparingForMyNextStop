using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class PalindromePermutation
    {
        public bool CheckIfPalindromePermutation(string checkMe)
        {
            var letterCount = new Dictionary<char, int>();
            foreach(char letter in checkMe)
            {
                if(letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount[letter] = 1;
                }   
            }

            var oddCount = 0;
            foreach(int count in letterCount.Values)
            {
                if(count %2 != 0)
                {
                    oddCount++;
                }
            }

            return oddCount <= 1;
        }
    }
}