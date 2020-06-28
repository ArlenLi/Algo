using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    public class StringRotation
    {
        public static bool StringRotationAlgo(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            if ((s1 + s1).Contains(s2))
                return true;
            else
                return false;
        }
    }
}
