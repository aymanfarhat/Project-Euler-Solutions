using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler11
{
    class Program
    {
        static int[,] grid = new int[20, 20];

        static void Main(string[] args)
        {
            List<int> maxSeqProducts = new List<int>();

            getGrid();

            /* Get horizontal sequence maxes */
            for (int i = 0; i < 20; i++)
                maxSeqProducts.Add(getLargestConsProduct(getLinearSeq(grid, i,'h')));

            /* Get vertcal sequence maxes */
            for (int i = 0; i < 20; i++)
            {
                maxSeqProducts.Add(getLargestConsProduct(getLinearSeq(grid, i,'v')));
            }

            /* First Diagonal Check */
            int[] startPos1 = { 0, 16 };
            int[] startPos2 = {3, 19 };
            
            // Initial coordinate call here
            maxSeqProducts.Add(getLargestConsProduct(getDiagonalSeq(grid, startPos1.ToArray(), startPos2.ToArray(),'r')));
            
            do
            {
                if ((startPos1[1] != 0) && (startPos2[0] != 19))
                {
                    startPos1[1]--;
                    startPos2[0]++;
                }
                else
                {
                    startPos1[0]++;
                    startPos2[1]--;
                }

                maxSeqProducts.Add(getLargestConsProduct(getDiagonalSeq(grid, startPos1.ToArray(), startPos2.ToArray(), 'r'))); 
            } while (startPos1[0] != 16 && startPos2[1] != 3);

            /* Second Diagonal Check */
            startPos1 = new int[]{0 , 3};
            startPos2 = new int[] { 3, 0};

            // Initial coordinate call her
            maxSeqProducts.Add(getLargestConsProduct(getDiagonalSeq(grid, startPos1.ToArray(), startPos2.ToArray(), 'l')));
            do
            {
                if (startPos1[1] != 19 && startPos2[0] != 19)
                {
                    startPos1[1]++;
                    startPos2[0]++;
                }
                else
                {
                    startPos1[0]++;
                    startPos2[1]++;
                }

                maxSeqProducts.Add(getLargestConsProduct(getDiagonalSeq(grid, startPos1.ToArray(), startPos2.ToArray(), 'l')));
            } while (startPos1[0] != 16 && startPos2[1] != 16);

            int max = 0;

            foreach (int product in maxSeqProducts)
            {
                if (product > max)
                    max = product;
            }

            Console.WriteLine("Max product = " + max);
        }

        public static void getGrid()
        {
            int counter = 0;
            string line;
            
            System.IO.StreamReader file = new System.IO.StreamReader("grid.txt");

            while ((line = file.ReadLine()) != null)
            {
                addToArr(line.ToString().Split(),counter);
                counter++;
            }
            file.Close();
        }

        public static void addToArr(string[] arr,int row)
        {
            for (int i = 0; i < arr.Length; i++)
                grid[row,i] = Convert.ToInt32(arr[i]);
        }

        /* Gets the largest product of 4 adjacent numbers in a sequence array */
        public static int getLargestConsProduct(int[] sequence)
        {
            int max = 0;
            int product = 1;

            for (int i = 0; i <= (sequence.Length - 4); i++)
            {
                product = sequence[0 + i] * sequence[1 + i] * sequence[2 + i] * sequence[3 + i];
                
                if (product > max)
                    max = product;
            }
            return max;
        }

        /* Finds full linear sequences vertical or horizontal */
        public static int[] getLinearSeq(int[,] arr, int rowCol, char type)
        {
            int[] newArr = new int[arr.GetLength(0)];

            for (int i = 0; i < newArr.Length; i++)
                newArr[i] = (type == 'h')? arr[rowCol, i] : arr[i,rowCol];
            
            return newArr;
        }

        /* Finds full diagonal sequences right ot left starting at point and ending at another */
        public static int[] getDiagonalSeq(int[,] arr, int[] startPos1, int[] startPos2, char type)
        {
            int[] newArr = new int[(startPos2[0]) - (startPos1[0]) + 1];

            int count = 0;
            while (count < newArr.Length)
            {
                newArr[count] = arr[startPos2[0], startPos2[1]];
                startPos2[0]--;

                if (type == 'r') 
                    startPos2[1]--; 
                
                else 
                    startPos2[1]++;
                
                count++;
            }
            return newArr;
        }
    }
}