using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 500;
            int n2 = 500;
            int maxPal = 0;

            for (n1 = 500; n1 < 999; n1++)
            {
                for (n2 = 500; n2 < 999; n2++)
                {
                    int mult = n1*n2;
                    if (checkPalindrome(mult))
                    {
                        if (mult > maxPal)
                            maxPal = mult;
                    }
                }
            }
            Console.WriteLine("Maximum palindrome of the fucker: " + maxPal);
        }

        public static bool checkPalindrome(int n)
        {
            int digit = 0;
            int reverse = 0;
            int num = n;

            while (n > 0)
            {
                digit = n % 10;
                reverse = (reverse * 10) + digit;
                n = n / 10;
            }
            return (num == reverse);
        }
    }
}
