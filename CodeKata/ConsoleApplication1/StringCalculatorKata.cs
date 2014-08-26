using System;
using System.Linq;

namespace CodeKata
{
    class StringCalculatorKata
    {
        public int Add(string numbers)
        {
            var delimiters = new string[] {",","\n"};
            var splitNumbers = numbers.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);

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
