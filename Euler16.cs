using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Pow(2, 1000);
            BigInteger sum = 0;
            BigInteger curr = 0;

            string numStr = num.ToString();

            for (int i = 0; i < numStr.Length; i++)
            {
                BigInteger.TryParse(numStr[i].ToString(), out curr);
                sum += curr;

                Console.Write(numStr[i]+",");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
