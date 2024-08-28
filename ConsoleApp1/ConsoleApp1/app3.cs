using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("Largest number is " + a);
                else 
                    Console.WriteLine("Largest number is "+c);
            }
            else 
            {
                if (b > c)
                    Console.WriteLine("Largest number is " + b);
                else 
                    Console.WriteLine("Largest number is " + c);
            }
            
            
        }
    }
}
