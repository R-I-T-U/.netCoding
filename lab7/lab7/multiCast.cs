using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class multiCast
    {
        public static int add(int a, int b) { return a + b; }
        public static int sub(int a, int b) { return a - b; }
        public delegate int multiCastDel(int x, int y);
        static void Main()
        {
            multiCastDel del = new multiCastDel(add);
            Console.WriteLine("addition is "+del(2, 3));
            del += sub;
            Console.WriteLine("subtraction is "+del(5,3));
            Console.ReadKey();
        }
    }
}
