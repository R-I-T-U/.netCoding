using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app8
    {
        public static void Main(string[] args)
        {
            int x = 1;
            int[] y={2,3,4,5,6};
            int r = sum(x, y);
            Console.WriteLine("implementing params keyword, sum is "+r);

        }
        public static int sum(int x, params int[] y)
        {
            int r = 0;
            r += x;
            for (int i = 0; i < y.Length; i++)
            {
                r += y[i];
            }
            return r;

        }
    }
}
