using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 10, 11, 13 };
            int min= arr[0];
            int max= arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                max = arr[i];
                else if(arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"min element is {min} and max element is {max}");
        }
    }
}
