using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    /* 1.3
     * URLify: Write a method to replace all spaces in a string with '%20: You may assume that the string
       has sufficient space at the end to hold the additional characters, and that you are given the "true"
       length of the string. (Note: If implementing in Java, please use a character array so that you can
       perform this operation in place.)
       EXAMPLE
       Input: "Mr John Smith "J 13
       Output: "Mr%20J ohn%20Smith"
     */
    public class URLify
    {
        public static char[] URLifyAlgo(char[] input, int length) {
            var numOfSpace = 0;
            for(int i = 0; i < length; i++)
            {
                if (input[i] == ' ')
                    numOfSpace++;
            }
            if (numOfSpace == 0)
                return input;
            var lengthAfterReplacement = length + 2 * numOfSpace;
            var index = lengthAfterReplacement - 1;
            for(int i = length - 1; i >= 0; i--)
            {
                if (input[i] != ' ')
                    input[index--] = input[i];
                else
                {
                    input[index--] = '0';
                    input[index--] = '2';
                    input[index--] = '%';
                }
            }
            return input;
        }
    }
}
