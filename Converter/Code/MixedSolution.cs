using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    class MixedSolution
    {
        public static string MixedInput(int from, int to, string input)
        {
            string[] twoPartsOfInputRepository = input.Split(new char[] {',', '.'});
            string left, right;
            left = Instruments.IntChoice(from, to, twoPartsOfInputRepository[0]) + ".";
            right = Instruments.FractChoice(from, to,("0." + twoPartsOfInputRepository[1]));
            for (int i = 2; i < right.Length; i++)
            {
                left += right[i].ToString();
            }
            return left;
        }
    }
}
