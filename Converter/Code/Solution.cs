using System;
using System.Collections.Generic;

namespace Converter
{
    public class Solution
    {
        // int values
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
        public static string BinaryToDecimal(string input)
        {
            int power = input.Length - 1;
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += Math.Pow(2, power) * Convert.ToInt32(input[i].ToString());
                power--;
            }
            return result.ToString();
        }
        public static string DecimalToOctal(string input)
        {
            int intInput;
            List<int> repository = new List<int>();
            bool check = Int32.TryParse(input, out intInput);
            while (intInput > 8 & check)
            {
                var a = intInput % 8;
                repository.Add(a);
                if (a == 0)
                {
                    intInput /= 8;
                }
                else
                {
                    while (intInput % 8 != 0)
                    {
                        intInput--;
                    }
                    intInput /= 8;
                }
            }
            repository.Add(intInput % 8);
            repository.Reverse();
            return Instruments.ListToString(repository);
        }
        public static string OctalToDecimal(string input)
        {
            int power = input.Length - 1;
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += Math.Pow(8, power) * Convert.ToInt32(input[i].ToString());
                power--;
            }
            return result.ToString();
        }
        public static string DecimalToHexa(string input)
        {
            int intInput;
            string repository = "";
            bool check = Int32.TryParse(input, out intInput);
            while (intInput > 16 & check)
            {
                var a = intInput % 16;
                switch (a)
                {
                    case 10:
                        repository += "A";
                        break;
                    case 11:
                        repository += "B";
                        break;
                    case 12:
                        repository += "C";
                        break;
                    case 13:
                        repository += "D";
                        break;
                    case 14:
                        repository += "E";
                        break;
                    case 15:
                        repository += "F";
                        break;
                    default:
                        repository += a.ToString();
                        break;
                }
                if (a == 0)
                {
                    intInput /= 16;
                }
                else
                {
                    while (intInput % 16 != 0)
                    {
                        intInput--;
                    }
                    intInput /= 16;
                }
            }
            switch (intInput % 16)
            {
                case 10:
                    repository += "A";
                    break;
                case 11:
                    repository += "B";
                    break;
                case 12:
                    repository += "C";
                    break;
                case 13:
                    repository += "D";
                    break;
                case 14:
                    repository += "E";
                    break;
                case 15:
                    repository += "F";
                    break;
                default:
                    repository += (intInput % 16).ToString();
                    break;
            }
            return Instruments.StringReverce(repository);
        }
        public static string HexaToDecimal(string input)
        {
            int power = input.Length - 1;
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString().ToUpper())
                {
                    case "A":
                        result += Math.Pow(16, power) * 10;
                        break;
                    case "B":
                        result += Math.Pow(16, power) * 11;
                        break;
                    case "C":
                        result += Math.Pow(16, power) * 12;
                        break;
                    case "D":
                        result += Math.Pow(16, power) * 13;
                        break;
                    case "E":
                        result += Math.Pow(16, power) * 14;
                        break;
                    case "F":
                        result += Math.Pow(16, power) * 15;
                        break;
                    default:
                        result += Math.Pow(16, power) * Convert.ToInt32(input[i].ToString().ToUpper());
                        break;
                }
                power--;
            }
            return result.ToString();
        }

        // fractional values
    }
}
