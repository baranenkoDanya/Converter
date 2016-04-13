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

        public static string StringReverce(string input)
        {
            string output = "";
            for (int i = input.Length; i >= 0; i--)
            {
                output += input[i].ToString();
            }
            return output;
        }

        public static bool isInt(string input)
        {
            if (!input.Contains(',') || !input.Contains('.'))
            {
                return true;
            }
            return false;
        }
    }
}
