using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ArraysAndStrings
{
    /*
     * 1.4 Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
       A palindrome is a word or phrase that is the same forwards and backwards. A permutation
       is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
       EXAMPLE
       Input: TactCoa
       Output: True (permutations: "tacocat". "atcocta". etc.)
     */
    public class PalindromePermutation
    {
        // Assumption: char set is from a-Z and it is case insensitive
        public static bool PalindromePermutationAlgo(string input)
        {
            var bitVector = 0;
            var mask = 0;
            foreach (char c in input) 
            {
                mask = c > 'z' ? 1 << (c - 'A') : 1 << (c - 'a');
                bitVector ^= mask;
            }

            //if (bitVector == 0)
            //    return true;
            //else if ((bitVector - 1 & bitVector) == 0)
            //    return true;
            //else
            //    return false;
            return (bitVector == 0) || ((bitVector - 1 & bitVector) == 0);
        }
    }
}
