using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.Common.Extensions
{
    public static class StringExtensions
    {
        public static int CountConsecutiveCharacters(this String inputStr, char searchChar)
        {
            int strLen = inputStr.Length;
            int finalZeroCount = 0;
            int currCount = 1;

            for (int i = 0; i < strLen; i++)
            {
                if (i < strLen - 1 &&
                    inputStr[i] == inputStr[i + 1] && inputStr[i] == searchChar)
                {
                    currCount++;
                }
                else
                {
                    if (currCount > finalZeroCount)
                    {
                        finalZeroCount = currCount;
                    }
                    currCount = 1;
                }
            }
            return finalZeroCount;
        }
    }
}
