using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5040;

            while (!divByAll(num))
                num++;

            Console.WriteLine(num);
        }

        public static bool divByAll(int num)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (num % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
