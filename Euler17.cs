using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler17
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> data = new Dictionary<int, string> 
            { 
                {1, "one"},{2, "two"},{3, "three"},{4, "four"},{5, "five"},{6, "six"},
                {7, "seven"},{8, "eight"},{9, "nine"},{10, "ten"},{11, "eleven"},
                {12, "twelve"},{13, "thirteen"},{14, "fourteen"},{15, "fifteen"},
                {16, "sixteen"},{17, "seventeen"},{18, "eighteen"},{19, "nineteen"},
                {20, "twenty"},{30, "thirty"},{40, "forty"},{50, "fifty"},{60, "sixty"},
                {70, "seventy"},{80, "eighty"},{90, "ninety"},{100, "hundred"},{1000, "thousand"}
            };

            string chars = "";

            for (int i = 1; i < 1000; i++)
            {
                if (data.ContainsKey(i) && i < 100)
                    chars += data[i];
                
                else if (i > 20 && i <= 99)
                {
                    double num = ((double)i / 10);
                    int n = (int)Math.Truncate(num);
                    int x = (int)Math.Round((num - n) * 10);
                    data.Add(i, data[n * 10] + "" + data[x]);
                    chars += data[n * 10] + "" + data[x];
                }
                else
                {
                    double num = ((double)i / 100);
                    int n = (int)Math.Truncate(num);
                    double x = ((num - n) * 10);

                    x = Math.Round(x, 2);

                    if (x == 0)
                        chars += data[n]+data[100];
                    else
                        chars += data[n] + data[100] + "and" + data[(int)(x * 10)]; 
                }
            }
            chars += data[1]+data[1000];

            Console.WriteLine(chars.Length);
        }
    }
}