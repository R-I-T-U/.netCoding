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
            int number, originalNumber, result = 0, n = 0;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            originalNumber = number;

            while (number != 0)
            {
                int temp = number;
                temp %= 10;
                result += (temp * temp * temp);
                number /= 10;

            }

            if (result == originalNumber)
            {
                Console.WriteLine(" is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(" is not an Armstrong number.");
            }
        }
    }
}
