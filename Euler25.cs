using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler25
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> fibonacci = Fibonacci;
            var fibonacciMemoized = fibonacci.Memoize();
            var fibFast1 = fibonacciMemoized(30);
        }

        static int Fibonacci(int n)
        {
            return n <= 2 ? 1 : Fibonacci(n - 2) + Fibonacci(n - 1);
        } 

        public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
        {
            var t = new Dictionary<T, TResult>();
            return n =>
            {
                if (t.ContainsKey(n)) return t[n];

                var result = func(n);
                t.Add(n, result);
                return result;
            };
        }
    }
}
