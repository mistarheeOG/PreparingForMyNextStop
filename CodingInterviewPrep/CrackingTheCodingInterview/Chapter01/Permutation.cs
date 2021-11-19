using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class Permutation
    {
        public bool CheckIfSecondIsPermutationOfFirst(string first, string second)
        {
            if(first.Length != second.Length)
            {
                return false;
            }

            var firstHash = new Dictionary<char, int>();
            foreach(char letter in first)
            {
                if(!firstHash.ContainsKey(letter))
                {
                    firstHash[letter] = 1;
                }
                else 
                {
                    firstHash[letter] += 1;
                }
            }

            var secondHash = new Dictionary<char, int>();
            foreach(char letter in second)
            {
                if(!secondHash.ContainsKey(letter))
                {
                    secondHash[letter] = 1;
                }
                else 
                {
                    secondHash[letter] += 1;
                }
            }

            foreach(char key in firstHash.Keys)
            {
                if(!secondHash.ContainsKey(key) || firstHash[key] != secondHash[key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}