using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.Common
{
    public class BinaryConverter
    {
        public static string ConvertToBinary(int inputVal)
        {
            string binaryStr = Convert.ToString(inputVal, 2);
            return binaryStr;
        }
    }
}
