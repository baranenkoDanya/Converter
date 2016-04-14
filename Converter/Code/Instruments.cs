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

        public static string IntChoice(int from, int to, string input)
        {
            string output = "";
            if (from == to) return input;
            switch (from)
            {
                case 2:
                {
                    if (to == 8)
                    {
                        output = IntegerSolution.DecimalToOctal(IntegerSolution.BinaryToDecimal(input));
                    }
                    else if (to == 10)
                    {
                        output = IntegerSolution.BinaryToDecimal(input);
                    }
                    else if (to == 16)
                    {
                        output = IntegerSolution.DecimalToHexa(IntegerSolution.BinaryToDecimal(input));
                    }
                    break;
                }
                case 8:
                {
                    if (to == 2)
                    {
                        output = IntegerSolution.DecimalToBinary(IntegerSolution.OctalToDecimal(input));
                    }
                    else if (to == 10)
                    {
                        output = IntegerSolution.OctalToDecimal(input);
                    }
                    else if (to == 16)
                    {
                        output = IntegerSolution.DecimalToHexa(IntegerSolution.OctalToDecimal(input));
                    }
                    break;
                }
                case 10:
                {
                    if (to == 2)
                    {
                        output = IntegerSolution.DecimalToBinary(input);
                    }
                    else if (to == 8)
                    {
                        output = IntegerSolution.DecimalToOctal(input);
                    }
                    else if (to == 16)
                    {
                        output = IntegerSolution.DecimalToHexa(input);
                    }
                    break;
                }
                case 16:
                {
                    if (to == 2)
                    {
                        output = IntegerSolution.DecimalToBinary(IntegerSolution.HexaToDecimal(input));
                    }
                    else if (to == 8)
                    {
                        output = IntegerSolution.DecimalToOctal(IntegerSolution.HexaToDecimal(input));
                    }
                    else if (to == 10)
                    {
                        output = IntegerSolution.HexaToDecimal(input);
                    }
                    break;
                }
            }
            return output;
        }

        public static string FractChoice(int from, int to, string input)
        {
            string output = "";
            if (from == to) return input;
            switch (from)
            {
                case 2:
                    {
                        if (to == 8)
                        {
                            output = FractionalSolution.DecimalToOctal(FractionalSolution.BinaryToDecimal(input));
                            FractionalSolution.MakeDigitZero();
                        }
                        else if (to == 10)
                        {
                            output = FractionalSolution.BinaryToDecimal(input);
                            FractionalSolution.MakeDigitZero();
                        }
                        else if (to == 16)
                        {
                            output = FractionalSolution.DecimalToHexa(FractionalSolution.BinaryToDecimal(input));
                            FractionalSolution.MakeDigitZero();
                        }
                        break;
                    }
                case 8:
                    {
                        if (to == 2)
                        {
                            output = FractionalSolution.DecimalToBinary(FractionalSolution.OctalToDecimal(input));
                            FractionalSolution.MakeDigitZero();
                        }
                        else if (to == 10)
                        {
                            output = FractionalSolution.OctalToDecimal(input);
                            FractionalSolution.MakeDigitZero();
                        }
                        else if (to == 16)
                        {
                            output = FractionalSolution.DecimalToHexa(FractionalSolution.OctalToDecimal(input));
                            FractionalSolution.MakeDigitZero();
                        }
                        break;
                    }
                case 10:
                    {
                        if (to == 2)
                        {
                            output = FractionalSolution.DecimalToBinary(input);
                        }
                        else if (to == 8)
                        {
                            output = FractionalSolution.DecimalToOctal(input);
                        }
                        else if (to == 16)
                        {
                            output = FractionalSolution.DecimalToHexa(input);
                        }
                        break;
                    }
                case 16:
                    {
                        if (to == 2)
                        {
                            output = FractionalSolution.DecimalToBinary(FractionalSolution.HexaToDecimal(input));
                            FractionalSolution.MakeDigitZero();
                        }
                        else if (to == 8)
                        {
                            output = FractionalSolution.DecimalToOctal(FractionalSolution.HexaToDecimal(input));
                            FractionalSolution.MakeDigitZero();
                        }
                        else if (to == 10)
                        {
                            output = FractionalSolution.HexaToDecimal(input);
                            FractionalSolution.MakeDigitZero();
                        }
                        break;
                    }
            }
            return output;
        }

    }
}
