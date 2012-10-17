using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangle = 1;
            int triangleValue = 1;
            int divisors = 0;
       
            while (divisors < 500)
            {
                Console.WriteLine("Triangle: {0} , Value: {1}, Divisors: {2}", triangle, triangleValue,divisors);

                divisors = 0; 

                triangleValue = getTriangleVal(triangle);

                divisors = getNumDivisors(triangleValue);
                triangle++;
            }
            
            Console.WriteLine("{0} divisors for {1}",divisors,triangleValue);
        }

        public static int getTriangleVal(int triangle)
        {
            int sum = 0;
            for (int i = 1; i <= triangle; i++)
                sum += i;
            return sum;
        }

        public static int getNumDivisors(int n)
        {
            List<int> rawPrime = getPrimeFactors(n);
            Dictionary<int, int> factorCount = new Dictionary<int, int>();
            int product = 1;

            foreach(var factor in rawPrime)
            {
                int count = rawPrime.Where(temp => temp.Equals(factor))
                    .Select(temp => temp)
                    .Count();

                if (!factorCount.ContainsKey(factor))
                    factorCount.Add(factor,count);
            }

            foreach (var factor in factorCount)
                product = product * (factor.Value + 1);

            return product;
        }

        public static List<int> getPrimeFactors(int n)
        {
            List<int> rawFactors = new List<int>();

            int prime = 2;

            while (prime <= n)
            {
                if (n % prime == 0)
                {
                    n = n / prime;
                    rawFactors.Add(prime);
                }
                else prime++;
            }
            return rawFactors;
        }
    }
}