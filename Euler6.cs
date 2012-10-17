using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (int)Math.Pow(i, 2);
                squareOfSum += i;
            }
            squareOfSum = (int)Math.Pow(squareOfSum, 2);

            Console.WriteLine("Square of sums = " + squareOfSum);
            Console.WriteLine("Sum of squares = " + sumOfSquares);
            int diff = squareOfSum - sumOfSquares;
            Console.WriteLine(diff);
        }
    }
}
