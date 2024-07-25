using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app9
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Prime numbers in the array are : ");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 2; j < arr[i]/2; j++)
                {
                    if (arr[i] != 1 && arr[i]%j != 0)
                    {
                        Console.WriteLine(arr[i]);
                    }

                }
            }
        }
    }
}
