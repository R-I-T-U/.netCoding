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
            int n, sum = 0;

            Console.WriteLine("Enter integers:(negative to stop)");

            while (true)
            {
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    break; // Exit the loop if a negative number is entered
                }

                sum += n; // Add the number to the sum
            }

            Console.WriteLine("Sum of the entered numbers is " + sum);
        }
    }
}
