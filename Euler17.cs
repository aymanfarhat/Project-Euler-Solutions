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
            Dictionary<int,string> data = new Dictionary<int,string>();
            data.Add(1, "one");
            data.Add(2, "two");
            data.Add(3, "three");
            data.Add(4, "four");
            data.Add(5, "five");
            data.Add(6, "six");
            data.Add(7, "seven");
            data.Add(8, "eight");
            data.Add(9, "nine");
            data.Add(10, "ten");
            data.Add(11, "eleven");
            data.Add(12, "twelve");
            data.Add(13, "thirteen");
            data.Add(14, "fourteen");
            data.Add(15, "fifteen");
            data.Add(16, "sixteen");
            data.Add(17, "seventeen");
            data.Add(18, "eighteen");
            data.Add(19, "nineteen");
            data.Add(20, "twenty");
            data.Add(30, "thirty");
            data.Add(40, "forty");
            data.Add(50, "fifty");
            data.Add(60, "sixty");
            data.Add(70, "seventy");
            data.Add(80, "eighty");
            data.Add(90, "ninety");
            data.Add(100, "hundred");
            data.Add(1000, "thousand");

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