using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.Common
{
    public class StringToASCIIConverter
    {
        public static int ASCIICharSum(string inputStr)
        {
            int asciiSum = 0;
            foreach (byte asciiByte in ConvertStringToASCII(inputStr))
            {
                var asciiInt = Convert.ToInt32(asciiByte);
                if (asciiInt <= 127 && asciiInt > 0) {
                    asciiSum += asciiInt;
                }
            }
            return asciiSum;
        }
        public static byte[] ConvertStringToASCII(string inputStr)
        {

            return Encoding.ASCII.GetBytes(inputStr);
            
        }
    }
}
