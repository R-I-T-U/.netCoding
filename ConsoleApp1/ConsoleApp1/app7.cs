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
            int number;
            int sumOfDivisors = 0;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            // Find all divisors of the number (excluding itself)
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            // Check if the sum of divisors equals the number
            if (sumOfDivisors == number)
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }
    }
}
