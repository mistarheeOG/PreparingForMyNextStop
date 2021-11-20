using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview
{
    public class StringCompression
    {
        public string Compress(string compressMe)
        {
            var compressionCount = CompressionLengthCount(compressMe);
            Console.WriteLine(compressionCount);
            if(compressionCount >= compressMe.Length)
            {
                return compressMe;
            }

            var newString = new StringBuilder(compressionCount);
            var letterCount = 0;
            char? lastLetter = null;
            var index = 0;

            foreach(char letter in compressMe)
            {
                if(index == 0)
                {
                    lastLetter = letter;
                    newString.Append(letter);
                    letterCount = 1;
                    index++;
                }
                else
                {
                    if(letter != lastLetter)
                    {
                        var count = letterCount.ToString();
                        newString.Append(count);
                        index+=count.Length;
                        newString.Append(letter);
                        index++;
                        letterCount = 1;
                        lastLetter = letter;
                    }
                    else
                    {
                        letterCount++;
                    }
                }
            }

            var finalCount = letterCount.ToString();
            newString.Append(finalCount);
            index+=finalCount.Length;

            return newString.ToString();
        }

        private int CompressionLengthCount(string compressMe)
        {
            var letterCount = 0;
            char? lastLetter = null;
            var index = 0;

            foreach(char letter in compressMe)
            {
                if(index == 0)
                {
                    lastLetter = letter;
                    letterCount = 1;
                    index++;
                }
                else
                {
                    if(letter != lastLetter)
                    {
                        var count = letterCount.ToString();
                        index+=count.Length;
                        letterCount = 1;
                        lastLetter = letter;
                        index++;
                    }
                    else
                    {
                        letterCount++;
                    }
                }
            }

            var finalCount = letterCount.ToString();
            index+=finalCount.Length;

            return index+1;
        }
    }
}