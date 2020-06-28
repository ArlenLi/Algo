using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysAndStrings
{
    // 1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the
    // other.
    public class CheckPermutation
    {
        // Assumption: the character set is 128 ASCII
        public static bool CheckPermutationUsingArray(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;

            var charCounter = new int[128];

            foreach(char c in input1)
                charCounter[c]++;

            foreach(char c in input2)
            {
                if (--charCounter[c] < 0)
                    return false;
            }
            return true;
        }

        public static bool CheckPermutationUsingSorting(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;

            return new string(input1.OrderBy(c => c).ToArray()).Equals(new string(input2.OrderBy(c => c).ToArray()));
        }
    }
}
