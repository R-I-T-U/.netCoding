using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app1
    {
        static void Main(string[] args)
        {
            int [] arr = { 1, 2, 3, 4, 5, 6};
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2 != 0) 
                sum += arr[i];

            }
           
            Console.WriteLine("sum is "+sum);
        }
    }
}
