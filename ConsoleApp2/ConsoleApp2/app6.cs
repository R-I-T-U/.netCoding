using System;

namespace ConsoleApp2
{
    internal class app6
    {
        static void Main(string[] args)
        {
            int n = 10;

            Console.WriteLine($"Original value: {n}");
            int r = PassByValue(n);
            Console.WriteLine($"Value after pass by value: {n} (original), {r} (returned)");

            PassByReference(ref n);
            Console.WriteLine($"Value after pass by reference: {n}");
        }

        static int PassByValue(int n)
        {
           n++;
            return n;
        }

        static void PassByReference(ref int n)
        {
            n++;
        }
    }
}
