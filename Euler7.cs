using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler7
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10001;
            int countPrime = 0;
            int primeNum = 2;

            do
            {
                if (isPrime(primeNum))
                { Console.WriteLine(primeNum + " is the " + ++countPrime);}

                primeNum++;

            } while (countPrime < target);
        }

        public static bool isPrime(int x)
        {
            if (x == 2) return true;

            for (int i = 2; i <= ((int)Math.Sqrt(x) + 1); i++)
                if (x % i == 0) return false;
            
            return true;
        }
    }
}
