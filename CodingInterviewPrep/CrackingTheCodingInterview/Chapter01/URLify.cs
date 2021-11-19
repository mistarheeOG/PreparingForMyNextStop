using System;

namespace CrackingTheCodingInterview
{
    public class URLify
    {
        public string Transform(string transformMe)
        {
            var charArray = transformMe.ToCharArray();

            var lastEmptyPosition = charArray.Length - 1;
            var startTranform = false;
            for(int i = charArray.Length - 1; i >= 0; i--)
            {
                if(charArray[i] != ' ')
                {
                    startTranform = true;
                }

                if(startTranform)
                {
                    if(charArray[i] == ' ')
                    {
                        charArray[lastEmptyPosition--] = '0';
                        charArray[lastEmptyPosition--] = '2';
                        charArray[lastEmptyPosition--] = '%';
                    }
                    else
                    {
                        charArray[lastEmptyPosition--] = charArray[i];
                    }
                }
            }

            return new string(charArray);
        }
    }
}