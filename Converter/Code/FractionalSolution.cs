using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Converter
{
    class FractionalSolution
    {
        // fractional values - multiplication method

        private static int digit; // I use this variable to output the right number of digits in remainder

        // method for counting the reminder size
        private static void DigitRemainderCount(string input)
        {
            string[] temp = input.Split(new char[] {',', '.'});
            digit = temp[1].Length;
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
            return ("0," + Instruments.ListToString(repository));
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
            return ("0," + Instruments.ListToString(repository));
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
            return Math.Round(result, digit).ToString();
        }
    }
}
