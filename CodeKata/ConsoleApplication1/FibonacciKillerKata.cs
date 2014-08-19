using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class FibonacciKillerKata : IFibonacciKillerKata
    {
        public int Fibonacci(int n)
        {
            if (n > 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);           
            }
            else
            {
                return n;
            }
        }
    }

    public interface IFibonacciKillerKata
    {
        int Fibonacci(int n);
    }
}
