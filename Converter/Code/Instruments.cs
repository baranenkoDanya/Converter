using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    class Instruments
    {
        public static string ListToString<T>(List<T> input)
        {
            string res = "";
            foreach (var VARIABLE in input)
            {
                res += VARIABLE.ToString();
            }
            return res;
        }
    }
}
