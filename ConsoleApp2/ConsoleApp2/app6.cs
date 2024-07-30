using System;

namespace ConsoleApp2
{
    internal class app6
    {
        static void Main(string[] args)
        {
            int n = 10;

            Console.WriteLine("Original value: "+n);
            PassByValue(n);
            Console.WriteLine("Value after pass by value: "+n);

            PassByReference(ref n);
            Console.WriteLine("Value after pass by reference: "+n);
        }

        static void PassByValue(int n)
        {
           n++;
        }

        static void PassByReference(ref int n)
        {
            n++;
        }
    }
}
