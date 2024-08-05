using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app10
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                {2,3,4},
                {8,7,6 },
                {5,7,8 }
            };

            int exp = 0;

            int i = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                exp = exp + matrix[i, j] * (matrix[i + 1, (j + 1) % 3] * matrix[i + 2, (j + 2) % 3] - matrix[i + 1, (j + 2) % 3] * matrix[i + 2, (j + 1) % 3]);
            }

            Console.WriteLine("Determinant is: " + exp);
        }
    }
}
