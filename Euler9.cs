using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler9
{
    class Euler9
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a*a + b*b == c*c)
                        {
                            if (a + b + c == 1000)
                            {
                                Console.WriteLine("{0} * {1} * {2} = {3}",a,b,c,(a*b*c));
                            }
                        }
                    }
                }
            }
        }
    }
}