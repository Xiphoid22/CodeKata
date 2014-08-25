using System;
using System.Linq;

namespace CodeKata
{
    class StringCalculatorKata
    {
        public int Add(string numbers)
        {
            var splitNumbers = numbers.Split(',');

            try
            {
                return splitNumbers.Sum(number => Convert.ToInt32(number));
            }
            catch (FormatException)
            {
                return 0;
            }
            
        }
    }
}
