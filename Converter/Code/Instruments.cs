using System.Collections.Generic;
using System.Linq;

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
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i].ToString();
            }
            return output;
        }

        public static bool IsInt(string input)
        {
            if (!input.Contains(',') || !input.Contains('.'))
            {
                return true;
            }
            return false;
        }

        public static string Choice(int from, int to, string input)
        {
            string output = "";
            if (from == to) return input;
            switch (from)
            {
                case 2:
                {
                    if (to == 8)
                    {
                        output = Solution.DecimalToOctal(Solution.BinaryToDecimal(input));
                    }
                    else if (to == 10)
                    {
                        output = Solution.BinaryToDecimal(input);
                    }
                    else if (to == 16)
                    {
                        output = Solution.DecimalToHexa(Solution.BinaryToDecimal(input));
                    }
                    break;
                }
                case 8:
                {
                    if (to == 2)
                    {
                        output = Solution.DecimalToBinary(Solution.OctalToDecimal(input));
                    }
                    else if (to == 10)
                    {
                        output = Solution.OctalToDecimal(input);
                    }
                    else if (to == 16)
                    {
                        output = Solution.DecimalToHexa(Solution.OctalToDecimal(input));
                    }
                    break;
                }
                case 10:
                {
                    if (to == 2)
                    {
                        output = Solution.DecimalToBinary(input);
                    }
                    else if (to == 8)
                    {
                        output = Solution.DecimalToOctal(input);
                    }
                    else if (to == 16)
                    {
                        output = Solution.DecimalToHexa(input);
                    }
                    break;
                }
                case 16:
                {
                    if (to == 2)
                    {
                        output = Solution.DecimalToBinary(Solution.HexaToDecimal(input));
                    }
                    else if (to == 8)
                    {
                        output = Solution.DecimalToOctal(Solution.HexaToDecimal(input));
                    }
                    else if (to == 10)
                    {
                        output = Solution.HexaToDecimal(input);
                    }
                    break;
                }
            }
            return output;
        }
    }
}
