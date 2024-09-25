using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class q1
    {
        public static void Main(string[] args)
        {
            List<int> num = new List<int>() { 15, 3, 56, 7, 13 };
            IEnumerable<int> res = from n in num where n % 2 != 0 && n % 3 == 0 select n;
            Console.WriteLine("odd and those divisble by 3 number are:");
            foreach (int i in res)
                Console.Write(i+" ");

            Console.ReadKey();

        }
    }
}
