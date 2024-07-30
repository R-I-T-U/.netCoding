using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app5
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[4] { 1, 2, 3, 4 };
            arr[1] = new int[2] { 1, 2 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
