using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ArraysAndStrings
{
    public class Compression
    {
        public static string CompressionAlgo(string input) {
            if(String.IsNullOrEmpty(input))
            {
                return input;
            }
            var stringBuilder = new StringBuilder();            
            var repeatedChar = input[0];
            var repeatedCharCount = 0;

            foreach(var character in input){
                if (character != repeatedChar)
                {
                    if (stringBuilder.Length + 1 < input.Length)
                    {
                        stringBuilder.Append(repeatedChar);
                        stringBuilder.Append(repeatedCharCount);
                        repeatedChar = character;
                        repeatedCharCount = 1;
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    repeatedCharCount++;
                }
            }
            stringBuilder.Append(repeatedChar);
            stringBuilder.Append(repeatedCharCount);

            return stringBuilder.ToString();
        }
    }
}
