using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class GreatestCommonDivisorKata : IGreatestCommonDivisorKata
    {
        public int d = 1;

        public int CalcGcd(int number1, int number2)
        {
            return number2 == 0 ? number1 : CalcGcd(number2, number1 % number2);
        }
    }

    public interface IGreatestCommonDivisorKata
    {
        int CalcGcd(int number1, int number2);
    }
}
