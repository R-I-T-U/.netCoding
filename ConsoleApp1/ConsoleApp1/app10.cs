using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app10
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());

            int first = 0, sec = 1, next=0;
            for (int i = 0; i < n-2; i++)
            {
                next = first + sec;
                first = sec;
                sec = next;                
                
            }
            if (n > 0)
            {
                Console.WriteLine("The " + n + " term of fibonacci series is " + next);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
