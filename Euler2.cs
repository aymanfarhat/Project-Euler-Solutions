using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 4000000;
            int last = 1;
            int next = 1;
            int temp = 0;
            int evenSum = 0;

            while (next < max)
            {
                temp = next;
                next += last;
                last = temp;

                if (next % 2 == 0)
                    evenSum += next;
            }

            Console.WriteLine(evenSum);
        }

        
    }
}
