using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            
            for (int i = 2; i < 2000000; i++)
            {
                if (checkPrime(i))
                    sum += i;
            }

            Console.WriteLine(sum);
        }

        public static bool checkPrime(int x)
        {
            if (x == 2)
                return true;

            int root = (int)Math.Sqrt(x) + 1;

            for (int i = 2; i < root; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}
