using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class IsUnique
    {
        public bool CheckIfUnique(string checkMe)
        {
            var letterTracker = new Dictionary<char, bool>();
            foreach(var letter in checkMe)
            {
                if(letterTracker.ContainsKey(letter))
                {
                    return false;
                }
                else
                {
                    letterTracker[letter] = true;
                }
            }

            return true;
        }

        public bool CheckIfUniqueWithNoDatastructures(string checkMe)
        {
            var index = 1;
            foreach(var letter in checkMe)
            {
                for(int i = index; i < checkMe.Length; i++)
                {
                    if(letter == checkMe[i])
                    {
                        return false;
                    }
                }
                index++;   
            }

            return true;
        }
    }
}