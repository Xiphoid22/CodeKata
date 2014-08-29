using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata
{
    class StringCalculatorKata
    {
        private string _numbers;

        public StringCalculatorKata(string numbers)
        {
            _numbers = numbers;
        }

        public int Add()
        {
            var delimiters = SetDelimiters();
            var splitNumbers = _numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            CheckForNegativeNumbers(splitNumbers);

            try
            {
                return splitNumbers.Sum(number => Convert.ToInt32(number));
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        internal string[] SetDelimiters()
        {
            const string pattern = @"(?<=//).";
            var regex = new Regex(pattern);

            if (regex.Matches(_numbers).Count > 0)
            {
                var customDelimiter = regex.Match(_numbers).ToString();
                RemoveDelimiterSection();
                return new[] { ",", "\n", customDelimiter };
            }

            return new[] { ",", "\n" };
        }

        internal void RemoveDelimiterSection()
        {
            var positionOfFirstLineBreak = _numbers.IndexOf("\n", StringComparison.Ordinal);
            if (positionOfFirstLineBreak > 0)
            {
                _numbers = _numbers.Remove(0, positionOfFirstLineBreak + 1);
            }
        }

        internal void CheckForNegativeNumbers(string[] splitNumbers)
        {
            var negativeNumbers = "";
            foreach (var number in splitNumbers.Where(x => Convert.ToInt32(x) < 0))
            {
                negativeNumbers = negativeNumbers + number + " ";

            }
            if (negativeNumbers != "")
            {
                throw new NegativeNumbersException("Negatives not allowed. " + negativeNumbers.Trim());
            }
        }
    }

    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException(string message) : base(message)
        {
        }
    }
}
