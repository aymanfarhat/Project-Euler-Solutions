using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = getNumbers();
            BigInteger sum = 0;
            foreach (var num in numbers)      
                sum += num;

            Console.WriteLine(sum);
        }

        public static List<BigInteger> getNumbers()
        {
            int counter = 0;
            string line;
            List<BigInteger> numbers = new List<BigInteger>();
            BigInteger num = 0;

            System.IO.StreamReader file = new System.IO.StreamReader("data.txt");

            while ((line = file.ReadLine()) != null)
            {
                BigInteger.TryParse(line, out num);
                numbers.Add(num);
                counter++;
            }
            file.Close();

            return numbers;
        }
    }
}
