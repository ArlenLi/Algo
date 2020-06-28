using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    // 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
    // cannot use additional data structures?
    public class IsUnique
    {
        // Assumption: Character set is 128 ASCII
        public static bool IsUniqueUsingArray(string input)
        {
            if (input.Length > 128)
                return false;

            var IsCharacterUniqueFlags = new bool[128];
            foreach (char c in input) 
            {
                if (IsCharacterUniqueFlags[(int)c] == true)
                    return false;
                else
                    IsCharacterUniqueFlags[(int)c] = true;
            }
            return true;
        }

        // Assumption: Character set is from a to Z
        public static bool IsUniqueUsingBitVector(string input)
        {
            if (input.Length > 56)
                return false;

            ulong vector = 0b_0;
            foreach (char c in input)
            {
                var index = c - 'a';
                var mask = (ulong)1 << index;
                if ((vector & mask) != 0)
                    return false;
                else
                    vector |= mask;
            }
            return true;
        }
    }
}
