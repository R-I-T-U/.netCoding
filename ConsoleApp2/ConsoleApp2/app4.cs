using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app4
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = { { 3, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int [,] mul = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        mul[i, j] += arr1[i, k] * arr2[k, j];

                }
            }
            Console.WriteLine(" Multiple of 2 matrix : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mul[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
