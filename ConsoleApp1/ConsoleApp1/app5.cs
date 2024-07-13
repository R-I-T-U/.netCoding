using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a number: ");
            float a = float.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < a / 2; i++)
            {

                if (a % i == 0)
                {
                    count++;
                }





            }
            if (count == 0)
            {
                Console.WriteLine("is  prime!!");
            }
            else
            {
                Console.WriteLine("is not prime!!");
            }
        }
    }
}
