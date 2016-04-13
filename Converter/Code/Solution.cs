using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    public class Solution
    {

        public static string DecimalToBinary(string input)
        {
            int intInput;
            List<int> binaryRepository = new List<int>();
            bool check = Int32.TryParse(input, out intInput);
            // if temp = 1 then it is the end of dividing
            while (intInput != 1 & check)
            {
                var a = intInput % 2;
                binaryRepository.Add(a);
                if (a == 1)
                {
                    intInput--;
                    intInput /= 2;
                }
                else
                {
                    intInput /= 2;
                }
            }
            binaryRepository.Add(1);
            binaryRepository.Reverse();
            return Instruments.ListToString(binaryRepository);
        }

    }
}
