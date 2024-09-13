using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// to illustrate the singlecast anf multicast delegate.
namespace lab7
{
    public class singleCast
    {
        public static int sum(int x, int y) {  return x + y; }
        public delegate int sumDel(int a, int b);
        static void Main()
        {
            sumDel del = new sumDel(sum);
            int r = del(2,3);
            Console.WriteLine("Sum of 2 and 3 = "+r);
            Console.ReadKey();
        }
    }
}
