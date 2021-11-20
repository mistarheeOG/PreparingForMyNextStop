using System;

namespace CrackingTheCodingInterview
{
    public class OneAway
    {
        public bool CheckIfOneAway(string first, string second)
        {
            if(Math.Abs(first.Length - second.Length) >= 2)
            {
                return false;
            }

            var maxLength = Math.Max(first.Length, second.Length);
            var numberOfDifferences = 0;
            int firstAdjustment = 0;
            int secondAdjustment = 0;

            for(int i = 0; i < maxLength; i++)
            {
                char? firstValue = null;
                char? secondValue = null;

                if(first.Length > i+firstAdjustment)
                {
                    firstValue = first[i+firstAdjustment];
                }

                if(second.Length > i+secondAdjustment)
                {
                    secondValue = second[i+secondAdjustment];
                }
                
                if(firstValue != secondValue)
                {
                    numberOfDifferences++;
                    if(first.Length > i+1 && first[i+1] == second[i])
                    {
                        firstAdjustment++;
                    }

                    if(second.Length > i+1 && second[i+1] == first[i])
                    {
                        secondAdjustment++;
                    }
                }
            }

            return numberOfDifferences <= 1;
        }
    }
}