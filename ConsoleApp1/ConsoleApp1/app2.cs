using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("input no. is negative ");
            }
            else if (a > 0)
            {
                Console.WriteLine("input no. is positive ");
            }
            else
            {
                Console.WriteLine("input no. is zero ");
            }

        }
    }
}
