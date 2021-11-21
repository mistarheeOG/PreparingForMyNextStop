using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class StringRotation
    {
        public bool Check(string first, string second)
        {
            // check the length to make sure they match, if not then it can't be a rotation
            if(first.Length != second.Length)
            {
                return false;
            }

            var universe = first + first;
            return universe.Contains(second);
        }
    }
}