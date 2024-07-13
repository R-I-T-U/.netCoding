using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app8
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Console.WriteLine("Enter integers:");

            while (true)
            {
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    break; // Exit the loop if a negative number is entered
                }

                sum += number; // Add the number to the sum
            }

            Console.WriteLine("Sum of the entered integers: " + sum);
        }
    }
}
