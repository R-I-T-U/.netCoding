using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("input no. is even ");
            }
            else
            {
                Console.WriteLine("input no. is odd ");
            }

        }
    }
}
