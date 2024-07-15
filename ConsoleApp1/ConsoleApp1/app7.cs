using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app7
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            // Find all divisors of the number (excluding itself)
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            // Check if the sum of divisors equals the number
            if (sum == n)
            {
                Console.WriteLine("it is a perfect number.");
            }
            else
            {
                Console.WriteLine("it is not a perfect number.");
            }
        }
    }
}
