using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    class FractionalSolution
    {
        // I HAVE TO DO ONE MORE CLASS - COMBINED THAT WILL OPERATE 123,321 NUMBERS
        // fractional values - multiplication method

        public static string DecimalToBinary(string input)
        {
            List<int> repository = new List<int>();
            double temp = Convert.ToDouble(input);
            while (repository.Count < 7)
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
    }
}
