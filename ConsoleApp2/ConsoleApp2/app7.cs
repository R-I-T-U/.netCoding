using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app7
    {
        public static int sum(int a, int b = 1)
        {
            return a + b;
        }
        public static int sub(int c, int d = 2)
        {
            return c - d;
        }
        public static void Main(string[] args)
        {
            int res1 = sum(1);
            int res2 = sub(d: 1, c: 2);
            Console.WriteLine("Optional parameter:" + res1);
            Console.WriteLine("Named Parameter:" + res2);
        }
    }
}