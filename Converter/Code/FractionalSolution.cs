using System;
using System.Collections.Generic;

namespace Converter
{
    class FractionalSolution
    {
        // fractional values - multiplication method

        // DOCIMAL TO HEXA + HEXA TO DECIMAL

        private static int digit; // I use this variable to output the right number of digits in remainder

        // method for counting the reminder size
        private static void DigitRemainderCount(string input)
        {
            string[] temp = input.Split(new char[] {',', '.'});
            digit = temp[1].Length;
        }
        public static void MakeDigitZero()
        {
            digit = 0;
        }

        public static string DecimalToBinary(string input)
        {
            DigitRemainderCount(input);
            List<int> repository = new List<int>();
            double temp = Convert.ToDouble(input);
            while (repository.Count < 56)
            {
                var check = temp * 2;
                repository.Add((int)check);
                if (check > 1)
                {
                    temp = check - 1;
                }
                else
                {
                    temp = check;
                }
            }
            return ("0." + Instruments.ListToString(repository));
        }
        public static string BinaryToDecimal(string input)
        {
            string given = input;
            int power = -1;
            double result = 0;
            for (int i = 2; i < input.Length; i++)
            {
                result += Math.Pow(2, power) * Convert.ToInt32(given[i].ToString());
                power--;
            }
            if (digit == 0)
            {
                digit = 5;
            }
            return Math.Round(result, digit).ToString();
        }
        public static string DecimalToOctal(string input)
        {
            DigitRemainderCount(input);
            List<int> repository = new List<int>();
            double temp = Convert.ToDouble(input);
            while (repository.Count <= digit)
            {
                var check = temp * 8;
                repository.Add((int)check);
                if (check > 1)
                {
                    while (check > 1)
                    {
                        check--;
                    }
                    temp = check;
                }
                else
                {
                    temp = check;
                }
            }
            return ("0." + Instruments.ListToString(repository));
        }
        public static string OctalToDecimal(string input)
        {
            string given = input;
            int power = -1;
            double result = 0;
            for (int i = 2; i < input.Length; i++)
            {
                result += Math.Pow(8, power) * Convert.ToInt32(given[i].ToString());
                power--;
            }
            if (digit == 0)
            {
                DigitRemainderCount(input);
            }
            return Math.Round(result, digit).ToString();
        }
        public static string DecimalToHexa(string input)
        {
            DigitRemainderCount(input);
            string repository = "";
            double temp = Convert.ToDouble(input);
            while (repository.Length <= digit)
            {
                var check = temp * 16;
                switch ((int)check)
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
                        repository += ((int)check).ToString();
                        break;
                }
                if (check > 1)
                {
                    while (check > 1)
                    {
                        check--;
                    }
                    temp = check;
                }
                else
                {
                    temp = check;
                }
            }
            return ("0." + repository);
        }
        public static string HexaToDecimal(string input)
        {
            string given = input;
            int power = -1;
            double result = 0;
            for (int i = 2; i < given.Length; i++)
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
                        result += Math.Pow(16, power) * Convert.ToInt32(given[i].ToString().ToUpper());
                        break;
                }
                power--;
            }
            if (digit == 0)
            {
                DigitRemainderCount(input);
            }
            return Math.Round(result, digit).ToString();
        }

    }
}
