using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app9
    {
        static void Main(string[] args)
        {
            int n;
            int count = 1;

            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());



        start:
            if (count <= n)
            {
                int cube = count * count * count;
                Console.WriteLine("cube of " + count + " is " + cube );
                count++;
                goto start;
            }


        }
    }
}
