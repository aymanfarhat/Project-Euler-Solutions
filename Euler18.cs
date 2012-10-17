using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Euler18
{
    class Program
    {
        /* The triangle */
        static int[][] triangle = null;

        /* Saves respective optimal sums of nodes in the triangle */
        static int[][] optimalSums = null;

        static void Main(string[] args)
        {
            triangle = File.ReadLines("triangle.txt")
                        .Select(l => l.Split(' ').Select(n => int.Parse(n)).ToArray())
                        .ToArray();

            optimalSums = new int[triangle.Length][];

            for (int i = triangle.Length - 1; i >= 0; i--)
            {
                optimalSums[i] = new int[i + 1];

                for (int j = 0; j < triangle[i].Length; j++)
                {
                    optimalSums[i][j] = getOptimalSum(i, j);
                }
            }
            Console.WriteLine(optimalSums[0][0]);
        }

        /* Gets optimal sum of a node from its position downward */
        static int getOptimalSum(int i, int j)
        {
            if (i == (triangle.Length-1))
                return triangle[i][j];
            else
            {
                int sum1 = triangle[i][j] + optimalSums[i + 1][j];
                int sum2 = triangle[i][j] + optimalSums[i + 1][j + 1];

                return ( sum1 > sum2 )? sum1 : sum2;
            }
        }
    }
}
