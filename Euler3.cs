using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 2;
            long n = 600851475143;

            while (prime <= n)
            {
                if (n % prime == 0)
                { 
                    n = n / prime;
                    Console.WriteLine(prime);
                }

                else prime++;
            }

            Console.WriteLine(n);
        }
    }
}
