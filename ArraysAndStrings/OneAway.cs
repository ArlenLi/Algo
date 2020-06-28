using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    public class OneAway
    {
        public static bool OneAwayAlgo(string input1, string input2)
        {
            if (Math.Abs(input1.Length - input2.Length) > 1) {
                return false;
            }
            var longerString = input1.Length >= input2.Length ? input1 : input2;
            var shorterString = input1.Length < input2.Length ? input1 : input2;

            var diffCount = 0;
            var longerStringIndex = 0;
            var shorterStringIndex = 0;
            while (longerStringIndex < longerString.Length && shorterStringIndex < shorterString.Length) {
                if (longerString[longerStringIndex] != shorterString[shorterStringIndex]) {
                    if (diffCount != 0)
                    {
                        return false;
                    }
                    else
                    {
                        diffCount++;
                        if (longerString.Length != shorterString.Length) {
                            longerStringIndex++;
                            continue;
                        }
                    }
                }
                longerStringIndex++;
                shorterStringIndex++;
            }
            return true;
        }
    }
}
