using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app6
    {
        static void Main(string[] args)
        {
            int n, a, r = 0;

            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            a = n;

            while (n != 0)
            {
                int temp = n;
                temp %= 10;
                r += (temp * temp * temp);
                n /= 10;

            }

            if (r == a)
            {
                Console.WriteLine("it is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("it is not an Armstrong number.");
            }
        }
    }
}
