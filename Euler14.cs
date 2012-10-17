using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler14
{
    class Program
    {
        static void Main(string[] args)
        {
            long target = 1000000;
            long count = 1;
            long n = 0;
            long temp = n;
            Dictionary<long, long> values = new Dictionary<long, long>();

            for (n = 1; n < target; n++)
            {
                temp = n;
                count = 1;
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n = n / 2;
                    else
                        n = 3 * n + 1;

                    count++;
                }
                
                n = temp;
                values.Add(n, count);

                Console.WriteLine("{0} : {1} elements",n,count);
            }
            KeyValuePair<long, long> max = new KeyValuePair<long, long>();

            foreach (var pair in values)
            {
                if (pair.Value > max.Value)
                    max = pair;
            }

            Console.WriteLine("{0} with {1} elements", max.Key, max.Value);

        }
    }
}