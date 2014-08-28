using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata
{
    class StringCalculatorKata
    {
        public int Add(string numbers)
        {
            string[] delimiters;

            const string pattern = @"(?<=//).";
            var regex = new Regex(pattern);

            if (regex.Matches(numbers).Count > 0)
            { 
                var customDelimiter = regex.Match(numbers).ToString();
                delimiters = new string[] { ",", "\n", customDelimiter};

                //Remove the custom delimiter section from the string
                var positionOfFirstLineBreak = numbers.IndexOf("\n", StringComparison.Ordinal);
                if (positionOfFirstLineBreak > 0)
                {
                    numbers = numbers.Remove(0, positionOfFirstLineBreak + 1);
                }
            }
            else
            {
                delimiters = new string[] { ",", "\n"}; 
            }

            var splitNumbers = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

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
