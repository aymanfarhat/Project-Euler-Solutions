using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler20
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetFact = 100;
            int sum = 0;

            BigInteger result = 1;

            for (int i = targetFact; i >= 1; i--)
                result = result * i;

            string numStr = result.ToString();

            for (int i = 0; i < numStr.Length; i++)
            {
                sum += Convert.ToInt32(numStr[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
